namespace GUI
{
    partial class TaoLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoLop));
            this.label3 = new System.Windows.Forms.Label();
            this.btnChuyenLop = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXemLop = new System.Windows.Forms.Button();
            this.DSLopCoSan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSChuaCoLop = new System.Windows.Forms.DataGridView();
            this.MAHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSLopCoSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSChuaCoLop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(132, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tạo danh sách lớp mới";
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChuyenLop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenLop.BackgroundImage")));
            this.btnChuyenLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChuyenLop.Location = new System.Drawing.Point(374, 276);
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.Size = new System.Drawing.Size(55, 44);
            this.btnChuyenLop.TabIndex = 11;
            this.btnChuyenLop.UseVisualStyleBackColor = false;
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click_1);
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(105, 73);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 22);
            this.cboLop.TabIndex = 18;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(105, 24);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(121, 22);
            this.cboNamHoc.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(20, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Năm học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(83, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Danh sách lớp mới";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXemLop);
            this.panel2.Controls.Add(this.DSLopCoSan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboLop);
            this.panel2.Controls.Add(this.cboNamHoc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(478, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 447);
            this.panel2.TabIndex = 10;
            // 
            // btnXemLop
            // 
            this.btnXemLop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemLop.ForeColor = System.Drawing.Color.Blue;
            this.btnXemLop.Location = new System.Drawing.Point(105, 105);
            this.btnXemLop.Name = "btnXemLop";
            this.btnXemLop.Size = new System.Drawing.Size(75, 23);
            this.btnXemLop.TabIndex = 24;
            this.btnXemLop.Text = "Xem";
            this.btnXemLop.UseVisualStyleBackColor = true;
            this.btnXemLop.Click += new System.EventHandler(this.btnXem);
            // 
            // DSLopCoSan
            // 
            this.DSLopCoSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSLopCoSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DSLopCoSan.Location = new System.Drawing.Point(3, 134);
            this.DSLopCoSan.Name = "DSLopCoSan";
            this.DSLopCoSan.Size = new System.Drawing.Size(292, 396);
            this.DSLopCoSan.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHS";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học sinh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên học sinh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // HSChuaCoLop
            // 
            this.HSChuaCoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HSChuaCoLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHS,
            this.HOTEN});
            this.HSChuaCoLop.Location = new System.Drawing.Point(0, 51);
            this.HSChuaCoLop.Name = "HSChuaCoLop";
            this.HSChuaCoLop.Size = new System.Drawing.Size(295, 396);
            this.HSChuaCoLop.TabIndex = 22;
            this.HSChuaCoLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HSChuaCoLop_CellClick);
            this.HSChuaCoLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HSChuaCoLop_CellContentClick);
            // 
            // MAHS
            // 
            this.MAHS.DataPropertyName = "MAHS";
            this.MAHS.HeaderText = "Mã học sinh";
            this.MAHS.Name = "MAHS";
            this.MAHS.Width = 90;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Tên học sinh";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh sách học sinh mới";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HSChuaCoLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 447);
            this.panel1.TabIndex = 9;
            // 
            // TaoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChuyenLop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TaoLop";
            this.Text = "Tạo danh sách lớp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSLopCoSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSChuaCoLop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChuyenLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView HSChuaCoLop;
        private System.Windows.Forms.DataGridView DSLopCoSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.Button btnXemLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

