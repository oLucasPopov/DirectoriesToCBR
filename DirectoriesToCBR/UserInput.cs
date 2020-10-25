using System;
using System.Linq;
using System.Windows.Forms;

namespace DirectoriesToCBR
{
    public partial class UserInput : Form
    {
        public UserInput()
        {
            InitializeComponent();
        }

        private string UserEnteredInput;

        private void btnOK_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        public bool Validar(string input)
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
            UserEnteredInput = txtUserInput.Text.Trim();
            if(!Validar(UserEnteredInput))
              Close();
        }

        public string GetUserInput()
        {
            return UserEnteredInput;
        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Confirmar();
            }
        }
    }
}
