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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
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

        void LoadData()
        {
            ResetAllTextBox();
            //SetBtEdit_Off();
            //Không kích hoạt các control Save, Cancel, Panel chứa các text

            //Tạo kết nối
            try
            {
                conn = new SqlConnection(connstr);
                adUser = new SqlDataAdapter("SELECT * FROM users", conn);
                dtUser = new DataTable();
                adUser.Fill(dtUser);
                //dtGridView.DataSource = dtCustomer;
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
            txtConfirmPass.ResetText();
        }
        void CheckUserIDExit()
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
                if (nCount > 0)
                {
                    MessageBox.Show("ID (" + txtID.Text.Trim() + ") đã có. Nhập  lại!");
                    txtID.ResetText();
                    txtID.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }
        }
        void CheckUserPasswordExit()
        {
            if (txtConfirmPass.Text != txtPass.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!!! Vui lòng nhập lại!!!", "Warning!!!");
                txtPass.ResetText();
                txtConfirmPass.ResetText();
                txtPass.Focus();
            }
        }
        
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult CheckExit = MessageBox.Show("Bạn có chắc chắn muốn hủy?", "Cancel confirm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            //Mở kết nói
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand();


            try
            {
                
                if(txtID.Text == "" || txtPass.Text == "" || txtConfirmPass.Text == "")
                {
                    if (txtID.Text == "")
                    {
                        MessageBox.Show("Chưa nhập ID hoặc mật khẩu!!!", "Warning!!!");
                        txtID.Focus();
                    }
                    else if (txtPass.Text == "")
                    {
                        MessageBox.Show("Chưa nhập ID hoặc mật khẩu!!!", "Warning!!!");
                        txtPass.Focus();
                    }
                    else if (txtConfirmPass.Text == "")
                    {
                        MessageBox.Show("Chưa xác nhận mất khẩu!!!", "Warning!!!");
                        txtConfirmPass.Focus();
                    }    
                }
                else
                {
                    //Thực hiện lệnh
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    //Lệnh Insert Into
                    cmd.CommandText = "INSERT INTO users VALUES('" + txtID.Text
                        + "','" + txtPass.Text + "')";
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    MessageBox.Show("Đã đăng ký thành công!", "Sign Up successed!!!");
                    this.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(cmd.CommandText);
            }
        }
        
        private void txtID_Leave(object sender, EventArgs e)
        {
            if(txtID.Text != "") CheckUserIDExit();
        }

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text != "")
            CheckUserPasswordExit();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            LoadData();
            txtID.Focus();
        }

    }
}
