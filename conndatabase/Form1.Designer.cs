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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(362, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetTables
            // 
            this.btnGetTables.Location = new System.Drawing.Point(35, 196);
            this.btnGetTables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(135, 35);
            this.btnGetTables.TabIndex = 1;
            this.btnGetTables.Text = "Lấy Danh Sách Các Bảng";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSeverName
            // 
            this.cmbSeverName.FormattingEnabled = true;
            this.cmbSeverName.Location = new System.Drawing.Point(100, 68);
            this.cmbSeverName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSeverName.Name = "cmbSeverName";
            this.cmbSeverName.Size = new System.Drawing.Size(92, 21);
            this.cmbSeverName.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 115);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(76, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(100, 152);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(76, 20);
            this.txtPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CSDL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table";
            // 
            // cmbTableName
            // 
            this.cmbTableName.FormattingEnabled = true;
            this.cmbTableName.Location = new System.Drawing.Point(100, 284);
            this.cmbTableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTableName.Name = "cmbTableName";
            this.cmbTableName.Size = new System.Drawing.Size(92, 21);
            this.cmbTableName.TabIndex = 9;
            // 
            // severName
            // 
            this.severName.AutoSize = true;
            this.severName.Location = new System.Drawing.Point(32, 73);
            this.severName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.severName.Name = "severName";
            this.severName.Size = new System.Drawing.Size(63, 13);
            this.severName.TabIndex = 10;
            this.severName.Text = "SeverName";
            // 
            // cmbDataName
            // 
            this.cmbDataName.FormattingEnabled = true;
            this.cmbDataName.Location = new System.Drawing.Point(100, 247);
            this.cmbDataName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDataName.Name = "cmbDataName";
            this.cmbDataName.Size = new System.Drawing.Size(92, 21);
            this.cmbDataName.TabIndex = 11;
            this.cmbDataName.SelectedIndexChanged += new System.EventHandler(this.cmbDataName_SelectedIndexChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(68, 330);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(85, 26);
            this.btnLoadData.TabIndex = 12;
            this.btnLoadData.Text = "Lấy dữ liệu";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnQuetIP
            // 
            this.btnQuetIP.Location = new System.Drawing.Point(68, 27);
            this.btnQuetIP.Name = "btnQuetIP";
            this.btnQuetIP.Size = new System.Drawing.Size(75, 23);
            this.btnQuetIP.TabIndex = 13;
            this.btnQuetIP.Text = "Quét IP";
            this.btnQuetIP.UseVisualStyleBackColor = true;
            this.btnQuetIP.Click += new System.EventHandler(this.btnQuetIP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

