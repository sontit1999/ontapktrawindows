namespace de2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.txtCHieucao = new System.Windows.Forms.TextBox();
            this.txtDuongsinh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDsnon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNon = new System.Windows.Forms.RadioButton();
            this.rbLangtru = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hình học không gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tính";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thể tích",
            "Diện tích XQ"});
            this.comboBox1.Location = new System.Drawing.Point(122, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bán kính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chiều cao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đườn sinh";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(468, 79);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(184, 20);
            this.txtBanKinh.TabIndex = 6;
            // 
            // txtCHieucao
            // 
            this.txtCHieucao.Location = new System.Drawing.Point(468, 130);
            this.txtCHieucao.Name = "txtCHieucao";
            this.txtCHieucao.Size = new System.Drawing.Size(184, 20);
            this.txtCHieucao.TabIndex = 7;
            // 
            // txtDuongsinh
            // 
            this.txtDuongsinh.Location = new System.Drawing.Point(468, 181);
            this.txtDuongsinh.Name = "txtDuongsinh";
            this.txtDuongsinh.Size = new System.Drawing.Size(184, 20);
            this.txtDuongsinh.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(259, 259);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 27);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(398, 259);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 27);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "XÓa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDsnon
            // 
            this.btnDsnon.Location = new System.Drawing.Point(523, 259);
            this.btnDsnon.Name = "btnDsnon";
            this.btnDsnon.Size = new System.Drawing.Size(210, 27);
            this.btnDsnon.TabIndex = 11;
            this.btnDsnon.Text = "Danh sách hình nón";
            this.btnDsnon.UseVisualStyleBackColor = true;
            this.btnDsnon.Click += new System.EventHandler(this.btnDsnon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hình";
            // 
            // rbNon
            // 
            this.rbNon.AutoSize = true;
            this.rbNon.Location = new System.Drawing.Point(122, 156);
            this.rbNon.Name = "rbNon";
            this.rbNon.Size = new System.Drawing.Size(68, 17);
            this.rbNon.TabIndex = 13;
            this.rbNon.TabStop = true;
            this.rbNon.Text = "Hinh nón";
            this.rbNon.UseVisualStyleBackColor = true;
            this.rbNon.CheckedChanged += new System.EventHandler(this.rbNon_CheckedChanged);
            // 
            // rbLangtru
            // 
            this.rbLangtru.AutoSize = true;
            this.rbLangtru.Location = new System.Drawing.Point(230, 158);
            this.rbLangtru.Name = "rbLangtru";
            this.rbLangtru.Size = new System.Drawing.Size(85, 17);
            this.rbLangtru.TabIndex = 14;
            this.rbLangtru.TabStop = true;
            this.rbLangtru.Text = "Hình lăng trụ";
            this.rbLangtru.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 298);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(716, 95);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Loai hinh";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ban kinh";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chieu cao";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duong sinh";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dtxq";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "the tich";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbLangtru);
            this.Controls.Add(this.rbNon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDsnon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDuongsinh);
            this.Controls.Add(this.txtCHieucao);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.TextBox txtCHieucao;
        private System.Windows.Forms.TextBox txtDuongsinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDsnon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbNon;
        private System.Windows.Forms.RadioButton rbLangtru;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

