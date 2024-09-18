namespace session07_Winform
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            lbMain = new Label();
            splitContainer1 = new SplitContainer();
            gbPicture = new GroupBox();
            btnImport = new Button();
            pbPicture = new PictureBox();
            gbPsInfo = new GroupBox();
            panel1 = new Panel();
            rdMale = new RadioButton();
            rFemale = new RadioButton();
            clbxLanguage = new CheckedListBox();
            btnExit = new Button();
            btnRegister = new Button();
            rdPrivate = new RadioButton();
            rdPublic = new RadioButton();
            listView1 = new ListView();
            mtbDate = new MaskedTextBox();
            txtMail = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            gbPsInfo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbMain
            // 
            lbMain.AutoSize = true;
            lbMain.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMain.Location = new Point(133, 9);
            lbMain.Name = "lbMain";
            lbMain.Size = new Size(512, 65);
            lbMain.TabIndex = 0;
            lbMain.Text = "Personal Register Form";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 77);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gbPicture);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gbPsInfo);
            splitContainer1.Size = new Size(797, 370);
            splitContainer1.SplitterDistance = 265;
            splitContainer1.TabIndex = 1;
            // 
            // gbPicture
            // 
            gbPicture.Controls.Add(btnImport);
            gbPicture.Controls.Add(pbPicture);
            gbPicture.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbPicture.Location = new Point(3, 3);
            gbPicture.Name = "gbPicture";
            gbPicture.Size = new Size(259, 364);
            gbPicture.TabIndex = 0;
            gbPicture.TabStop = false;
            gbPicture.Text = "Picture";
            // 
            // btnImport
            // 
            btnImport.Location = new Point(46, 318);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(150, 40);
            btnImport.TabIndex = 2;
            btnImport.Text = "Import >>";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // pbPicture
            // 
            pbPicture.Image = (Image)resources.GetObject("pbPicture.Image");
            pbPicture.Location = new Point(7, 22);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(246, 290);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 0;
            pbPicture.TabStop = false;
            // 
            // gbPsInfo
            // 
            gbPsInfo.Controls.Add(panel1);
            gbPsInfo.Controls.Add(clbxLanguage);
            gbPsInfo.Controls.Add(btnExit);
            gbPsInfo.Controls.Add(btnRegister);
            gbPsInfo.Controls.Add(rdPrivate);
            gbPsInfo.Controls.Add(rdPublic);
            gbPsInfo.Controls.Add(listView1);
            gbPsInfo.Controls.Add(mtbDate);
            gbPsInfo.Controls.Add(txtMail);
            gbPsInfo.Controls.Add(txtName);
            gbPsInfo.Controls.Add(label5);
            gbPsInfo.Controls.Add(label4);
            gbPsInfo.Controls.Add(label3);
            gbPsInfo.Controls.Add(label2);
            gbPsInfo.Controls.Add(label1);
            gbPsInfo.Location = new Point(3, 3);
            gbPsInfo.Name = "gbPsInfo";
            gbPsInfo.Size = new Size(522, 358);
            gbPsInfo.TabIndex = 0;
            gbPsInfo.TabStop = false;
            gbPsInfo.Text = "Personal Information";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdMale);
            panel1.Controls.Add(rFemale);
            panel1.Location = new Point(171, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 38);
            panel1.TabIndex = 15;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Checked = true;
            rdMale.Location = new Point(12, 11);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(51, 19);
            rdMale.TabIndex = 7;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = false;
            // 
            // rFemale
            // 
            rFemale.AutoSize = true;
            rFemale.Location = new Point(69, 11);
            rFemale.Name = "rFemale";
            rFemale.Size = new Size(63, 19);
            rFemale.TabIndex = 7;
            rFemale.Text = "Female";
            rFemale.UseVisualStyleBackColor = true;
            // 
            // clbxLanguage
            // 
            clbxLanguage.FormattingEnabled = true;
            clbxLanguage.Items.AddRange(new object[] { "Vietnamese", "Chinese", "English", "Franch", "Korean" });
            clbxLanguage.Location = new Point(171, 198);
            clbxLanguage.Name = "clbxLanguage";
            clbxLanguage.Size = new Size(282, 94);
            clbxLanguage.TabIndex = 14;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(340, 309);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exist";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(225, 309);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // rdPrivate
            // 
            rdPrivate.AutoSize = true;
            rdPrivate.Location = new Point(146, 311);
            rdPrivate.Name = "rdPrivate";
            rdPrivate.Size = new Size(61, 19);
            rdPrivate.TabIndex = 11;
            rdPrivate.Text = "Private";
            rdPrivate.UseVisualStyleBackColor = true;
            // 
            // rdPublic
            // 
            rdPublic.AutoSize = true;
            rdPublic.Checked = true;
            rdPublic.Location = new Point(82, 311);
            rdPublic.Name = "rdPublic";
            rdPublic.Size = new Size(58, 19);
            rdPublic.TabIndex = 10;
            rdPublic.TabStop = true;
            rdPublic.Text = "Public";
            rdPublic.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(72, 298);
            listView1.Name = "listView1";
            listView1.Size = new Size(381, 50);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mtbDate
            // 
            mtbDate.Location = new Point(171, 125);
            mtbDate.Mask = "00/00/0000";
            mtbDate.Name = "mtbDate";
            mtbDate.Size = new Size(282, 23);
            mtbDate.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(171, 85);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(282, 23);
            txtMail.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 23);
            txtName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(31, 184);
            label5.Name = "label5";
            label5.Size = new Size(109, 30);
            label5.TabIndex = 4;
            label5.Text = "Language:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(55, 148);
            label4.Name = "label4";
            label4.Size = new Size(85, 30);
            label4.TabIndex = 3;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(4, 112);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(72, 76);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(lbMain);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            gbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            gbPsInfo.ResumeLayout(false);
            gbPsInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMain;
        private SplitContainer splitContainer1;
        private GroupBox gbPicture;
        private PictureBox pbPicture;
        private GroupBox gbPsInfo;
        private Button btnImport;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rFemale;
        private RadioButton rdMale;
        private MaskedTextBox mtbDate;
        private TextBox txtMail;
        private TextBox txtName;
        private Button btnRegister;
        private RadioButton rdPrivate;
        private RadioButton rdPublic;
        private ListView listView1;
        private Button btnExit;
        private CheckedListBox clbxLanguage;
        private Panel panel1;
    }
}
