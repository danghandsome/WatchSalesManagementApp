namespace QuanLyBanDongHo
{
    partial class frmThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.MHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MHD,
            this.TenTK,
            this.MDH,
            this.SLM,
            this.TT,
            this.NgayMua,
            this.XN,
            this.NVXN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKe.Location = new System.Drawing.Point(1, 126);
            this.dgvThongKe.MultiSelect = false;
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1316, 427);
            this.dgvThongKe.TabIndex = 0;
            // 
            // MHD
            // 
            this.MHD.DataPropertyName = "MaHoaDon";
            this.MHD.HeaderText = "Mã Hóa Đơn";
            this.MHD.MinimumWidth = 6;
            this.MHD.Name = "MHD";
            this.MHD.ReadOnly = true;
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TenTK";
            this.TenTK.HeaderText = "Khách Hàng Mua";
            this.TenTK.MinimumWidth = 6;
            this.TenTK.Name = "TenTK";
            this.TenTK.ReadOnly = true;
            // 
            // MDH
            // 
            this.MDH.DataPropertyName = "MaDongHo";
            this.MDH.HeaderText = "Mã Đồng Hồ";
            this.MDH.MinimumWidth = 6;
            this.MDH.Name = "MDH";
            this.MDH.ReadOnly = true;
            // 
            // SLM
            // 
            this.SLM.DataPropertyName = "SoLuongMua";
            this.SLM.HeaderText = "Số Lượng Mua";
            this.SLM.MinimumWidth = 6;
            this.SLM.Name = "SLM";
            this.SLM.ReadOnly = true;
            // 
            // TT
            // 
            this.TT.DataPropertyName = "ThanhTien";
            this.TT.HeaderText = "Tổng Tiền";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // NgayMua
            // 
            this.NgayMua.DataPropertyName = "NgayMua";
            this.NgayMua.HeaderText = "Ngày Mua";
            this.NgayMua.MinimumWidth = 6;
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.ReadOnly = true;
            // 
            // XN
            // 
            this.XN.DataPropertyName = "XacNhan";
            this.XN.HeaderText = "Xác Nhận";
            this.XN.MinimumWidth = 6;
            this.XN.Name = "XN";
            this.XN.ReadOnly = true;
            this.XN.Visible = false;
            // 
            // NVXN
            // 
            this.NVXN.DataPropertyName = "NVXacNhan";
            this.NVXN.HeaderText = "Nhân Viên Thanh Toán";
            this.NVXN.MinimumWidth = 6;
            this.NVXN.Name = "NVXN";
            this.NVXN.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(902, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đã Thanh Toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1174, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hóa Đơn";
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Enabled = false;
            this.txtSoHoaDon.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHoaDon.Location = new System.Drawing.Point(1110, 564);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(49, 35);
            this.txtSoHoaDon.TabIndex = 2;
            this.txtSoHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(928, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doanh Thu";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThu.Location = new System.Drawing.Point(1110, 614);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(142, 35);
            this.txtDoanhThu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chọn Tháng/Năm";
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpThangNam.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(253, 56);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(162, 32);
            this.dtpThangNam.TabIndex = 5;
            this.dtpThangNam.ValueChanged += new System.EventHandler(this.dtpThangNam_ValueChanged);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTraCuu.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(901, 48);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(119, 53);
            this.btnTraCuu.TabIndex = 6;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTatCa.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.Location = new System.Drawing.Point(1042, 48);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(115, 53);
            this.btnTatCa.TabIndex = 6;
            this.btnTatCa.Text = "Tất Cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1187, 48);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 53);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDongHo.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1362, 661);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.txtSoHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongKe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn XN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVXN;
        private System.Windows.Forms.Button btnThoat;
    }
}