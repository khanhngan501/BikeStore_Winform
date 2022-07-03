using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using System.Data.SqlClient;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace _19110038_HoangNhutKhanhNgan
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        
        //Chuỗi kết nối
        string connstr = "Data Source=DESKTOP-9SB50R4;Initial Catalog=Sales;Integrated Security=True";
        //string connstr = "Data Source=(localdb)\mssqllocaldb;Initial
        //          Catalog=Sales;Integrated Security = True";

        //Đối tượng kết nối
        SqlConnection conn = null;
        //Đối tượng đưa dữ liệu vào Data Table SqlStore
        SqlDataAdapter adAcc = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtAcc = null;
        //
        SqlDataReader dr = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        //bool Add = false;
        //Phương thức dùng chung
        
        void SetBtEdit_Off()
        {
            btEdit.Enabled = true;
            btReload.Enabled = true;
            btExit.Enabled = true;
            //
            btCancel.Enabled = false;
            btSave.Enabled = false;
        }
        void SetBtEdit_On()
        {
            btEdit.Enabled = false;
            btReload.Enabled = false;
            btExit.Enabled = false;
            //
            btCancel.Enabled = true;
            btSave.Enabled = true;
        }

        void SetAllTextBox()
        {
            db = new SalesDataContextDataContext();
            var AccQ = from Acc in db.Accounts
                       join User in db.users on Acc.ID equals
                       User.ID
                       where (Acc.ID == txtID.Text)
                       select Acc;
        }
        SalesDataContextDataContext db = null;

        void LoadData()
        {
            //ResetAllTextBox();
            SetBtEdit_Off();
            //Không kích hoạt các control Save, Cancel, Panel chứa các text

            //Tạo kết nối
            try
            {
                conn = new SqlConnection(connstr);
                adAcc = new SqlDataAdapter("SELECT * FROM Accounts", conn);
                dtAcc = new DataTable();
                adAcc.Fill(dtAcc);
                //dtGridView.DataSource = dtStore;
                //
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Account", conn);
                //conn.Open();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtID.Text = dr[0].ToString();
                    txtPass.Text = dr[1].ToString();
                    txtUName.Text = dr[2].ToString();
                    dtBirth.Value = DateTime.Parse(dr[3].ToString());
                    txtEmail.Text = dr[4].ToString();
                    txtPhone.Text = dr[5].ToString();
                    txtStreet.Text = dr[6].ToString();
                    cbCity.SelectedValue = dr[7].ToString();
                    cbDistrict.SelectedValue = dr[8].ToString();
                    cbCommune.SelectedValue = dr[9].ToString();
                    conn.Close();
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Account", "Lỗi dữ liệu!");
            }
        }

        private void Load_Data(string ID)
        {
            try
            {
                conn = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Account", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtID.Text = dr[0].ToString();
                    txtPass.Text = dr[1].ToString();
                    txtUName.Text = dr[2].ToString();
                    dtBirth.Value = DateTime.Parse(dr[3].ToString());
                    txtEmail.Text = dr[4].ToString();
                    txtPhone.Text = dr[5].ToString();
                    txtStreet.Text = dr[6].ToString();
                    cbCity.SelectedValue = dr[7].ToString();
                    cbDistrict.SelectedValue = dr[8].ToString();
                    cbCommune.SelectedValue = dr[9].ToString();
                    conn.Close();
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Account", "Lỗi dữ liệu!");
            }
            conn.Close();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            Load_Data(ID);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
