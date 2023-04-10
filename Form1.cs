using System;
using System.Data;
using System.Data.SqlClient;

namespace WinformForIT9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
 using System;
using System.Data;
using System.Data.SqlClient;

namespace KetNoi_Hoc
{
    public partial class Form1 : Form
    {
        // tạo 2 biến cục bộ
        // chuỗi kết nối
        string strCon //= @"Data Source=LAPTOP-89GT2MJ0\\KTEAM;Initial Catalog=QLDIEMSV;Integrated Security=True";
        = @"Data Source=LAPTOP-89GT2MJ0\KTEAM;Initial Catalog=Hoc;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Open Success");
                }

                 

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            } 
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sqlCon = null;
            MessageBox.Show("Disconnect");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            SqlCommand cmd = new SqlCommand();

            // oneline
            cmd.CommandType = CommandType.Text;
            cmd.CommandText
                = @"SELECT * FROM dbo.THONGTIN WHERE MaMH = '" + maMH + "'";

            cmd.Connection = sqlCon;
            //cmd.ExecuteNonQuery(); 
            // thêm, sửa, xóa dữ liệu -> không trả về kết quả

            //đọc một giá trị
            //cmd.ExecuteScalar();
            //Select count () from ThongTin


            // đọc dữa liệu
            SqlDataReader sqlDataReader = cmd.ExecuteReader();


            if (sqlDataReader.Read())
            {
                string tenMon = sqlDataReader.GetString(1);
                int tc = sqlDataReader.GetInt32(2);

                txtTenMH.Text = tenMon;
                txtSoTin.Text = tc.ToString();
            }

            sqlDataReader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string maMH = txtMaMH.Text;
                string tenMh = txtTenMH.Text;
                string tc = txtTenMH.Text;
                //int tc = Int32.Parse(txtSoTin.Text);

                SqlCommand cmd = new SqlCommand();

                // oneline
                cmd.CommandType = CommandType.Text;
                cmd.CommandText
                = @"INSERT dbo.THONGTIN (MaMH, TenMH, SoTin) VALUES ('" + maMH + "', '" + tenMh + "', " + tc + ")";

                cmd.Connection = sqlCon;
                cmd.ExecuteNonQuery(); // thêm, sửa, xóa dữ liệu -> không trả về kết quả

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            // oneline
            cmd.CommandType = CommandType.Text;
            cmd.CommandText
            = @"SELECT COUNT(*) FROM dbo.THONGTIN";

            cmd.Connection = sqlCon;
            int sl = (int)cmd.ExecuteScalar();

            MessageBox.Show(sl.ToString());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            // oneline
            cmd.CommandType = CommandType.Text;
            cmd.CommandText
            = @"Select * FROM dbo.THONGTIN";

            cmd.Connection = sqlCon;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();


            // listview : view = detail
            // full row select: False
            while (sqlDataReader.Read())
            {
                string maMH = sqlDataReader.GetString(0);
                string tenMh = sqlDataReader.GetString(1);
                int tc = sqlDataReader.GetInt32(2);
                ListViewItem listViewItem= new ListViewItem(maMH);
                listViewItem.SubItems.Add(tenMh);
                listViewItem.SubItems.Add(tc.ToString());

                lsvItem.Items.Add(listViewItem);
            }

            sqlDataReader.Close();
        }
    }
}
 */