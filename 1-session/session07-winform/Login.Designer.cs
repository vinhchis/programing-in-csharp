namespace session07_Winform
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 86);
            label1.TabIndex = 0;
            label1.Text = "ACP Login";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.Transparent;
            lbEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbEmail.ForeColor = SystemColors.Info;
            lbEmail.Location = new Point(48, 138);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(106, 25);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Username:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.Transparent;
            lbPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbPassword.ForeColor = SystemColors.Info;
            lbPassword.Location = new Point(58, 200);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(97, 25);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14.25F);
            txtUsername.Location = new Point(165, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(269, 33);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F);
            txtPassword.Location = new Point(165, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(269, 33);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14.25F);
            btnLogin.Location = new Point(325, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(109, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(497, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbEmail;
        private Label lbPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}