namespace session07_Winform
{
    partial class ADOApp
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
            label1 = new Label();
            lbCode = new Label();
            lbName = new Label();
            lbPrice = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvItem = new DataGridView();
            colCode = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(776, 86);
            label1.TabIndex = 0;
            label1.Text = "Item Management System";
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Font = new Font("Segoe UI", 15.75F);
            lbCode.Location = new Point(15, 166);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(66, 30);
            lbCode.TabIndex = 1;
            lbCode.Text = "Code:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 15.75F);
            lbName.Location = new Point(7, 204);
            lbName.Name = "lbName";
            lbName.Size = new Size(74, 30);
            lbName.TabIndex = 2;
            lbName.Text = "Name:";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 15.75F);
            lbPrice.Location = new Point(18, 242);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(63, 30);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price:";
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 15.75F);
            txtCode.Location = new Point(87, 167);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(200, 35);
            txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15.75F);
            txtName.Location = new Point(87, 204);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 35);
            txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 15.75F);
            txtPrice.Location = new Point(87, 242);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 35);
            txtPrice.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(98, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(193, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvItem
            // 
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Columns.AddRange(new DataGridViewColumn[] { colCode, colName, colPrice });
            dgvItem.Location = new Point(364, 167);
            dgvItem.Name = "dgvItem";
            dgvItem.Size = new Size(424, 271);
            dgvItem.TabIndex = 10;
            dgvItem.MouseClick += dgvItem_MouseClick;
            // 
            // colCode
            // 
            colCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCode.DataPropertyName = "ICode";
            colCode.HeaderText = "Code";
            colCode.Name = "colCode";
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.DataPropertyName = "ItemName";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            // 
            // colPrice
            // 
            colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrice.DataPropertyName = "Rate";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Location = new Point(12, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 61);
            panel1.TabIndex = 12;
            // 
            // ADOApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvItem);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
            Controls.Add(lbCode);
            Controls.Add(label1);
            Name = "ADOApp";
            Text = "ADOApp";
            Load += ADOApp_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbCode;
        private Label lbName;
        private Label lbPrice;
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvItem;
        private Panel panel1;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
    }
}