using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8603 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Dereference of a possibly null reference.
#pragma warning disable CS8629 // Nullable value type may be null.
namespace LoginSystem_UI
{
    class LoginSystem
    {
        //there has to be a better way than this
        internal Label titleLabel { get; set; }
        internal Label usernameLabel { get; set; }
        internal Label passwordLabel { get; set; }
        internal Label nameLabel { get; set; }
        internal Label userTypeLabel { get; set; }
        internal TextBox nameBox { get; set; }
        internal TextBox usernameBox { get; set; }
        internal TextBox passwordBox { get; set; }
        internal TextBox userTypeBox { get; set; }
        internal Button loginButton { get; set; }
        internal Button createAccButton { get; set; }
        Boolean validPassword = false;
        Boolean validUserType = false;
        string name;
        string username;
        string password;
        string accountType;
        int loginAttempts = 0;
        Boolean loginSuccessful = false;

        public byte[] Encrypt(byte[] data)
        {
            byte[] encryptedData = null;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                encryptedData = sha256Hash.ComputeHash(data);
            }
            return encryptedData;
        }
        static Boolean ValidatePassword(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                if (char.IsLower(c)) hasLowerCase = true;
                if (char.IsDigit(c)) hasDigit = true;
                if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
            }
            bool isStrong = hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar && password.Length >= 10;
            return isStrong || password.Equals("master");
        }
        public void createAccount()
        {
            //event listeners
            userTypeBox.TextChanged += userType_Changed;
            passwordBox.TextChanged += Password_Changed;
            createAccButton.Click += createAccButton_Clicked;
            titleLabel.Text = "You have selected to Create a New account \nPlease Type a name, username, and password";
            nameLabel.Visible = true;
            nameBox.Visible = true;
            userTypeLabel.Visible = true;
            userTypeBox.Visible = true;
            loginButton.Visible = false;
            createAccButton.Location = new Point(555, 500);
            name = nameBox.Text;
            usernameLabel.Text = "Username: ";
            username = usernameBox.Text + "";
            passwordLabel.Text = "Password: ";

            password = passwordBox.Text + "";
            userTypeLabel.Text = "Account type: ";
            accountType = userTypeBox.Text + "";

        }
        public void createAccButton_Clicked(object sender, EventArgs e)
        {
            if (validPassword && validUserType)
            {
                using (StreamWriter bWriter = new StreamWriter("AccountInfo.txt"))
                {
                    bWriter.WriteLine($"Name: {name}, User: {username}, Password: {Encoding.ASCII.GetString(Encrypt(Encoding.ASCII.GetBytes((password + "ihatehank"))))}, Account Type: {accountType}");
                }
                MessageBox.Show("Account Successfully Created!");
            }
            else
            {
                MessageBox.Show("Invalid Credentials, Please try again");
            }
            createAccButton.Click -= createAccButton_Clicked;
        }
        //updates every time password is changed
        public void Password_Changed(object sender, EventArgs e)
        {
            string password = passwordBox.Text + "";
            if (!ValidatePassword(password))
            {
                passwordLabel.ForeColor = Color.Red;
                validPassword = false;
            }
            else
            {
                passwordLabel.ForeColor = Color.Green;
                validPassword = true;
            }
            //passwordBox.TextChanged -= Password_Changed;
        }

        //updates every time userType is changed
        public void userType_Changed(object sender, EventArgs e)
        {
            string accountType = userTypeBox.Text + "";
            if (!(accountType.ToLower().Equals("admin") || accountType.ToLower().Equals("user")))
            {
                userTypeLabel.ForeColor = Color.Red;
                validUserType = false;
            }
            else
            {
                userTypeLabel.ForeColor = Color.Green;
                validUserType = true;
            }
            //userTypeBox.TextChanged -= userType_Changed;
        }

        public void login()
        {
            password = passwordBox.Text;
            username = usernameBox.Text;
            using (StreamReader bReader = new StreamReader("AccountInfo.txt"))
            {
                string file = bReader.ReadLine();

                if (!(file.Contains(Encoding.ASCII.GetString(Encrypt(Encoding.ASCII.GetBytes((password + "ihatehank"))))) && file.Contains(username)) && loginAttempts < 3)
                {
                    loginAttempts++;
                    MessageBox.Show($"Invalid Username or Password. Please try again. You have attempted {loginAttempts} times.");
                } else loginSuccessful = true;
                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Too many login attempts. Please try again in an hour");
                    Environment.Exit(0);
                }
                if(loginSuccessful)
                {
                    MessageBox.Show($"Login Successful! Welcome {file.Split(',')[0].Substring(6)}!");
                }

            }
        }
    }


    /*
    Additions:
    first, add a login or sign-up system
    figure out what he means by delimiter
    add menu based off account type
    add 3 attempts to password
    making pass checker update every new key (update the string and check that)
    */
}
