namespace GUI
{
    partial class frmThayDoiQuyDinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudTuoiMin = new System.Windows.Forms.NumericUpDown();
            this.nudTuoiMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudLop11 = new System.Windows.Forms.NumericUpDown();
            this.nudLop12 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLop10 = new System.Windows.Forms.NumericUpDown();
            this.nudSiSo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudDiemDat = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDiemMin = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudDiemMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoiMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoiMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemMax)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::QLHS.Properties.Resources._33965076_870783176439258_4904336354013347840_n;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F);
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 481);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nudTuoiMin);
            this.groupBox1.Controls.Add(this.nudTuoiMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(37, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 93);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qui định 1: Độ tuổi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // nudTuoiMin
            // 
            this.nudTuoiMin.Font = new System.Drawing.Font("Arial", 12F);
            this.nudTuoiMin.Location = new System.Drawing.Point(203, 60);
            this.nudTuoiMin.Name = "nudTuoiMin";
            this.nudTuoiMin.Size = new System.Drawing.Size(46, 26);
            this.nudTuoiMin.TabIndex = 4;
            this.nudTuoiMin.ValueChanged += new System.EventHandler(this.nudTuoiMin_ValueChanged);
            // 
            // nudTuoiMax
            // 
            this.nudTuoiMax.Font = new System.Drawing.Font("Arial", 12F);
            this.nudTuoiMax.Location = new System.Drawing.Point(203, 23);
            this.nudTuoiMax.Name = "nudTuoiMax";
            this.nudTuoiMax.Size = new System.Drawing.Size(46, 26);
            this.nudTuoiMax.TabIndex = 3;
            this.nudTuoiMax.ValueChanged += new System.EventHandler(this.nudTuoiMax_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tuổi tối thiểu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuổi tối đa";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nudLop11);
            this.groupBox2.Controls.Add(this.nudLop12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudLop10);
            this.groupBox2.Controls.Add(this.nudSiSo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(424, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 223);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quy định 2: Sĩ số";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // nudLop11
            // 
            this.nudLop11.Font = new System.Drawing.Font("Arial", 12F);
            this.nudLop11.Location = new System.Drawing.Point(203, 108);
            this.nudLop11.Name = "nudLop11";
            this.nudLop11.Size = new System.Drawing.Size(46, 26);
            this.nudLop11.TabIndex = 8;
            this.nudLop11.ValueChanged += new System.EventHandler(this.nudLop11_ValueChanged);
            // 
            // nudLop12
            // 
            this.nudLop12.Font = new System.Drawing.Font("Arial", 12F);
            this.nudLop12.Location = new System.Drawing.Point(203, 160);
            this.nudLop12.Name = "nudLop12";
            this.nudLop12.Size = new System.Drawing.Size(46, 26);
            this.nudLop12.TabIndex = 7;
            this.nudLop12.ValueChanged += new System.EventHandler(this.nudLop12_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số lượng lớp khối 12";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng lớp khối 11";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nudLop10
            // 
            this.nudLop10.Font = new System.Drawing.Font("Arial", 12F);
            this.nudLop10.Location = new System.Drawing.Point(203, 65);
            this.nudLop10.Name = "nudLop10";
            this.nudLop10.Size = new System.Drawing.Size(46, 26);
            this.nudLop10.TabIndex = 4;
            this.nudLop10.ValueChanged += new System.EventHandler(this.nudLop10_ValueChanged);
            // 
            // nudSiSo
            // 
            this.nudSiSo.Font = new System.Drawing.Font("Arial", 12F);
            this.nudSiSo.Location = new System.Drawing.Point(203, 23);
            this.nudSiSo.Name = "nudSiSo";
            this.nudSiSo.Size = new System.Drawing.Size(46, 26);
            this.nudSiSo.TabIndex = 3;
            this.nudSiSo.ValueChanged += new System.EventHandler(this.nudSiSo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng lớp khối 10";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sĩ số tối đa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(262, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(254, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "Thay đổi quy định";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(567, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 47);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.nudDiemDat);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudDiemMin);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.nudDiemMax);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(37, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 152);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Qui định : Điểm số";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // nudDiemDat
            // 
            this.nudDiemDat.Font = new System.Drawing.Font("Arial", 12F);
            this.nudDiemDat.Location = new System.Drawing.Point(180, 103);
            this.nudDiemDat.Name = "nudDiemDat";
            this.nudDiemDat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudDiemDat.Size = new System.Drawing.Size(46, 26);
            this.nudDiemDat.TabIndex = 7;
            this.nudDiemDat.ValueChanged += new System.EventHandler(this.nudDiemDat_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(22, 109);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Điểm đạt";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // nudDiemMin
            // 
            this.nudDiemMin.Font = new System.Drawing.Font("Arial", 12F);
            this.nudDiemMin.Location = new System.Drawing.Point(180, 66);
            this.nudDiemMin.Name = "nudDiemMin";
            this.nudDiemMin.Size = new System.Drawing.Size(46, 26);
            this.nudDiemMin.TabIndex = 5;
            this.nudDiemMin.ValueChanged += new System.EventHandler(this.nudDiemMin_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(22, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Điểm tối thiểu";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nudDiemMax
            // 
            this.nudDiemMax.Font = new System.Drawing.Font("Arial", 12F);
            this.nudDiemMax.Location = new System.Drawing.Point(180, 29);
            this.nudDiemMax.Name = "nudDiemMax";
            this.nudDiemMax.Size = new System.Drawing.Size(46, 26);
            this.nudDiemMax.TabIndex = 3;
            this.nudDiemMax.ValueChanged += new System.EventHandler(this.nudDiemMax_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(22, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điểm tối đa";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 481);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmThayDoiQuyDinh";
            this.Text = "Thay Đổi Quy Định";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThayDoiQuyDinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoiMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTuoiMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLop10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudTuoiMin;
        private System.Windows.Forms.NumericUpDown nudTuoiMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudLop11;
        private System.Windows.Forms.NumericUpDown nudLop12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudLop10;
        private System.Windows.Forms.NumericUpDown nudSiSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudDiemDat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudDiemMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudDiemMax;
        private System.Windows.Forms.Label label7;
    }
}