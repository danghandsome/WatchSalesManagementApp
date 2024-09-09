namespace QuanLyBanDongHo
{
    partial class frmXacNhan
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
            this.dgvXacNhan = new System.Windows.Forms.DataGridView();
            this.MHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XacNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVXN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXacNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXacNhan
            // 
            this.dgvXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvXacNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXacNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXacNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MHD,
            this.TenTK,
            this.MDH,
            this.SLM,
            this.TT,
            this.Ngay,
            this.XacNhan,
            this.NVXN});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXacNhan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXacNhan.Location = new System.Drawing.Point(0, 2);
            this.dgvXacNhan.MultiSelect = false;
            this.dgvXacNhan.Name = "dgvXacNhan";
            this.dgvXacNhan.ReadOnly = true;
            this.dgvXacNhan.RowHeadersWidth = 51;
            this.dgvXacNhan.RowTemplate.Height = 24;
            this.dgvXacNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXacNhan.Size = new System.Drawing.Size(1085, 535);
            this.dgvXacNhan.TabIndex = 0;
            this.dgvXacNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXacNhan_CellClick);
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
            this.TenTK.HeaderText = "Khách Hàng";
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
            this.TT.HeaderText = "Thành Tiền";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "NgayMua";
            this.Ngay.HeaderText = "Ngày Mua";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // XacNhan
            // 
            this.XacNhan.DataPropertyName = "XacNhan";
            this.XacNhan.HeaderText = "Xác Nhận";
            this.XacNhan.MinimumWidth = 6;
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.ReadOnly = true;
            this.XacNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XacNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.XacNhan.Visible = false;
            // 
            // NVXN
            // 
            this.NVXN.DataPropertyName = "NVXacNhan";
            this.NVXN.HeaderText = "Nhân Viên Xác Nhận";
            this.NVXN.MinimumWidth = 6;
            this.NVXN.Name = "NVXN";
            this.NVXN.ReadOnly = true;
            this.NVXN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NVXN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NVXN.Visible = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(733, 566);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(152, 69);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(920, 566);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 69);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmXacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDongHo.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1089, 657);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dgvXacNhan);
            this.Name = "frmXacNhan";
            this.Text = "Xác Nhận Đơn Hàng";
            this.Load += new System.EventHandler(this.frmXacNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXacNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXacNhan;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn XacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVXN;
        private System.Windows.Forms.Button btnThoat;
    }
}