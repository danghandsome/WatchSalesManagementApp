using QuanLyBanDongHo.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDongHo
{
    public partial class frmQLQuyen : Form
    {
        string TK;
        public frmQLQuyen(string tk)
        {
            InitializeComponent();
            TK = tk;
        }
        private void btnXN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TenTK from Taikhoan where TenTK = '" + txtTK.Text + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                QLBanDongHoContextDB context = new QLBanDongHoContextDB();
                QuanLyBanDongHo.Modules.TaiKhoan dbUpdate = context.TaiKhoans.FirstOrDefault(p => p.TenTK == txtTK.Text);
                if (dbUpdate != null)
                {
                    dbUpdate.LoaiTK = cbbValue();
                    context.SaveChanges();
                    MessageBox.Show("Phân Quyền Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminLoad();
                    NhanVienLoad();
                    KhachHangLoad();
                }
            }
            else
                MessageBox.Show("Không Tìm Thấy Tài Khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private int cbbValue()
        {
            if (cbbQuyen.Text == "Admin")
                return 1;
            else if (cbbQuyen.Text == "Nhân Viên")
                return 2;
            else if(cbbQuyen.Text == "Khách Hàng")
                return 3;
            else
                return -1;
        } 
        private void frmQLQuyen_Load(object sender, EventArgs e)
        {
            dgvAdmin.EnableHeadersVisualStyles = false;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvAdmin.ColumnHeadersDefaultCellStyle.Font = new Font("century", 15, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("century", 15, FontStyle.Bold);
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("century", 15, FontStyle.Bold);
            AdminLoad();
            NhanVienLoad();
            KhachHangLoad();
            cbbQuyen.Text = "Nhân Viên";
        }

        private void AdminLoad()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TenTK, Email from TaiKhoan where LoaiTK = 1", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvAdmin.DataSource = dt;
            dgvAdmin.AllowUserToAddRows = false;
        }
        private void NhanVienLoad()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TenTK, Email from TaiKhoan where LoaiTK = 2", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.AllowUserToAddRows = false;
        }
        private void KhachHangLoad()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TenTK, Email from TaiKhoan where LoaiTK = 3", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvKhachHang.DataSource = dt;
            dgvKhachHang.AllowUserToAddRows = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu tc = new frmTrangChu(TK);
            tc.ShowDialog();
            this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                txtTK.Text = dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                txtTK.Text = dgvAdmin.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                txtTK.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
