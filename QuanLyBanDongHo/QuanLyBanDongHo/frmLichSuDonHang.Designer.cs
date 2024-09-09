namespace QuanLyBanDongHo
{
    partial class frmLichSuDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLS = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDongHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLS
            // 
            this.dgvLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.TenDongHo,
            this.SoLuongMua,
            this.DonGia,
            this.ThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLS.Location = new System.Drawing.Point(0, 0);
            this.dgvLS.MultiSelect = false;
            this.dgvLS.Name = "dgvLS";
            this.dgvLS.ReadOnly = true;
            this.dgvLS.RowHeadersWidth = 51;
            this.dgvLS.RowTemplate.Height = 24;
            this.dgvLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLS.Size = new System.Drawing.Size(1161, 801);
            this.dgvLS.TabIndex = 0;
            this.dgvLS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLS_CellClick);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            this.MaHoaDon.Visible = false;
            // 
            // TenDongHo
            // 
            this.TenDongHo.DataPropertyName = "TenDongHo";
            this.TenDongHo.HeaderText = "Tên Đồng Hồ";
            this.TenDongHo.MinimumWidth = 6;
            this.TenDongHo.Name = "TenDongHo";
            this.TenDongHo.ReadOnly = true;
            // 
            // SoLuongMua
            // 
            this.SoLuongMua.DataPropertyName = "SoLuongMua";
            this.SoLuongMua.HeaderText = "Số Lượng Mua";
            this.SoLuongMua.MinimumWidth = 6;
            this.SoLuongMua.Name = "SoLuongMua";
            this.SoLuongMua.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(1153, 12);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(100, 22);
            this.txtTK.TabIndex = 1;
            this.txtTK.Visible = false;
            // 
            // btnQL
            // 
            this.btnQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQL.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQL.Location = new System.Drawing.Point(1014, 736);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(147, 65);
            this.btnQL.TabIndex = 2;
            this.btnQL.Text = "Quay Lại";
            this.btnQL.UseVisualStyleBackColor = false;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // frmLichSuDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 801);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.dgvLS);
            this.Name = "frmLichSuDonHang";
            this.Text = "Lịch Sử Đơn Hàng";
            this.Load += new System.EventHandler(this.frmLichSuDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLS;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDongHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnQL;
    }
}