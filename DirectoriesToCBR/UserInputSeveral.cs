using System;
using System.Linq;
using System.Windows.Forms;

namespace DirectoriesToCBR
{
    public partial class UserInputSeveral : Form
    {
        public UserInputSeveral()
        {
            InitializeComponent();
        }
        private int Quantity;
        private string Prefix;

        private void btnOK_Click(object sender, EventArgs e)
        {
            Confirmar();
        }
        private bool ValidarInsersaoVolumes(string input)
        {
            if (input == String.Empty)
            {
                ShowErrorMessage("Entrada vazia!", "É necessário digitar um nome para o volume!");
                return true;
            }

            string[] specialChars = { "<", ">", ":", "\"", "/", "\\", "|", "?", "*" };

            foreach (string c in specialChars.Where(input.Contains))
            {
                ShowErrorMessage("Caracter inválido", "O nome de uma pasta não pode conter nenhum dos seguintes caracteres: <, >, :, \", /, \\, |, ?, *");
                return true;
            }

            return false;
        }

        private void ShowErrorMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Confirmar()
        {
            Quantity = int.Parse(edtQtdVolumes.Value.ToString());
            Prefix = edtUserInput.Text;

            if(!ValidarInsersaoVolumes(Prefix))
              Close();
        }

        public string GetPrefix()
        {
            return Prefix;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
    }
}
