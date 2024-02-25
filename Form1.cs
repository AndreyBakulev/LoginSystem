using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem_UI
{
    public partial class Form1 : Form
    {
        LoginSystem ls = new LoginSystem();
        public Form1()
        {
            InitializeComponent();
        }
        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //logging in
            ls.usernameBox = usernameBox;
            ls.passwordBox = passwordBox; 
            ls.login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creating an account
            //prob a better way of doing this ask polizano
            ls.usernameLabel = usernameLabel;
            ls.passwordLabel = passwordLabel;
            ls.titleLabel = TitleLabel;
            ls.nameLabel = nameLabel;
            ls.userTypeLabel = userTypeLabel;
            ls.nameBox = nameBox;
            ls.usernameBox = usernameBox;
            ls.passwordBox = passwordBox;
            ls.userTypeBox = userTypeBox;
            ls.loginButton = loginButton;
            ls.createAccButton = createAccButton;
            ls.createAccount();
        }
    }
}
