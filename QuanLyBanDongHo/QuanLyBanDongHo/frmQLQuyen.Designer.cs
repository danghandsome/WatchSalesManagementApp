namespace QuanLyBanDongHo
{
    partial class frmQLQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.AdminTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.NhanVienTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.KhachHangTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHangEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.btnXN = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(16, 39);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(275, 35);
            this.txtTK.TabIndex = 0;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminTK,
            this.AdminEmail});
            this.dgvAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmin.Location = new System.Drawing.Point(13, 135);
            this.dgvAdmin.MultiSelect = false;
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersVisible = false;
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(578, 189);
            this.dgvAdmin.TabIndex = 1;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick);
            // 
            // AdminTK
            // 
            this.AdminTK.DataPropertyName = "TenTK";
            this.AdminTK.HeaderText = "Tài Khoản";
            this.AdminTK.MinimumWidth = 6;
            this.AdminTK.Name = "AdminTK";
            this.AdminTK.ReadOnly = true;
            // 
            // AdminEmail
            // 
            this.AdminEmail.DataPropertyName = "Email";
            this.AdminEmail.HeaderText = "Email";
            this.AdminEmail.MinimumWidth = 6;
            this.AdminEmail.Name = "AdminEmail";
            this.AdminEmail.ReadOnly = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NhanVienTK,
            this.NhanVienEmail});
            this.dgvNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.Location = new System.Drawing.Point(16, 423);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(575, 205);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // NhanVienTK
            // 
            this.NhanVienTK.DataPropertyName = "TenTK";
            this.NhanVienTK.HeaderText = "Tài Khoản";
            this.NhanVienTK.MinimumWidth = 6;
            this.NhanVienTK.Name = "NhanVienTK";
            this.NhanVienTK.ReadOnly = true;
            // 
            // NhanVienEmail
            // 
            this.NhanVienEmail.DataPropertyName = "Email";
            this.NhanVienEmail.HeaderText = "Email";
            this.NhanVienEmail.MinimumWidth = 6;
            this.NhanVienEmail.Name = "NhanVienEmail";
            this.NhanVienEmail.ReadOnly = true;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachHangTK,
            this.KhachHangEmail});
            this.dgvKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.Location = new System.Drawing.Point(616, 135);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(637, 493);
            this.dgvKhachHang.TabIndex = 1;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // KhachHangTK
            // 
            this.KhachHangTK.DataPropertyName = "TenTK";
            this.KhachHangTK.HeaderText = "Tài Khoản";
            this.KhachHangTK.MinimumWidth = 6;
            this.KhachHangTK.Name = "KhachHangTK";
            this.KhachHangTK.ReadOnly = true;
            // 
            // KhachHangEmail
            // 
            this.KhachHangEmail.DataPropertyName = "Email";
            this.KhachHangEmail.HeaderText = "Email";
            this.KhachHangEmail.MinimumWidth = 6;
            this.KhachHangEmail.Name = "KhachHangEmail";
            this.KhachHangEmail.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin";
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Items.AddRange(new object[] {
            "Admin",
            "Nhân Viên",
            "Khách Hàng"});
            this.cbbQuyen.Location = new System.Drawing.Point(352, 38);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(239, 36);
            this.cbbQuyen.TabIndex = 3;
            // 
            // btnXN
            // 
            this.btnXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXN.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXN.Location = new System.Drawing.Point(867, 30);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(159, 52);
            this.btnXN.TabIndex = 4;
            this.btnXN.Text = "Xác Nhận";
            this.btnXN.UseVisualStyleBackColor = false;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuy.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1099, 30);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(154, 52);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Quay Lại";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmQLQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanDongHo.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1265, 663);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.cbbQuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.txtTK);
            this.Name = "frmQLQuyen";
            this.Text = "Phân Quyền";
            this.Load += new System.EventHandler(this.frmQLQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangEmail;
    }
}