using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
//Kiểm tra
using System.Text.RegularExpressions;

namespace _19110038_HoangNhutKhanhNgan
{
    public partial class StoreListForm : Form
    {
        public StoreListForm()
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
        SqlDataAdapter adStore = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtStore = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            txtSID.ResetText();
            txtSName.ResetText();
            txtSEmail.ResetText();
            txtSPhone.ResetText();
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
            //dtGridView.DataSource = ProvQ;
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
                adStore = new SqlDataAdapter("SELECT * FROM stores", conn);
                dtStore = new DataTable();
                adStore.Fill(dtStore);
                dtGridView.DataSource = dtStore;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Store", "Lỗi dữ liệu!");
            }
        }
        void CheckStoreIDExit()
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
                cmd.CommandText = "SELECT Count(*) FROM stores WHERE store_id = '" + txtSID.Text.Trim() + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("StoreID (" + txtSID.Text.Trim() + ") đã có. Nhập  lại!");
                    txtSID.ResetText();
                    txtSID.Focus();
                }
                else
                {
                    txtSName.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }

        }
        void CheckStoreNameExit()
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
                cmd.CommandText = "SELECT Count(*) FROM stores WHERE store_name = '" + txtSName.Text.Trim() + "'";

                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("Store name (" + txtSName.Text.Trim() + ") đã có.Nhập lại!");
                    txtSName.ResetText();
                    txtSName.Focus();
                }
                else
                {
                    txtSPhone.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }
            finally
            {
                conn.Close();
            }
        }
        //Kiểm tra sđt hợp lệ
        void PhoneAgain()
        {
            MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại!", "Warning!!!");
            txtSPhone.ResetText();
            txtSPhone.Focus();
        }
        void CheckPhoneExit()
        {
            string phone = txtSPhone.Text;
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
        //Kiểm tra Email hợp lệ
        void EmailAgain()
        {
            MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại!", "Warning!!!");
            txtSEmail.ResetText();
            txtSEmail.Focus();
        }
        void CheckEmailExit()
        {
            string email = txtSEmail.Text;
            string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex reg = new Regex(match);
            if (!reg.IsMatch(email))
            {
                EmailAgain();
            }    
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
            txtSID.Focus();
            MySetProvince();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MySetProvince();
            Add = false;
            dtGridView_CellClick(null, null);
            SetBtEdit_On();
            txtSID.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!txtSID.Text.Trim().Equals(""))
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
                        cmd.CommandText = "INSERT INTO stores VALUES('" + txtSID.Text
                            + "','" + txtSName.Text + "','" + txtSPhone.Text + "','" +
                            txtSEmail.Text + "','" + txtStreet.Text + "','" + cbCity.Text +
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
                        string strStoreID = dtGridView.Rows[r].Cells[0].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE stores SET " + "store_id='" +
                    txtSID.Text + "', store_name='" + txtSName.Text + "',phone ='" +
                    txtSPhone.Text + "',email ='" + txtSEmail.Text + "', street='" +
                    txtStreet.Text + "',city ='" + cbCity.Text + "', state='" +
                    cbState.Text + "',zip_code='" + txtZipcode.Text + "'WHERE store_id = '" + strStoreID + "'";
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
                txtSID.Focus();
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

                    string StoreID = dtGridView.Rows[r].Cells[0].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM stores WHERE store_id='" + StoreID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại dữ liệu trên DataGridView

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công StoreID =" + StoreID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Store hiện hành.");
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
            DialogResult CheckExit = MessageBox.Show("Bạn có chắc chắn muốn Exit?", "Exit confirm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckExit == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtSID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtSName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtSPhone.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtSEmail.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtStreet.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            cbCity.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbState.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            txtZipcode.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            btEdit.Enabled = true;
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtSID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtSName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtSPhone.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtSEmail.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtStreet.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            cbCity.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbState.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            txtZipcode.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            btEdit.Enabled = true;
        }

        private void txtSID_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckStoreIDExit();
            }
        }

        private void txtSName_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckStoreNameExit();
            }
        }
        private void StoreListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySetDistrict();
        }

        private void txtSPhone_Leave(object sender, EventArgs e)
        {
            if(txtSPhone.Text != "") CheckPhoneExit();
        }

        private void txtSEmail_Leave(object sender, EventArgs e)
        {
            if (txtSEmail.Text != "") CheckEmailExit();
        }
    }
}
