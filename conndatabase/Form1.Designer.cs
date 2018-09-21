namespace conndatabase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetTables = new System.Windows.Forms.Button();
            this.cmbSeverName = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTableName = new System.Windows.Forms.ComboBox();
            this.severName = new System.Windows.Forms.Label();
            this.cmbDataName = new System.Windows.Forms.ComboBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnQuetIP = new System.Windows.Forms.Button();
            this.ckbLocal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetTables
            // 
            this.btnGetTables.Location = new System.Drawing.Point(47, 241);
            this.btnGetTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(180, 43);
            this.btnGetTables.TabIndex = 1;
            this.btnGetTables.Text = "Lấy Danh Sách Các Bảng";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSeverName
            // 
            this.cmbSeverName.FormattingEnabled = true;
            this.cmbSeverName.Location = new System.Drawing.Point(133, 68);
            this.cmbSeverName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSeverName.Name = "cmbSeverName";
            this.cmbSeverName.Size = new System.Drawing.Size(121, 24);
            this.cmbSeverName.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(133, 142);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(133, 187);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 22);
            this.txtPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "CSDL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table";
            // 
            // cmbTableName
            // 
            this.cmbTableName.FormattingEnabled = true;
            this.cmbTableName.Location = new System.Drawing.Point(133, 350);
            this.cmbTableName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTableName.Name = "cmbTableName";
            this.cmbTableName.Size = new System.Drawing.Size(121, 24);
            this.cmbTableName.TabIndex = 9;
            // 
            // severName
            // 
            this.severName.AutoSize = true;
            this.severName.Location = new System.Drawing.Point(43, 74);
            this.severName.Name = "severName";
            this.severName.Size = new System.Drawing.Size(82, 17);
            this.severName.TabIndex = 10;
            this.severName.Text = "SeverName";
            // 
            // cmbDataName
            // 
            this.cmbDataName.FormattingEnabled = true;
            this.cmbDataName.Location = new System.Drawing.Point(133, 304);
            this.cmbDataName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDataName.Name = "cmbDataName";
            this.cmbDataName.Size = new System.Drawing.Size(121, 24);
            this.cmbDataName.TabIndex = 11;
            this.cmbDataName.SelectedIndexChanged += new System.EventHandler(this.cmbDataName_SelectedIndexChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(91, 406);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(113, 32);
            this.btnLoadData.TabIndex = 12;
            this.btnLoadData.Text = "Lấy dữ liệu";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnQuetIP
            // 
            this.btnQuetIP.Location = new System.Drawing.Point(91, 12);
            this.btnQuetIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuetIP.Name = "btnQuetIP";
            this.btnQuetIP.Size = new System.Drawing.Size(100, 28);
            this.btnQuetIP.TabIndex = 13;
            this.btnQuetIP.Text = "Quét IP";
            this.btnQuetIP.UseVisualStyleBackColor = true;
            this.btnQuetIP.Click += new System.EventHandler(this.btnQuetIP_Click);
            // 
            // ckbLocal
            // 
            this.ckbLocal.AutoSize = true;
            this.ckbLocal.Location = new System.Drawing.Point(46, 97);
            this.ckbLocal.Name = "ckbLocal";
            this.ckbLocal.Size = new System.Drawing.Size(180, 21);
            this.ckbLocal.TabIndex = 14;
            this.ckbLocal.Text = "Windows Authentication";
            this.ckbLocal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbLocal);
            this.Controls.Add(this.btnQuetIP);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.cmbDataName);
            this.Controls.Add(this.severName);
            this.Controls.Add(this.cmbTableName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmbSeverName);
            this.Controls.Add(this.btnGetTables);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetTables;
        private System.Windows.Forms.ComboBox cmbSeverName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTableName;
        private System.Windows.Forms.Label severName;
        private System.Windows.Forms.ComboBox cmbDataName;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnQuetIP;
        private System.Windows.Forms.CheckBox ckbLocal;
    }
}

