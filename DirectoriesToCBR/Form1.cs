using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DirectoriesToCBR
{
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
        }

        private string SelectedVolumeBeforeEdit = "";
        private string OutputDirectory = "";
        private string LastSelectedFolder = "";

        private List<string> VolumeDirectories = new List<string>();
        private List<string> ImageFilesDirectories = new List<string>();
        private List<string> ImageDirectories = new List<string>();

        private Dictionary<int, string> ListOfCovers = new Dictionary<int, string>();

        private void pbVolumeAddSeveral_Click(object sender, EventArgs e)
        {
            UserInputSeveral userInputSeveral = new UserInputSeveral();
            userInputSeveral.ShowDialog();

            string prefix = userInputSeveral.GetPrefix();
            int quantity = userInputSeveral.GetQuantity();

            for (int i = 0; i < quantity; i++)
            {
                dgVolumes.Rows.Add(prefix + " " + (i+1).ToString("00"));

            }
        }

        private void ShowErrorMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Boolean ValidarInsersaoVolumes(string input)
        {
            if (input == String.Empty)
            {
                ShowErrorMessage("Entrada vazia!", "É necessário digitar um nome para o volume!");
                return true;
            }

            if (ValidateInsertedValue(input))
            {
                ShowErrorMessage("Volume já inserido", "O volume que você está tentando inserir já existe na lista!");
                return true;
            }

            string[] specialChars = { "<", ">", ":", "\"", "/", "\\", "|", "?", "*" };
            if(input!=null)
            foreach (string c in specialChars.Where(input.Contains))
            {
                ShowErrorMessage("Caracter inválido", "O nome de uma pasta não pode conter nenhum dos seguintes caracteres: <, >, :, \", /, \\, |, ?, *");
                return true;
            }

            return false;
        }


        private Boolean ValidateInsertedValue(string value)
        { //descobrir forma de unificar esse com endedit
            foreach (DataGridViewRow row in dgVolumes.Rows)
            {
                if ((row.Cells[0].Value.ToString() == value))
                    return true;
            }
            return false;
        }

        private void pbVolumeAddOne_Click(object sender, EventArgs e)
        {
            UserInput userInput = new UserInput();
            userInput.ShowDialog();
            string inputResult = userInput.GetUserInput();

            if (ValidarInsersaoVolumes(inputResult)) return;

            dgVolumes.Rows.Add(inputResult);
        }

        private void dgVolumes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int row = 0; row < dgVolumes.Rows.Count; row++)
            {
                if (dgVolumes.Rows[row].Cells[0].Value != null &&
                    row != e.RowIndex &&
                    dgVolumes.Rows[row].Cells[0].Value.Equals(dgVolumes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                {
                    ShowErrorMessage("Volume já inserido", "O volume que você está tentando inserir já existe na lista!");
                    dgVolumes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = SelectedVolumeBeforeEdit;
                }
            }
        }

        private void dgVolumes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelectedVolumeBeforeEdit = dgVolumes.CurrentCell.Value.ToString();

            string CrrCellValue = (dgVolumes.CurrentRow.Cells[1].Value == null ? "" : dgVolumes.CurrentRow.Cells[1].Value.ToString());

            try
            {
                cbCovers.SelectedIndex = ((CrrCellValue == string.Empty) ? -1 : int.Parse(CrrCellValue));
            }
            catch
            {

            }
            ShowFoldersFromSelectedVolume();
        }

        private void dgVolumes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Deseja realmente deletar o volume selecionado?",
                   "Deletar Volume",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for(int i = 0; i < dgPastas.Rows.Count; i++)
                    {
                        if (int.Parse(dgPastas.Rows[i].Cells[0].Value.ToString()) == dgVolumes.CurrentCell.RowIndex)
                        {
                            dgPastas.Rows.RemoveAt(i);
                            i--;
                        }
                    }

                    dgVolumes.Rows.RemoveAt(dgVolumes.CurrentCell.RowIndex);
                }
            }
        }

        private void pbAddFolders_Click(object sender, EventArgs e)
        {
            if (dgVolumes.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Volume selecionado!", "Volume", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (string folder in SelectFolders())
            {
                dgPastas.Rows.Add(dgVolumes.CurrentCell.RowIndex, folder);
            }

        }

        private void ShowFoldersFromSelectedVolume()
        { 
            foreach (DataGridViewRow row in dgPastas.Rows)
            {
                row.Visible = (int.Parse(row.Cells[0].Value.ToString()) == dgVolumes.CurrentCell.RowIndex);
            }
        }

        private string[] SelectFolders()
        {
            string[] empty = { };

            CommonOpenFileDialog openFolder = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = true,
                Multiselect = true,
                IsFolderPicker = true,
                DefaultDirectory = LastSelectedFolder,
                Title = "Selecionar pastas"
            };

            if (openFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                LastSelectedFolder = Directory.GetParent(openFolder.FileNames.ToArray()[0]).Name;
                return openFolder.FileNames.ToArray();
            }

            return empty;
        }

        private string[] SelectCovers()
        {
            string[] empty = { };


            CommonOpenFileDialog openFolder = new CommonOpenFileDialog
            {
                Multiselect = true,
                Title = "Selecionar covers"
            };

            if (openFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return openFolder.FileNames.ToArray();
            }

            return empty;
        }

        private void pbAddCovers_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string folder in SelectCovers())
            {
                if (!cbCovers.Items.Contains(folder))
                {   
                    cbCovers.Items.Add(folder);
                    ListOfCovers.Add(i, folder);
                    i++;
                }
            }
        }

        private void smiLimparTudo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente limpar a lista de covers?", 
                "Deletar Cover", 
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cbCovers.Items.Clear();
                ListOfCovers.Clear();
            }
        }

        private void cbCovers_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbCover.ImageLocation = ((cbCovers.SelectedIndex != -1) ? cbCovers.SelectedItem.ToString() : "");

            if (dgVolumes.Rows.Count > 0)
            {
                dgVolumes.CurrentRow.Cells[1].Value = cbCovers.SelectedIndex;
            }
        }

        private void smiLimparSelecionada_Click(object sender, EventArgs e)
        {
            cbCovers.SelectedIndex = -1;
        }

        private void dgPastas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Deseja realmente deletar a pasta selecionada?",
                   "Deletar Pasta",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgVolumes.Rows.RemoveAt(dgVolumes.CurrentCell.RowIndex);
                }
            }
        }

        private void ttmiOutputDir_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFolder = new CommonOpenFileDialog
            {
                AllowNonFileSystemItems = true,
                IsFolderPicker = true,
                Title = "Selecionar diretório de saída",
                InitialDirectory = OutputDirectory
            };

            if (openFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                OutputDirectory = openFolder.FileName;
                ttmiOutputDir.ToolTipText = OutputDirectory;
            }

        }

        private Boolean ValidarGerar()
        {
            if (OutputDirectory == string.Empty)
            {
                MessageBox.Show("Nenhum diretório de saída selecionado!", "Diretório de saída vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (dgVolumes.Rows.Count == 0)
            {
                MessageBox.Show("Não existem volumes a serem criados!", "Problema ao gerar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void edtLog_TextChanged(object sender, EventArgs e)
        {
            edtLog.SelectionStart = edtLog.Text.Length;
            edtLog.ScrollToCaret();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (ValidarGerar()) return;
              edtLog.Clear();
            try
            {
                GerarCBRs();
                CompactarCBRs();
                ApagarPastasArquivosGerados();
            }
            catch (Exception ex)
            {
                CriaLog("");
                CriaLog("Ocorreu um erro ao criar arquivos .cbr");
                CriaLog(ex.Message);
            }
            
        }

        private void GerarCBRs()
        {
            foreach (DataGridViewRow row in dgVolumes.Rows)
            {
                int coverIndex = ((row.Cells[1].Value == null) ? -1 : int.Parse(row.Cells[1].Value.ToString()));

                string VolPath = CreateDirectory(row.Cells[0].Value.ToString());
                VolumeDirectories.Add(VolPath);
                CopyCoverToDirectory(coverIndex, VolPath);
                CopyImageFilesToVolumeDirectory(row.Index, VolPath);
            }
        }

        private void CompactarCBRs()
        {
            foreach (string volume in VolumeDirectories)
            {
                string cbrName = volume + ".cbr";
                if (File.Exists(cbrName))
                {
                    CriaLog(string.Format("{0} já existe. Excluindo arquivo antigo.", cbrName));
                    File.Delete(cbrName);
                }

                CriaLog(string.Format("Compactando {0} para {1}", volume, cbrName));
                ZipFile.CreateFromDirectory(volume, cbrName);
            }
        }

        private void ApagarPastasArquivosGerados()
        {
            foreach (string folder in VolumeDirectories)
            {
                if (Directory.Exists(folder))
                {
                    CriaLog(string.Format("Excluindo diretório {0}", folder));
                    Directory.Delete(folder, true);
                }
            }

        }


        private void CriaLog(string logMessage) 
        {
            edtLog.Text += (edtLog.Text == string.Empty ? "" : Environment.NewLine) + logMessage;
            Update();
        }


        private string CreateDirectory(string volume)
        {
            string newDirectory = string.Format("{0}\\{1}", OutputDirectory, volume);
            if (!Directory.Exists(newDirectory))
            {
                CriaLog("Criando " + newDirectory);
                Directory.CreateDirectory(newDirectory);
            }
            else
            {
                CriaLog(string.Format("Diretório {0} já existe. Pulando.", newDirectory));
            }

            return newDirectory;
        }

        private string CreateImageDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                CriaLog("Criando " + directory);
                Directory.CreateDirectory(directory);
            }
            else
            {
                CriaLog(string.Format("Diretório {0} já existe. Pulando.", directory));
            }

            return directory;
        }

        private void CopyCoverToDirectory(int coverIndex, string volPath)
        {
            if (coverIndex != -1)
                if (ListOfCovers.TryGetValue(coverIndex, out string CoverPath))
                {
                    CriaLog(string.Format("Copiando cover de {0} para {1}", CoverPath, volPath));

                    volPath = volPath + "\\_cover";
                    if (!Directory.Exists(volPath))
                        Directory.CreateDirectory(volPath);

                    ImageDirectories.Add(volPath + "\\_cover.jpg");
                    File.Copy(CoverPath, volPath + "\\_cover.jpg", true);
                }
        }

        private void CopyImageFilesToVolumeDirectory(int volumeIndex, string volPath)
        {
            foreach (DataGridViewRow row in dgPastas.Rows)
            {
                if (row.Cells[0].Value.Equals(volumeIndex))
                {
                    
                    string originalImageFolderName = new DirectoryInfo(row.Cells[1].Value.ToString()).Name;  //Path.();
                    string imageFolder = string.Format("{0}\\{1}",volPath, originalImageFolderName);

                    ImageFilesDirectories.Add(imageFolder);
                    CreateImageDirectory(imageFolder);

                    CopyImageToVolumeDirectory(row.Cells[1].Value.ToString(), volPath + "\\" + originalImageFolderName);

                }
            }
        }

        private void CopyImageToVolumeDirectory(string source, string destination)
        {
            foreach (string newPath in Directory.GetFiles(source))
            {
                CriaLog(string.Format("Copiando imagem de {0} para {1}", newPath, destination));
                File.Copy(newPath, newPath.Replace(source, destination), true); 
            }
        }
    }
}
