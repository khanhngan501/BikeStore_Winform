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
    public partial class Order_ItemListForm : Form
    {
        public Order_ItemListForm()
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
        SqlDataAdapter adOr_Item = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtOr_Item = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            cbOID.ResetText();
            txtItemID.ResetText();
            cbPID.ResetText();
            txtQuan.ResetText();
            txtListPrice.ResetText();
            txtDiscount.ResetText();
            cbPName.ResetText();
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
                adOr_Item = new SqlDataAdapter("SELECT * FROM order_items", conn);
                dtOr_Item = new DataTable();
                adOr_Item.Fill(dtOr_Item);
                dtGridView.DataSource = dtOr_Item;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Order Item", "Lỗi dữ liệu!");
            }
        }
        void CheckItemIDExit()
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
                cmd.CommandText = "SELECT Count(*) FROM order_items WHERE item_id = '" + txtItemID.Text.Trim() + 
                    "' and order_id = '" + cbOID.Text.Trim() + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("Order Item ID (" + txtItemID.Text.Trim() + ") đã có. Nhập  lại!");
                    txtItemID.ResetText();
                    txtItemID.Focus();
                }
                else
                {
                    cbPID.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }

        }
        SalesDataContextDataContext db = null;
        private void MySetOrderID()
        {
            db = new SalesDataContextDataContext();
            var OrderQ = from OrderList in db.orders
                         select OrderList.order_id;
            cbOID.DataSource = OrderQ;
        }
        //
        private void MySetProductID()
        {
            db = new SalesDataContextDataContext();
            var ProdQ = from ProdList in db.products
                        select ProdList.product_id;
            cbPID.DataSource = ProdQ;
        }
        private void MyUpdateProductID()
        {
            db = new SalesDataContextDataContext();
            var ProdQ = from ProdList in db.products
                        where ProdList.product_name == cbPName.Text
                        select ProdList.product_id;
            //cbPID.SelectedItem = ProdQ.Where ;
            foreach (var product_id in ProdQ)
                cbPID.SelectedItem = product_id;
        }
        private void MySetProductName()
        {
            db = new SalesDataContextDataContext();
            var ProdQ = from ProdList in db.products
                        select ProdList.product_name;
            cbPName.DataSource = ProdQ;
        }
        private void MyUpdateProductName()
        {
            db = new SalesDataContextDataContext();
            var ProQ = from ProdList in db.products
                       where ProdList.product_id == Int32.Parse(cbPID.Text)
                       select ProdList.product_name;
            foreach (var product_name in ProQ)
                cbPName.SelectedItem = product_name;
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
            cbOID.Focus();
            MySetOrderID();
            MySetProductID();
            MySetProductName();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MySetOrderID();
            MySetProductID();
            MySetProductName();
            Add = false;
            dtGridView_CellClick(null, null);
            SetBtEdit_On();
            cbOID.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!cbOID.Text.Trim().Equals(""))
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
                        cmd.CommandText = "INSERT INTO order_items VALUES('" + cbOID.Text
                            + "','" + txtItemID.Text + "','" + cbPID.Text + "'," +
                            Int32.Parse(txtQuan.Text).ToString() + "," +
                            decimal.Parse(txtListPrice.Text).ToString() + "," +
                            decimal.Parse(txtDiscount.Text).ToString() + ")";
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
                        string strItemID = dtGridView.Rows[r].Cells[1].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE order_items SET " + "order_id='" +
                    cbOID.Text + "', item_id='" + txtItemID.Text + "',product_id ='" +
                    cbPID.Text + "',quantity =" + Int32.Parse(txtQuan.Text).ToString() +
                     ",list_price = " +decimal.Parse(txtListPrice.Text).ToString() +
                     ",discount = " + decimal.Parse(txtDiscount.Text).ToString() +
                    "WHERE item_id = '" + strItemID + "' and order_id = '" + strOrderID + "'";
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
                txtItemID.Focus();
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
                    string OrderID = dtGridView.Rows[r].Cells[0].Value.ToString();
                    string ItemID = dtGridView.Rows[r].Cells[1].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM order_items WHERE item_id='" + ItemID + "' and order_id = '" + OrderID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại dữ liệu trên DataGridVie

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công ItemID =" + ItemID + ", OrderID = " + OrderID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Item hiện hành.");
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
            DialogResult CheckExit = MessageBox.Show("Bạn có chắc chắc muốn thoát?", "Exit confirm!",
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
            cbOID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtItemID.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbPID.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtQuan.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtListPrice.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtDiscount.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            btEdit.Enabled = true;
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            cbOID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtItemID.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbPID.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtQuan.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtListPrice.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtDiscount.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            btEdit.Enabled = true;
        }
        private void txtItemID_Leave(object sender, EventArgs e)
        {
            if (Add) CheckItemIDExit();
        }

        private void Order_ItemListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbPID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateProductName();
        }

        private void cbPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateProductID();
        }
    }
}
