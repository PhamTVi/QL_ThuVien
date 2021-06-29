namespace GUI
{
    partial class FormXemThongTin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLMuonS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSachTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSachTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NgayTraS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btdangky = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(271, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 34);
            this.label2.TabIndex = 51;
            this.label2.Text = "Lịch sử mượn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tên sinh viên:";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // SLMuonS
            // 
            this.SLMuonS.DataPropertyName = "SoLuongMuon";
            this.SLMuonS.HeaderText = "Số lượng mượn";
            this.SLMuonS.Name = "SLMuonS";
            this.SLMuonS.ReadOnly = true;
            this.SLMuonS.Width = 60;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Width = 185;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPM";
            this.MaPM.HeaderText = "Mã phiếu mượn";
            this.MaPM.Name = "MaPM";
            this.MaPM.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1072, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 53;
            this.label3.Text = "Lịch sử trả:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPM,
            this.MaSach,
            this.TenSach,
            this.SLMuonS,
            this.NgayMuon});
            this.dataGridView1.Location = new System.Drawing.Point(36, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(789, 274);
            this.dataGridView1.TabIndex = 52;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // SLTra
            // 
            this.SLTra.DataPropertyName = "SoLuongTra";
            this.SLTra.HeaderText = "Số lượng trả";
            this.SLTra.Name = "SLTra";
            this.SLTra.ReadOnly = true;
            this.SLTra.Width = 60;
            // 
            // TenSachTra
            // 
            this.TenSachTra.DataPropertyName = "TenSach";
            this.TenSachTra.HeaderText = "Tên sách";
            this.TenSachTra.Name = "TenSachTra";
            this.TenSachTra.ReadOnly = true;
            this.TenSachTra.Width = 160;
            // 
            // MaSachTra
            // 
            this.MaSachTra.DataPropertyName = "MaSach";
            this.MaSachTra.HeaderText = "Mã sách";
            this.MaSachTra.Name = "MaSachTra";
            this.MaSachTra.ReadOnly = true;
            // 
            // MaPMuon
            // 
            this.MaPMuon.DataPropertyName = "MaPM";
            this.MaPMuon.HeaderText = "Mã phiếu mượn";
            this.MaPMuon.Name = "MaPMuon";
            this.MaPMuon.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(410, 490);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 34);
            this.label4.TabIndex = 55;
            this.label4.Text = "Danh sách đang mượn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPMuon,
            this.MaSachTra,
            this.TenSachTra,
            this.SLTra,
            this.NgayTra});
            this.dataGridView2.Location = new System.Drawing.Point(833, 199);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(755, 274);
            this.dataGridView2.TabIndex = 54;
            // 
            // NgayTraS
            // 
            this.NgayTraS.DataPropertyName = "NgayTra";
            this.NgayTraS.HeaderText = "Ngày trả";
            this.NgayTraS.Name = "NgayTraS";
            this.NgayTraS.ReadOnly = true;
            // 
            // SLMuon
            // 
            this.SLMuon.DataPropertyName = "SoLuongMuon";
            this.SLMuon.HeaderText = "Số lượng mượn";
            this.SLMuon.Name = "SLMuon";
            this.SLMuon.ReadOnly = true;
            // 
            // TenS
            // 
            this.TenS.DataPropertyName = "TenSach";
            this.TenS.HeaderText = "Tên sách";
            this.TenS.Name = "TenS";
            this.TenS.ReadOnly = true;
            this.TenS.Width = 175;
            // 
            // MaS
            // 
            this.MaS.DataPropertyName = "MaSach";
            this.MaS.HeaderText = "Mã sách";
            this.MaS.Name = "MaS";
            this.MaS.ReadOnly = true;
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPM";
            this.MaPhieuMuon.HeaderText = "Mã phiếu mượn";
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.ReadOnly = true;
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_TenSV.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_TenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TenSV.Location = new System.Drawing.Point(641, 88);
            this.txt_TenSV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(297, 24);
            this.txt_TenSV.TabIndex = 58;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaSV.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaSV.Location = new System.Drawing.Point(641, 34);
            this.txt_MaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(297, 24);
            this.txt_MaSV.TabIndex = 57;
            this.txt_MaSV.TextChanged += new System.EventHandler(this.txt_MaSV_TextChanged);
            this.txt_MaSV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MaSV_KeyUp);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.MaS,
            this.TenS,
            this.SLMuon,
            this.NgayTraS});
            this.dataGridView3.Location = new System.Drawing.Point(477, 548);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(827, 135);
            this.dataGridView3.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "Mã sinh viên:";
            // 
            // btdangky
            // 
            this.btdangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdangky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdangky.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangky.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btdangky.Image = global::GUI.Properties.Resources.Zerode_Plump_Search;
            this.btdangky.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btdangky.Location = new System.Drawing.Point(971, 35);
            this.btdangky.Margin = new System.Windows.Forms.Padding(4);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(119, 79);
            this.btdangky.TabIndex = 59;
            this.btdangky.Text = "Xem thông tin";
            this.btdangky.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btdangky.UseVisualStyleBackColor = false;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // FormXemThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 774);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_TenSV);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label7);
            this.Name = "FormXemThongTin";
            this.Text = "XEM THÔNG TIN MƯỢN";
            this.Load += new System.EventHandler(this.FormXemThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLMuonS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSachTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSachTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
    }
}