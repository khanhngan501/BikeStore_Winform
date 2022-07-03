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

namespace _19110038_HoangNhutKhanhNgan
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        string connstr = "Data Source=DESKTOP-9SB50R4;Initial Catalog=Sales;Integrated Security=True";
        //Đối tượng kết nối
        SqlConnection conn = null;
        //Đối tượng đưa dữ liệu vào Data Table SqlStore
        SqlDataAdapter adUser = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtUser = null;
        int tmp = 0;
        void LoadData()
        {
            ResetAllTextBox();
            //Tạo kết nối
            try
            {
                conn = new SqlConnection(connstr);
                adUser = new SqlDataAdapter("SELECT * FROM users", conn);
                dtUser = new DataTable();
                adUser.Fill(dtUser);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng User", "Lỗi dữ liệu!");
            }
        }
        void ResetAllTextBox()
        {
            txtID.ResetText();
            txtPass.ResetText();
        }

        void Checktmp()
        {
            if (tmp >= 3)
            {
                MessageBox.Show("Đăng nhập sai quá 3 lần!!! Kết thúc chương trình!!!", "Đăng nhập thất bại.");
                this.Close();
            }
        }
        void CheckPassExit()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                // Thực hiện lệnh 
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Password FROM users WHERE ID = '" + txtID.Text.Trim() + "'";
                cmd.ExecuteNonQuery();
                string pass = "\0";
                pass = cmd.ExecuteScalar().ToString();
                string PassIn = txtPass.Text.ToString();
                if (pass != PassIn)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai!!!", "Warning!!!");
                    ResetAllTextBox();
                    tmp++;
                    txtID.Focus();
                }
                Checktmp();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }
        }
        void CheckIDExit()
        {
            // Mở kết nối 
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                // Thực hiện lệnh 
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Count(*) FROM users WHERE ID = '" + txtID.Text.Trim() + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount == 0)
                {
                    MessageBox.Show("ID (" + txtID.Text.Trim() + ") không tồn tại. Vui lòng nhập lại!");
                    tmp++;
                    ResetAllTextBox();
                    txtID.Focus();
                }
                Checktmp();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult CheckExit = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cancel confirm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckExit == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btSignIn_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" && txtID.Text == "")
            {
                MessageBox.Show("Chưa nhập ID và mật khẩu!!!", "Warning!!!");
                txtID.Focus();
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!!!", "Warning!!!");
                txtPass.Focus();
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!!!");
                MenuForm menu = new MenuForm();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm singup = new SignUpForm();
            this.Hide();
            singup.ShowDialog();
            this.Show();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text != "") CheckIDExit();
                
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text != "") CheckPassExit();
        }

        private void User_Load_1(object sender, EventArgs e)
        {
            txtID.Focus();
            LoadData();
        }
        private void getID(string ID)
        {
            ID = txtID.Text;
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            txtPass.Focus();
        }
    }
}
