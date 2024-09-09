using QuanLyBanDongHo.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDongHo
{
    public partial class frmXacNhan : Form
    {
        string TKNV;
        public frmXacNhan(string nv)
        {
            InitializeComponent();
            TKNV = nv;
        }

        private void frmXacNhan_Load(object sender, EventArgs e)
        {
            dgvXacNhan.EnableHeadersVisualStyles = false;
            dgvXacNhan.ColumnHeadersDefaultCellStyle.Font = new Font("century", 15, FontStyle.Bold);
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDon where XacNhan = '0'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvXacNhan.DataSource = dt;
            dgvXacNhan.AllowUserToAddRows = false;
        }
        private void ReLoad()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanDongHo;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDon where XacNhan = '0'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgvXacNhan.DataSource = dt;
            dgvXacNhan.AllowUserToAddRows = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QLBanDongHoContextDB context = new QLBanDongHoContextDB();
            try
            {
                HoaDon dbUpdate = context.HoaDons.FirstOrDefault(p => p.MaHoaDon == MaHD);
                if (dbUpdate != null)
                {
                    dbUpdate.XacNhan = true;
                    dbUpdate.NVXacNhan = TKNV;
                    context.SaveChanges();
                    MessageBox.Show("Đã Xác Nhận Đơn Hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLoad();
                }
                else
                    MessageBox.Show("Không Thể Xác Nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có Lỗi Xảy Ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            
        }
        int MaHD;
        private void dgvXacNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
            btnXacNhan.Enabled = true;
            if (dgvXacNhan.SelectedRows.Count > 0)
            {
                MaHD = int.Parse(dgvXacNhan.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu tc = new frmTrangChu(TKNV);
            tc.ShowDialog();
            this.Close();
        }
    }
}
