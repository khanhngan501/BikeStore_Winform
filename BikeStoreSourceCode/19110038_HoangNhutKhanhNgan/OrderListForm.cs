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

namespace _19110038_HoangNhutKhanhNgan
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
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
        SqlDataAdapter adOrder = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtOrder = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            txtOID.ResetText();
            cbCID.ResetText();
            cbCName.ResetText();
            dateOrder.ResetText();
            dateRequire.ResetText();
            dateShipped.ResetText();
            txtOrderStatus.ResetText();
            cbStoreID.ResetText();
            cbStoreName.ResetText();
            cbStaffID.ResetText();
            cbStaffName.ResetText();
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
                adOrder = new SqlDataAdapter("SELECT * FROM orders", conn);
                dtOrder = new DataTable();
                adOrder.Fill(dtOrder);
                dtGridView.DataSource = dtOrder;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Orders", "Lỗi dữ liệu!");
            }
        }
        void CheckOrderIDExit()
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
                cmd.CommandText = "SELECT Count(*) FROM orders WHERE order_id = '" + txtOID.Text.Trim() + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("OrderID (" + txtOID.Text.Trim() + ") đã có. Nhập  lại!");
                    txtOID.ResetText();
                    txtOID.Focus();
                }
                else
                {
                    cbCID.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }

        }
        SalesDataContextDataContext db = null;
        private void MySetCustomerID()
        {
            db = new SalesDataContextDataContext();
            var CustQ = from CustomerList in db.customers
                         select CustomerList.customer_id;
            cbCID.DataSource = CustQ;
        }
        
        private void MyUpdateCusID()
        {
            db = new SalesDataContextDataContext();
            var CusID = from CusList in db.customers
                        where (string.Concat(CusList.first_name, " ", CusList.last_name) == cbCName.Text)
                        select CusList.customer_id;
            foreach (var customer_id in CusID)
                cbCID.SelectedItem = customer_id;
        }
        private void MySetCustomerName()
        {
            db = new SalesDataContextDataContext();
            cbCName.Items.Clear();
            var CusQ = from CusList in db.customers
                       select CusList;
            foreach (var product in CusQ)
            {
                string CName = string.Concat(product.first_name, " ", product.last_name);
                cbCName.Items.Add(CName);
            }
        }
        private void MyUpdateCusName()
        {
            db = new SalesDataContextDataContext();
            var CusName = from CusList in db.customers
                          where CusList.customer_id == cbCID.Text
                          select new { CusList.first_name, CusList.last_name };
            foreach (var customer_name in CusName)
            {
                cbCName.SelectedItem = string.Concat(customer_name.first_name, " ", customer_name.last_name);
            }    
        }
        private void MySetStoreID()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoreList in db.stores
                         select StoreList.store_id;
            cbStoreID.DataSource = StoreQ;
            //MyUpdateCusName();
            //MyUpdateStaffName();
        }
        private void MyUpdateStoreID()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoList in db.stores
                        where StoList.store_name == cbStoreName.Text
                        select StoList.store_id;
            foreach (var store_id in StoreQ)
                cbStoreID.SelectedItem = store_id;
        }
        private void MySetStoreName()
        {
            db = new SalesDataContextDataContext();
            //cbStoreName.Items.Clear();
            var StoreQ = from StoList in db.stores
                        select StoList.store_name;
            cbStoreName.DataSource = StoreQ;
        }
        private void MyUpdateStoreName()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoList in db.stores
                       where StoList.store_id == cbStoreID.Text
                       select StoList.store_name;
            foreach (var store_name in StoreQ)
                cbStoreName.SelectedItem = store_name;
        }
        private void MySetStaffID()
        {
            db = new SalesDataContextDataContext();
            var StaffQ = from StaffList in db.staffs
                         select StaffList.staff_id;
            cbStaffID.DataSource = StaffQ;
            //MyUpdateStaffName();
        }
        private void MyUpdateStaffID()
        {
            db = new SalesDataContextDataContext();
            var StaID = from StaffList in db.staffs
                        where (string.Concat(StaffList.first_name, " ", StaffList.last_name) == cbStaffName.Text)
                        select StaffList.staff_id;
            foreach (var staff_id in StaID)
                cbStaffID.SelectedItem = staff_id;
        }
        private void MySetStaffName()
        {
            db = new SalesDataContextDataContext();
            cbStaffName.Items.Clear();
            var StaQ = from StaList in db.staffs
                       select StaList;
            foreach (var staff in StaQ)
            {
                string StaName = string.Concat(staff.first_name, " ", staff.last_name);
                cbStaffName.Items.Add(StaName);
            }
        }

        private void MyUpdateStaffName()
        {
            db = new SalesDataContextDataContext();
            var StaName = from StaffList in db.staffs
                          where StaffList.staff_id == cbStaffID.Text
                          select new { StaffList.first_name, StaffList.last_name };
            foreach (var staff_name in StaName)
            {
                cbStaffName.SelectedItem = string.Concat(staff_name.first_name, " ", staff_name.last_name);
            }
        }
        //
        
        private void btAdd_Click(object sender, EventArgs e)
        {
            int tmp;
            tmp = dtGridView.Rows.Count;
            // Kich hoạt biến Them
            Add = true;
            // Xóa trống các đối tượng trong Panel
            ResetAllTextBox();
            // Kích hoạt chế độ nhập/sửa dữ liệu
            SetBtEdit_On();
            // Đưa con trỏ đến đầu TextBox Stores ID//
            //string last = dtGridView.Rows[r - 1].Cells[0].Value.ToString();
            //int setID = Int32.Parse(last) + 1;
            //txtOID.Text = setID.ToString();
            txtOID.Text = (tmp++).ToString();
            cbCID.Focus();
            MySetCustomerID();
            MySetCustomerName();
            MyUpdateCusName();
            MySetStoreID();
            MySetStoreName();
            MyUpdateStoreName();
            MySetStaffID();
            MySetStaffName();
            MyUpdateStaffName();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MySetCustomerID();
            MySetCustomerName();
            MyUpdateCusName();
            MySetStoreID();
            MySetStoreName();
            MyUpdateStoreName();
            MySetStaffID();
            MySetStaffName();
            MyUpdateStaffName();
            Add = false;
            dtGridView_CellClick(null, null);
            SetBtEdit_On();
            txtOID.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!txtOID.Text.Trim().Equals(""))
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
                        cmd.CommandText = "INSERT INTO orders VALUES('" +  cbCID.Text + "'," + Int32.Parse(txtOrderStatus.Text).ToString() + ","  +
                            dateOrder.Text + "," + dateRequire.Text + ","+ dateShipped.Text +
                            ",'" + cbStoreID.Text + "','" + cbStaffID.Text + "')";
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
                        string strOrderID = dtGridView.Rows[r].Cells[0].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE orders SET " + "customer_id='" + cbCID.Text + "',order_status =" +
                    Int32.Parse(txtOrderStatus.Text).ToString() + ",order_date =" +dateOrder.Text +
                    "', required_date=" + dateRequire.Text + ",shipped_date =" + dateShipped.Text +
                    ", store_id='" +cbStoreID.Text + "',staff_id='" + cbStaffID.Text +
                    "'WHERE order_id = '" + strOrderID + "'";
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
                txtOID.Focus();
            }
            ResetAllTextBox();
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

                    string OrderID = dtGridView.Rows[r].Cells[0].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM orders WHERE order_id='" + OrderID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại dữ liệu trên DataGridVie

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công OrderID =" + OrderID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Order hiện hành.");
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
            DialogResult CheckExit = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Exit confirm!",
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
            txtOID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            cbCID.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtOrderStatus.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            dateOrder.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            dateRequire.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            dateShipped.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbStoreID.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            cbStaffID.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            btEdit.Enabled = true;
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtOID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            cbCID.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtOrderStatus.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            dateOrder.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            dateRequire.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            dateShipped.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            cbStoreID.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            cbStaffID.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            btEdit.Enabled = true;
        }
        private void txtOID_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckOrderIDExit();
            }
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateStoreName();
        }

        private void cbStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateStoreID();
        }

        private void cbCID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateCusName();
        }

        private void cbCName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateCusID();
        }

        private void cbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateStaffName();
        }

        private void cbStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateStaffID();
        }

        private void dateRequire_ValueChanged(object sender, EventArgs e)
        {
            DateTime OrderDate = DateTime.Parse(dateOrder.Text);
            DateTime RequireDate = DateTime.Parse(dateRequire.Text);
            //DateTime ShippedDate = DateTime.Parse(dateShipped.Text);
            if (OrderDate > RequireDate)
            {
                MessageBox.Show("Thiết lập ngày không hợp lệ!! Vui lòng nhập lại!!", "Warning!!!");
                dateOrder.ResetText();
                dateRequire.ResetText();
            }
        }

        private void dateShipped_ValueChanged(object sender, EventArgs e)
        {
            //DateTime OrderDate = DateTime.Parse(dateOrder.Text);
            DateTime RequireDate = DateTime.Parse(dateRequire.Text);
            DateTime ShippedDate = DateTime.Parse(dateShipped.Text);
            if (RequireDate > ShippedDate)
            {
                MessageBox.Show("Thiết lập ngày không hợp lệ!! Vui lòng nhập lại!!", "Warning!!!");
                dateOrder.ResetText();
                dateRequire.ResetText();
                dateShipped.ResetText();
            }
        }
    }
}
