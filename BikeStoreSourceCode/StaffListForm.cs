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
    public partial class StaffListForm : Form
    {
        public StaffListForm()
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
        SqlDataAdapter adStaff = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtStaff = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            txtSID.ResetText();
            txtSFName.ResetText();
            txtSLName.ResetText();
            txtSEmail.ResetText();
            txtSPhone.ResetText();
            txtActive.ResetText();
            cbStoreID.ResetText();
            cbStoreName.ResetText();
            cbManID.ResetText();
            cbManaName.ResetText();
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
                adStaff = new SqlDataAdapter("SELECT * FROM staffs", conn);
                dtStaff = new DataTable();
                adStaff.Fill(dtStaff);
                dtGridView.DataSource = dtStaff;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Staff", "Lỗi dữ liệu!");
            }
        }
        void CheckStaffIDExit()
        {
            //Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                //Thực hiện lệnh
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Lệnh kiểm tra thành phố tồn tại?
                cmd.CommandText = "SELECT Count(*) FROM staffs WHERE staff_id = '" +
                    txtSID.Text.Trim() + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("StaffID (" + txtSID.Text.Trim() + ") đã có. Nhập lại!");
                    txtSID.ResetText();
                    txtSID.Focus();
                }
                else
                {
                    txtSFName.Focus();
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
        //Truy vấn - combo box
        SalesDataContextDataContext db = null;
        private void MySetStoreID()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoreList in db.stores
                        select StoreList.store_id;
            cbStoreID.DataSource = StoreQ;
        }
        private void MyUpdateStoreID()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoreList in db.stores
                        where StoreList.store_name == cbStoreName.Text
                        select StoreList.store_id;
            //cbPID.SelectedItem = ProdQ.Where ;
            foreach (var store_id in StoreQ)
                cbStoreID.SelectedItem = store_id;
        }
        private void MySetStoreName()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoreList in db.stores
                        select StoreList.store_name;
            cbStoreName.DataSource = StoreQ;
        }
        private void MyUpdateStoreName()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoreList in db.stores
                       where StoreList.store_id == cbStoreID.Text
                       select StoreList.store_name;
            foreach (var store_name in StoreQ)
                cbStoreName.SelectedItem = store_name;
        }
        //
        private void MySetManagerID()
        {
            db = new SalesDataContextDataContext();
            var ManQ = from StaffList in db.staffs
                       select StaffList.staff_id;
            cbManID.DataSource = ManQ;
        }
        private void MyUpdateManaID()
        {
            db = new SalesDataContextDataContext();
            var StaID = from StaffList in db.staffs
                        where (string.Concat(StaffList.first_name, " ", StaffList.last_name) == cbManaName.Text)
                        select StaffList.staff_id;
            foreach (var staff_id in StaID)
                cbManID.SelectedItem = staff_id;
        }
        private void MySetManaName()
        {
            db = new SalesDataContextDataContext();
            var StaQ = from StaList in db.staffs
                       select StaList;
            foreach (var staff in StaQ)
            {
                string StaName = string.Concat(staff.first_name, " ", staff.last_name);
                cbManaName.Items.Add(StaName);
            }
        }

        private void MyUpdateManaName()
        {
            db = new SalesDataContextDataContext();
            var StaName = from StaffList in db.staffs
                          where StaffList.staff_id == cbManID.Text
                          select new { StaffList.first_name, StaffList.last_name };
            foreach (var staff_name in StaName)
            {
                cbManaName.SelectedItem = string.Concat(staff_name.first_name, " ", staff_name.last_name);
            }
        }
        //

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
            MySetStoreID();
            MySetStoreName();
            MySetManagerID();
            MySetManaName();
            MyUpdateManaName();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MySetStoreID();
            MySetStoreName();
            MySetManagerID();
            MySetManaName();
            MyUpdateManaName();
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
                        cmd.CommandText = "INSERT INTO staffs VALUES('" + txtSID.Text
                            + "','" + txtSFName.Text + "','" + txtSLName.Text + "','" + txtSEmail.Text + "','" +
                            txtSPhone.Text + "'," + Int32.Parse(txtActive.Text).ToString() + ",'" + cbStoreID.Text + "','"
                            + cbManID.Text + "')";
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
                        string strStaffID = dtGridView.Rows[r].Cells[0].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE staffs SET " + "staff_id='" +
                    txtSID.Text + "', first_name='" + txtSFName.Text +
                    "', last_name='" + txtSLName.Text + "', email ='" +
                    txtSEmail.Text + "',phone ='" + txtSPhone.Text + "', active=" +
                    Int32.Parse(txtActive.Text).ToString() + ",store_id ='" + cbStoreID.Text + "', manager_id='" +
                    cbManID.Text + "'WHERE staff_id = '" + strStaffID + "'";
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
            CheckYN = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

                    string StaffID = dtGridView.Rows[r].Cells[0].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM staffs WHERE staff_id='" + StaffID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại dữ liệu trên DataGridVie

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công Staff ID = " + StaffID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Staff hiện hành.");
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
            }
        }
        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtSID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtSFName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtSLName.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtSEmail.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtSPhone.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtActive.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbStoreID.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            cbManID.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            btEdit.Enabled = true;
        }
        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtSID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtSFName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtSLName.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtSEmail.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtSPhone.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtActive.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbStoreID.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            cbManID.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            btEdit.Enabled = true;
        }

        private void txtSID_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckStaffIDExit();
                MySetManagerID();
            }
        }

        private void StaffListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSEmail_Leave(object sender, EventArgs e)
        {
            if (txtSEmail.Text != "") CheckEmailExit();
        }

        private void txtSPhone_Leave(object sender, EventArgs e)
        {
            if (txtSPhone.Text != "") CheckPhoneExit();
        }

        private void cbStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateStoreName();
        }

        private void cbStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateStoreID();
        }

        private void cbManID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateManaName();
        }

        private void cbManaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateManaID();
        }

        private void txtSLName_Leave(object sender, EventArgs e)
        {
            cbManID.Text = txtSID.Text;
            cbManaName.Text = string.Concat(txtSFName.Text, " ", txtSLName.Text);
        }
    }
}
