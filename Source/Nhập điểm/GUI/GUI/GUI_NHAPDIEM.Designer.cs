namespace GUI
{
    partial class GUI_NHAPDIEM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Luu = new System.Windows.Forms.Button();
            this.hocky2 = new System.Windows.Forms.RadioButton();
            this.hocky1 = new System.Windows.Forms.RadioButton();
            this.Lop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Khoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Thoat = new System.Windows.Forms.Button();
            this.dgvNhapDiem = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Luu);
            this.groupBox1.Controls.Add(this.hocky2);
            this.groupBox1.Controls.Add(this.hocky1);
            this.groupBox1.Controls.Add(this.Lop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Mon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Khoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NHẬP BẢNG ĐIỂM MÔN HỌC";
            // 
            // Luu
            // 
            this.Luu.BackColor = System.Drawing.Color.White;
            this.Luu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Luu.Location = new System.Drawing.Point(605, 108);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(116, 35);
            this.Luu.TabIndex = 19;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = false;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // hocky2
            // 
            this.hocky2.AutoSize = true;
            this.hocky2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hocky2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocky2.Location = new System.Drawing.Point(630, 66);
            this.hocky2.Name = "hocky2";
            this.hocky2.Size = new System.Drawing.Size(79, 20);
            this.hocky2.TabIndex = 10;
            this.hocky2.TabStop = true;
            this.hocky2.Text = "Học kỳ 2";
            this.hocky2.UseVisualStyleBackColor = true;
            this.hocky2.CheckedChanged += new System.EventHandler(this.hocky2_CheckedChanged);
            // 
            // hocky1
            // 
            this.hocky1.AutoSize = true;
            this.hocky1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hocky1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocky1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.hocky1.Location = new System.Drawing.Point(630, 39);
            this.hocky1.Name = "hocky1";
            this.hocky1.Size = new System.Drawing.Size(79, 20);
            this.hocky1.TabIndex = 9;
            this.hocky1.TabStop = true;
            this.hocky1.Text = "Học kỳ 1";
            this.hocky1.UseVisualStyleBackColor = true;
            this.hocky1.CheckedChanged += new System.EventHandler(this.hocky1_CheckedChanged);
            // 
            // Lop
            // 
            this.Lop.FormattingEnabled = true;
            this.Lop.Location = new System.Drawing.Point(204, 58);
            this.Lop.Name = "Lop";
            this.Lop.Size = new System.Drawing.Size(129, 27);
            this.Lop.TabIndex = 8;
            this.Lop.SelectedIndexChanged += new System.EventHandler(this.Lop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Môn";
            // 
            // Mon
            // 
            this.Mon.FormattingEnabled = true;
            this.Mon.Items.AddRange(new object[] {
            "Toán",
            "Lý",
            "Hóa",
            "Sinh",
            "Văn",
            "Sử",
            "Địa",
            "Giáo Dục Công Dân",
            "Công Nghệ",
            "Tin Học",
            "Ngoại Ngữ",
            "Giáo Dục Quốc Phòng",
            "Thể Dục"});
            this.Mon.Location = new System.Drawing.Point(405, 58);
            this.Mon.Name = "Mon";
            this.Mon.Size = new System.Drawing.Size(129, 27);
            this.Mon.TabIndex = 6;
            this.Mon.SelectedIndexChanged += new System.EventHandler(this.Mon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Khoi
            // 
            this.Khoi.FormattingEnabled = true;
            this.Khoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.Khoi.Location = new System.Drawing.Point(25, 58);
            this.Khoi.Name = "Khoi";
            this.Khoi.Size = new System.Drawing.Size(103, 27);
            this.Khoi.TabIndex = 2;
            this.Khoi.SelectedIndexChanged += new System.EventHandler(this.Khoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khối";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.White;
            this.Thoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Thoat.Location = new System.Drawing.Point(683, 521);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(89, 28);
            this.Thoat.TabIndex = 2;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // dgvNhapDiem
            // 
            this.dgvNhapDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapDiem.Location = new System.Drawing.Point(0, 154);
            this.dgvNhapDiem.Name = "dgvNhapDiem";
            this.dgvNhapDiem.Size = new System.Drawing.Size(787, 361);
            this.dgvNhapDiem.TabIndex = 3;
            // 
            // GUI_NHAPDIEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvNhapDiem);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_NHAPDIEM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Khoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Lop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Mon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton hocky2;
        private System.Windows.Forms.RadioButton hocky1;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView dgvNhapDiem;
    }
}

