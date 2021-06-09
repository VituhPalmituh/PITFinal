using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoRemedio
{
    public class UserInformation
    {
        private int idUser;
        private string nameLogin;
        private string userLogin;
        private string passwordLogin;

        public int IdUser { get => idUser; set => idUser = value; }
        public string NameLogin { get => nameLogin; set => nameLogin = value; }
        public string UserLogin { get => userLogin; set => userLogin = value; }
        public string PasswordLogin { get => passwordLogin; set => passwordLogin = value; }

        public DataTable SelectUser(string userLogin, string userPassword)
        {
            var connection = new DB();
            string selectLogin = $"SELECT * FROM UserInformation WHERE UserLogin = '{userLogin}' AND PasswordLogin = '{userPassword}'";
            var result = connection.ExecutarSelect(selectLogin);

            return result;
        }
        public string Connect(string userLogin, string userPassword)
        {
            var connection = new DB();
            string selectLogin = $"SELECT * FROM UserInformation WHERE UserLogin = '{userLogin}' AND PasswordLogin = '{userPassword}'";
            var result = connection.ExecutarSelect(selectLogin);
            string login = "";
            if (result != null && result.Rows.Count > 0)
            {
                login = "Correct";
            }
            else
            {
                login = "Incorrect";
            }

            return login;
        }

        public string SignUp(string userSignUp, string nameSignUp, string passwordSignUp)
        {
            string signUpResult = "";

            if (userSignUp == "" || nameSignUp == "" || passwordSignUp == "")
            {
                signUpResult = "Blank";
            }
            else
            {
                var connection = new DB();
                var values = new Dictionary<string, object>();
                values.Add("UserLogin", userSignUp);
                values.Add("NameLogin", nameSignUp);
                values.Add("PasswordLogin", passwordSignUp);

                var result = connection.ExecutarInsert(values, "UserInformation");

                if (result == "")
                {
                    signUpResult = "Correct";
                }
                else if (result.Contains("UNIQUE"))
                {
                    signUpResult = "Exists";
                }
                else
                {
                    signUpResult = "Error";
                }
            }

            return signUpResult;
        }
    }
}
