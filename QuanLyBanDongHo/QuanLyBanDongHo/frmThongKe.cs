using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDongHo
{
    public partial class frmThongKe : Form
    {
        public frmThongKe(string tk)
        {
            InitializeComponent();
            TK = tk;
        }
        string TK;
        string Month;
        string Year;
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dgvThongKe.EnableHeadersVisualStyles = false;
            dgvThongKe.ColumnHeadersDefaultCellStyle.Font = new Font("century", 15, FontStyle.Bold);
            dtpThangNam.CustomFormat = "MM/yyyy";
            Month = DateTime.Now.ToString("MM");
            Year = DateTime.Now.ToString("yyyy");
            ThongTin();
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDon where XacNhan = 1", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvThongKe.DataSource = dt;
            dgvThongKe.AllowUserToAddRows = false;
        }
        private void ThongTin()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(MaHoaDon), sum(ThanhTien) from HoaDon where XacNhan = 1", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            txtSoHoaDon.Text = dt.Rows[0][0].ToString();
            txtDoanhThu.Text = dt.Rows[0][1].ToString();
        }
        private void ThongTinThem()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(MaHoaDon), sum(ThanhTien) from HoaDon where XacNhan = 1 and month(NgayMua)= " + Month + " and year(NgayMua) =" + Year, conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                txtSoHoaDon.Text = dt.Rows[0][0].ToString();
                txtDoanhThu.Text = dt.Rows[0][1].ToString();
            }
            catch
            {
                MessageBox.Show("Vui Lòng Chọn Ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dtpThangNam_ValueChanged(object sender, EventArgs e)
        {
            Month = dtpThangNam.Value.ToString("MM");
            Year = dtpThangNam.Value.ToString("yyyy");
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDon where XacNhan = 1 and month(NgayMua)= " + Month + " and year(NgayMua) = " + Year, conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvThongKe.DataSource = dt;
            dgvThongKe.AllowUserToAddRows = false;
            ThongTinThem();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDon where XacNhan = 1", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvThongKe.DataSource = dt;
            dgvThongKe.AllowUserToAddRows = false;
            ThongTin();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu tc = new frmTrangChu(TK);
            tc.ShowDialog();
            this.Close();
        }
    }
}
