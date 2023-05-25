using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoaDon
{
    public partial class Form1 : Form
    {
        string chuoiKetnoi = @"Data Source=TUF\SQLEXPRESS;Initial Catalog=DonHang;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        public void load()
        {
            SqlConnection conn = new SqlConnection(chuoiKetnoi);

            try
            {
                conn.Open();
                string sql = "select * from DonHang";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridView1.DataSource = tb;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công", "Thông báo");
            load();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
