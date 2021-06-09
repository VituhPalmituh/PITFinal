using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraDoRemedio
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }

        private void btReturnLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void tbUserSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btConfirmSignUp_Click(object sender, EventArgs e)
        {
            UserInformation user = new UserInformation();
            string result = user.SignUp(tbUser.Text, tbName.Text, tbPassword.Text);

            if (result == "Correct")
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                FormLogin login = new FormLogin();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            else if (result == "Exists")
            {
                MessageBox.Show("Usuário já cadastrado, tente novamente!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
