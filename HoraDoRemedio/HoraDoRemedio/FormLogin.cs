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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            UserInformation user = new UserInformation();
            string result = user.Connect(tbUser.Text, tbPassword.Text);

            if (result == "Correct")
            {
                FormMenu menu = new FormMenu();
                DataTable resultUser = user.SelectUser(tbUser.Text, tbPassword.Text);
                menu.IdUser = Convert.ToInt32(resultUser.Rows[0]["IdUser"]);
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else if (result == "Incorrect")
            {
                MessageBox.Show("Usuário ou Senha incorretos.");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            FormSignUp signup = new FormSignUp();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
