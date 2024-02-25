namespace LoginSystem_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.userTypeBox = new System.Windows.Forms.TextBox();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(318, 246);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(142, 37);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(326, 342);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(134, 37);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(505, 246);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(291, 43);
            this.usernameBox.TabIndex = 4;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(505, 342);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(291, 43);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(388, 61);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(441, 37);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Welcome To Andrey\'s Login System!";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(405, 500);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(128, 105);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createAccButton
            // 
            this.createAccButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccButton.Location = new System.Drawing.Point(705, 500);
            this.createAccButton.Name = "createAccButton";
            this.createAccButton.Size = new System.Drawing.Size(128, 105);
            this.createAccButton.TabIndex = 8;
            this.createAccButton.Text = "Create Account";
            this.createAccButton.UseVisualStyleBackColor = true;
            this.createAccButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(366, 156);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 37);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(505, 156);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(291, 43);
            this.nameBox.TabIndex = 10;
            this.nameBox.Visible = false;
            // 
            // userTypeBox
            // 
            this.userTypeBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeBox.Location = new System.Drawing.Point(505, 423);
            this.userTypeBox.Name = "userTypeBox";
            this.userTypeBox.Size = new System.Drawing.Size(291, 43);
            this.userTypeBox.TabIndex = 11;
            this.userTypeBox.Visible = false;
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.Location = new System.Drawing.Point(321, 423);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(139, 37);
            this.userTypeLabel.TabIndex = 12;
            this.userTypeLabel.Text = "User Type:";
            this.userTypeLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 738);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.userTypeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createAccButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form1";
            this.Text = "Login System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.Label passwordLabel;
        public System.Windows.Forms.TextBox usernameBox;
        public System.Windows.Forms.TextBox passwordBox;
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.Button createAccButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox userTypeBox;
        private System.Windows.Forms.Label userTypeLabel;
    }
}

