using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Thư viện kết nối SQL
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data.Linq.Mapping;
//Kiểm tra
using System.Text.RegularExpressions;

namespace _19110038_HoangNhutKhanhNgan
{
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
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
        SqlDataAdapter adCustomer = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtCustomer = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            txtCID.ResetText();
            txtCFName.ResetText();
            txtCLName.ResetText();
            txtCEmail.ResetText();
            txtCPhone.ResetText();
            txtStreet.ResetText();
            cbCity.ResetText();
            cbState.ResetText();
            txtZipcode.ResetText();
        }
        void SetBtEdit_On()
        {
            btSave.Enabled = true;
            btCancel.Enabled = true;
            grPanel.Enabled = true;

            //Enable các control Add, Edit, Delete, Exit, ...
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btExit.Enabled = false;
            dtGridView.Enabled = false;
        }
        void SetBtEdit_Off()
        {
            btSave.Enabled = false;
            btCancel.Enabled = false;
            grPanel.Enabled = false;

            //Enable các control Add, Edit, Delete, Exit, ...
            btAdd.Enabled = true;
            btEdit.Enabled = true;
            btDelete.Enabled = true;
            btReload.Enabled = true;
            btExit.Enabled = true;
            dtGridView.Enabled = true;
            Add = false;
        }
        void LoadData()
        {
            ResetAllTextBox();
            SetBtEdit_Off();
            //Không kích hoạt các control Save, Cancel, Panel chứa các text

            //Tạo kết nối
            try
            {
                conn = new SqlConnection(connstr);
                adCustomer = new SqlDataAdapter("SELECT * FROM customers", conn);
                dtCustomer = new DataTable();
                adCustomer.Fill(dtCustomer);
                dtGridView.DataSource = dtCustomer;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Customer", "Lỗi dữ liệu!");
            }
        }
        void CheckCustomerIDExit()
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
                // Lệnh kiem tra thanh pho ton tai ? 
                cmd.CommandText = "SELECT Count(*) FROM customers WHERE customer_id = '" + txtCID.Text.Trim() + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("Customer ID (" + txtCID.Text.Trim() + ") đã có. Nhập  lại!");
                    txtCID.ResetText();
                    txtCID.Focus();
                }
                else
                {
                    txtCFName.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }
        }
        //Kiểm tra Email hợp lệ
        void EmailAgain()
        {
            MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại!", "Warning!!!");
            txtCEmail.ResetText();
            txtCEmail.Focus();
        }
        void CheckEmailExit()
        {
            string email = txtCEmail.Text;
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            if (!reg.IsMatch(email))
            {
                EmailAgain();
            }
        }
        
        //Kiểm tra sđt hợp lệ
        void PhoneAgain()
        {
            MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại!", "Warning!!!");
            txtCPhone.ResetText();
            txtCPhone.Focus();
        }
        void CheckPhoneExit()
        {
            string phone = txtCPhone.Text;
            if (phone.Length < 6 || phone.Length > 11)
            {
                PhoneAgain();
            }
            else
                for (int i = 0; i < phone.Length; i++)
                    if (phone[i] < 48 || phone[i] > 57)
                    {
                        PhoneAgain();
                        break;
                    }
        }
        //Truy vấn combobox
        SalesDataContextDataContext db = null;
        private void MySetProvince()
        {
            db = new SalesDataContextDataContext();
            var ProvQ = from ProvinceList in db.provinces
                        select ProvinceList.province_name;
            cbCity.DataSource = ProvQ;
        }
        private void MySetDistrict()
        {
            var DistQ = from DistList in db.districts
                        join ProvList in db.provinces on DistList.province_id equals
                        ProvList.province_id
                        where (ProvList.province_name == cbCity.Text)
                        select DistList.district_name;
            cbState.DataSource = DistQ;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            // Kich hoạt biến Them
            Add = true;
            // Xóa trống các đối tượng trong Panel
            ResetAllTextBox();
            // Kích hoạt chế độ nhập/sửa dữ liệu
            SetBtEdit_On();
            // Đưa con trỏ đến đầu TextBox Stores ID
            txtCID.Focus();
            MySetProvince();
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            MySetProvince();
            Add = false;
            dtGridView_CellClick(null, null);
            SetBtEdit_On();
            txtCID.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!txtCID.Text.Trim().Equals(""))
            {
                //Mở kết nói
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                if (Add) //Thêm dữ liệu
                {
                    try
                    {
                        //Thực hiện lệnh
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        //Lệnh Insert Into
                        cmd.CommandText = "INSERT INTO customers VALUES('" + txtCID.Text
                            + "','" + txtCFName.Text + "','" + txtCLName.Text + "','" +
                            txtCPhone.Text + "','" + txtCEmail.Text + "','" + txtStreet.Text + "','" + cbCity.Text +
                            "','" + cbState.Text + "','" + txtZipcode.Text + "')";
                        cmd.ExecuteNonQuery();
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm dữ liệu thành công!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(cmd.CommandText);
                    }
                }
                else //sửa đổi
                {
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        //Thứ tự dòng hiện hành
                        int r = dtGridView.CurrentCell.RowIndex; //MaKH hiện hành
                        string strCustomerID = dtGridView.Rows[r].Cells[0].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE customers SET " + "customer_id='" +
                    txtCID.Text + "', first_name='" + txtCFName.Text + "',last_name='" +
                    txtCLName.Text + "',phone ='" + txtCPhone.Text + "',email ='" + txtCEmail.Text + "', street='" +
                    txtStreet.Text + "',city ='" + cbCity.Text + "', state='" +
                    cbState.Text + "',zip_code='" + txtZipcode.Text + "'WHERE customer_id = '" + strCustomerID + "'";
                        //Cập nhật
                        cmd.ExecuteNonQuery();
                        //Load lại dữ liệu trên DataGridView
                        LoadData();
                        //Thông báo
                        MessageBox.Show("Cập nhật dữ liệu thành công!!!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(cmd.CommandText); //Không sửa được. Lỗi rồi!");
                    }
                }
                //Đóng kết nối
                conn.Close();
            }
            else
            {
                MessageBox.Show("Thành phố chưa có. Lỗi rồi!");
                txtCID.Focus();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.SetBtEdit_Off();
            ResetAllTextBox();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra User có muốn xóa hàng dữ liệu
            DialogResult CheckYN;
            CheckYN = MessageBox.Show("Có chắc xóa không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (CheckYN == DialogResult.Yes)
            {
                // Mở kết nối
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandType = CommandType.Text;
                    // Lấy Row hiện tại

                    int r = dtGridView.CurrentCell.RowIndex;
                    // Store_ID của record hiện hành

                    string CustomerID = dtGridView.Rows[r].Cells[0].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM customers WHERE customer_id='" + CustomerID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại dữ liệu trên DataGridVie

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công CustomerID =" + CustomerID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Customer hiện hành.");
                }
                finally
                {
                    conn.Close();
                }
            }
            SetBtEdit_Off();
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult CheckExit = MessageBox.Show("Có muốn Exit không?", "Exit confirm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckExit == DialogResult.Yes)
            {
                this.Close();
                //Menu menu = new Menu();
                //menu.Show();
            }
        }
        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtCID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtCFName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtCLName.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtCPhone.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtCEmail.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtStreet.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbCity.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            cbState.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            txtZipcode.Text = dtGridView.Rows[r].Cells[8].Value.ToString();
            btEdit.Enabled = true;
        }
        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtCID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtCFName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtCLName.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtCPhone.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtCEmail.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtStreet.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbCity.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            cbState.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            txtZipcode.Text = dtGridView.Rows[r].Cells[8].Value.ToString();
            btEdit.Enabled = true;
        }

        private void txtCID_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckCustomerIDExit();
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySetDistrict();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtCEmail_Leave(object sender, EventArgs e)
        {
            if (txtCEmail.Text != "") CheckEmailExit();
        }

        private void txtCPhone_Leave(object sender, EventArgs e)
        {
            if (txtCPhone.Text != "") CheckPhoneExit();
        }
    }
}
