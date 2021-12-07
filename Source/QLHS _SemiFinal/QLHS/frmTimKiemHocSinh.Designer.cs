namespace QLHS
{
    partial class frmTimKiemHocSinh
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
            this.gbxTimKiemHocSinh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemHoSo = new System.Windows.Forms.Button();
            this.dtpTimKiemHocSinh = new System.Windows.Forms.DateTimePicker();
            this.cboTimKiemHocSinh = new System.Windows.Forms.ComboBox();
            this.btnTimKiemHocSinh = new System.Windows.Forms.Button();
            this.txtTimKiemHocSinh = new System.Windows.Forms.TextBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.MAHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGIAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DANTOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENCHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGHENGHIEPCHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGHENGHIEPME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxTimKiemHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTimKiemHocSinh
            // 
            this.gbxTimKiemHocSinh.BackgroundImage = global::QLHS.Properties.Resources._33965076_870783176439258_4904336354013347840_n;
            this.gbxTimKiemHocSinh.Controls.Add(this.label1);
            this.gbxTimKiemHocSinh.Controls.Add(this.btnXemHoSo);
            this.gbxTimKiemHocSinh.Controls.Add(this.dtpTimKiemHocSinh);
            this.gbxTimKiemHocSinh.Controls.Add(this.cboTimKiemHocSinh);
            this.gbxTimKiemHocSinh.Controls.Add(this.btnTimKiemHocSinh);
            this.gbxTimKiemHocSinh.Controls.Add(this.txtTimKiemHocSinh);
            this.gbxTimKiemHocSinh.Controls.Add(this.lblThongBao);
            this.gbxTimKiemHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxTimKiemHocSinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbxTimKiemHocSinh.ForeColor = System.Drawing.Color.Blue;
            this.gbxTimKiemHocSinh.Location = new System.Drawing.Point(0, 0);
            this.gbxTimKiemHocSinh.Name = "gbxTimKiemHocSinh";
            this.gbxTimKiemHocSinh.Size = new System.Drawing.Size(784, 257);
            this.gbxTimKiemHocSinh.TabIndex = 0;
            this.gbxTimKiemHocSinh.TabStop = false;
            this.gbxTimKiemHocSinh.Text = "Tra Cứu Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm Theo Hồ Sơ";
            // 
            // btnXemHoSo
            // 
            this.btnXemHoSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXemHoSo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXemHoSo.Location = new System.Drawing.Point(513, 94);
            this.btnXemHoSo.Name = "btnXemHoSo";
            this.btnXemHoSo.Size = new System.Drawing.Size(184, 37);
            this.btnXemHoSo.TabIndex = 7;
            this.btnXemHoSo.Text = "Xem Toàn Bộ Hồ Sơ";
            this.btnXemHoSo.UseVisualStyleBackColor = false;
            this.btnXemHoSo.Click += new System.EventHandler(this.btnXemHoSo_Click);
            // 
            // dtpTimKiemHocSinh
            // 
            this.dtpTimKiemHocSinh.Enabled = false;
            this.dtpTimKiemHocSinh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpTimKiemHocSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimKiemHocSinh.Location = new System.Drawing.Point(513, 57);
            this.dtpTimKiemHocSinh.Name = "dtpTimKiemHocSinh";
            this.dtpTimKiemHocSinh.Size = new System.Drawing.Size(128, 23);
            this.dtpTimKiemHocSinh.TabIndex = 5;
            // 
            // cboTimKiemHocSinh
            // 
            this.cboTimKiemHocSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemHocSinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTimKiemHocSinh.FormattingEnabled = true;
            this.cboTimKiemHocSinh.Items.AddRange(new object[] {
            "Mã Học Sinh",
            "Họ Tên",
            "Địa Chỉ",
            "Ngày Sinh",
            "Tháng Sinh",
            "Năm Sinh",
            "Ngày Tháng Năm Sinh",
            "Giới Tính",
            "Tôn Giáo",
            "Dân Tộc",
            "Họ Tên Cha",
            "Nghề Nghiệp Cha",
            "Họ Tên Mẹ",
            "Nghề Nghiệp Mẹ"});
            this.cboTimKiemHocSinh.Location = new System.Drawing.Point(159, 55);
            this.cboTimKiemHocSinh.Name = "cboTimKiemHocSinh";
            this.cboTimKiemHocSinh.Size = new System.Drawing.Size(207, 24);
            this.cboTimKiemHocSinh.TabIndex = 4;
            this.cboTimKiemHocSinh.SelectedIndexChanged += new System.EventHandler(this.cboTimKiemHocSinh_SelectedIndexChanged);
            // 
            // btnTimKiemHocSinh
            // 
            this.btnTimKiemHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTimKiemHocSinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiemHocSinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiemHocSinh.Location = new System.Drawing.Point(383, 94);
            this.btnTimKiemHocSinh.Name = "btnTimKiemHocSinh";
            this.btnTimKiemHocSinh.Size = new System.Drawing.Size(109, 37);
            this.btnTimKiemHocSinh.TabIndex = 3;
            this.btnTimKiemHocSinh.Text = "Tìm";
            this.btnTimKiemHocSinh.UseVisualStyleBackColor = false;
            this.btnTimKiemHocSinh.Click += new System.EventHandler(this.btnTimKiemHocSinh_Click);
            // 
            // txtTimKiemHocSinh
            // 
            this.txtTimKiemHocSinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemHocSinh.Location = new System.Drawing.Point(383, 57);
            this.txtTimKiemHocSinh.Name = "txtTimKiemHocSinh";
            this.txtTimKiemHocSinh.Size = new System.Drawing.Size(124, 22);
            this.txtTimKiemHocSinh.TabIndex = 2;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(12, 215);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(54, 19);
            this.lblThongBao.TabIndex = 1;
            this.lblThongBao.Text = "label1";
            this.lblThongBao.Visible = false;
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AllowUserToAddRows = false;
            this.dgvTimKiem.AllowUserToDeleteRows = false;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHS,
            this.HOTEN,
            this.DIACHI,
            this.NGAYSINH,
            this.GIOITINH,
            this.TONGIAO,
            this.DANTOC,
            this.HOTENCHA,
            this.NGHENGHIEPCHA,
            this.HOTENME,
            this.NGHENGHIEPME});
            this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimKiem.Location = new System.Drawing.Point(0, 257);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.ReadOnly = true;
            this.dgvTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKiem.Size = new System.Drawing.Size(784, 304);
            this.dgvTimKiem.TabIndex = 17;
            this.dgvTimKiem.TabStop = false;
            // 
            // MAHS
            // 
            this.MAHS.DataPropertyName = "MAHS";
            this.MAHS.HeaderText = "Mã Học Sinh";
            this.MAHS.Name = "MAHS";
            this.MAHS.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Và Tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            this.HOTEN.Width = 150;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 150;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // TONGIAO
            // 
            this.TONGIAO.DataPropertyName = "TONGIAO";
            this.TONGIAO.HeaderText = "Tôn Giáo";
            this.TONGIAO.Name = "TONGIAO";
            this.TONGIAO.ReadOnly = true;
            // 
            // DANTOC
            // 
            this.DANTOC.DataPropertyName = "DANTOC";
            this.DANTOC.HeaderText = "Dân Tộc";
            this.DANTOC.Name = "DANTOC";
            this.DANTOC.ReadOnly = true;
            // 
            // HOTENCHA
            // 
            this.HOTENCHA.DataPropertyName = "HOTENCHA";
            this.HOTENCHA.HeaderText = "Họ Tên Cha";
            this.HOTENCHA.Name = "HOTENCHA";
            this.HOTENCHA.ReadOnly = true;
            this.HOTENCHA.Width = 150;
            // 
            // NGHENGHIEPCHA
            // 
            this.NGHENGHIEPCHA.DataPropertyName = "NGHENGHIEPCHA";
            this.NGHENGHIEPCHA.HeaderText = "Nghề Nghiệp Cha";
            this.NGHENGHIEPCHA.Name = "NGHENGHIEPCHA";
            this.NGHENGHIEPCHA.ReadOnly = true;
            // 
            // HOTENME
            // 
            this.HOTENME.DataPropertyName = "HOTENME";
            this.HOTENME.HeaderText = "Họ Tên Mẹ";
            this.HOTENME.Name = "HOTENME";
            this.HOTENME.ReadOnly = true;
            this.HOTENME.Width = 150;
            // 
            // NGHENGHIEPME
            // 
            this.NGHENGHIEPME.DataPropertyName = "NGHENGHIEPME";
            this.NGHENGHIEPME.HeaderText = "Nghề Nghiệp Mẹ";
            this.NGHENGHIEPME.Name = "NGHENGHIEPME";
            this.NGHENGHIEPME.ReadOnly = true;
            // 
            // frmTimKiemHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.gbxTimKiemHocSinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTimKiemHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Học Sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiemHocSinh_Load);
            this.gbxTimKiemHocSinh.ResumeLayout(false);
            this.gbxTimKiemHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTimKiemHocSinh;
        private System.Windows.Forms.Button btnTimKiemHocSinh;
        private System.Windows.Forms.TextBox txtTimKiemHocSinh;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.ComboBox cboTimKiemHocSinh;
        private System.Windows.Forms.DateTimePicker dtpTimKiemHocSinh;
        private System.Windows.Forms.Button btnXemHoSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGIAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DANTOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENCHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGHENGHIEPCHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGHENGHIEPME;
    }
}