namespace QLHS
{
    partial class frmTongKetChung
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXem = new System.Windows.Forms.Button();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblTongKetMon = new System.Windows.Forms.Label();
            this.dgvTongKet = new System.Windows.Forms.DataGridView();
            this.TENLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGDAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongKet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnXem);
            this.splitContainer1.Panel1.Controls.Add(this.lblNamHoc);
            this.splitContainer1.Panel1.Controls.Add(this.cboNamHoc);
            this.splitContainer1.Panel1.Controls.Add(this.lblTongKetMon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTongKet);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Location = new System.Drawing.Point(472, 68);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(82, 32);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNamHoc.Location = new System.Drawing.Point(224, 76);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(76, 16);
            this.lblNamHoc.TabIndex = 3;
            this.lblNamHoc.Text = "Năm Học:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(306, 75);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(121, 21);
            this.cboNamHoc.TabIndex = 1;
            // 
            // lblTongKetMon
            // 
            this.lblTongKetMon.AutoSize = true;
            this.lblTongKetMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongKetMon.ForeColor = System.Drawing.Color.Blue;
            this.lblTongKetMon.Location = new System.Drawing.Point(273, 9);
            this.lblTongKetMon.Name = "lblTongKetMon";
            this.lblTongKetMon.Size = new System.Drawing.Size(225, 31);
            this.lblTongKetMon.TabIndex = 0;
            this.lblTongKetMon.Text = "Tổng Kết Chung";
            // 
            // dgvTongKet
            // 
            this.dgvTongKet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongKet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENLOP,
            this.SISO,
            this.SOLUONGDAT,
            this.TYLE});
            this.dgvTongKet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTongKet.Location = new System.Drawing.Point(0, 0);
            this.dgvTongKet.Name = "dgvTongKet";
            this.dgvTongKet.ReadOnly = true;
            this.dgvTongKet.Size = new System.Drawing.Size(784, 398);
            this.dgvTongKet.TabIndex = 0;
            // 
            // TENLOP
            // 
            this.TENLOP.DataPropertyName = "TENLOP";
            this.TENLOP.HeaderText = "Lớp";
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.ReadOnly = true;
            // 
            // SISO
            // 
            this.SISO.DataPropertyName = "SISO";
            this.SISO.HeaderText = "Sĩ số";
            this.SISO.Name = "SISO";
            this.SISO.ReadOnly = true;
            // 
            // SOLUONGDAT
            // 
            this.SOLUONGDAT.DataPropertyName = "SOLUONGDAT";
            this.SOLUONGDAT.HeaderText = "Số lượng đạt";
            this.SOLUONGDAT.Name = "SOLUONGDAT";
            this.SOLUONGDAT.ReadOnly = true;
            // 
            // TYLE
            // 
            this.TYLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TYLE.DataPropertyName = "TYLE";
            this.TYLE.HeaderText = "Tỷ lệ";
            this.TYLE.Name = "TYLE";
            this.TYLE.ReadOnly = true;
            // 
            // frmTongKetChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLHS.Properties.Resources._33965076_870783176439258_4904336354013347840_n;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTongKetChung";
            this.Text = "Tổng Kết Chung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTongKetChung_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongKet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label lblTongKetMon;
        private System.Windows.Forms.DataGridView dgvTongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGDAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYLE;
    }
}