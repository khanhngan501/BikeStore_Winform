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
    public partial class StockListForm : Form
    {
        public StockListForm()
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
        SqlDataAdapter adStock = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtStock = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            cbSID.ResetText();
            cbPID.ResetText();
            txtQuantity.ResetText();
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
                adStock = new SqlDataAdapter("SELECT * FROM stocks", conn);
                dtStock = new DataTable();
                adStock.Fill(dtStock);
                dtGridView.DataSource = dtStock;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Stock", "Lỗi dữ liệu!");
            }
        }
        SalesDataContextDataContext db = null;
        private void MySetStoreID()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoreList in db.stores
                        select StoreList.store_id;
            cbSID.DataSource = StoreQ;
        }
        private void MyUpdateStoreID()
        {
            db = new SalesDataContextDataContext();
            var StoreQ = from StoreList in db.stores
                         where StoreList.store_name == cbStoreName.Text
                         select StoreList.store_id;
            //cbPID.SelectedItem = ProdQ.Where ;
            foreach (var store_id in StoreQ)
                cbSID.SelectedItem = store_id;
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
                         where StoreList.store_id == cbSID.Text
                         select StoreList.store_name;
            foreach (var store_name in StoreQ)
                cbStoreName.SelectedItem = store_name;
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
                        where ProdList.product_name == cbProName.Text
                        select ProdList.product_id;
            foreach (var product_id in ProdQ)
                cbPID.SelectedItem = product_id;
        }
        private void MySetProductName()
        {
            db = new SalesDataContextDataContext();
            var ProdQ = from ProdList in db.products
                        select ProdList.product_name;
            cbProName.DataSource = ProdQ;
        }
        private void MyUpdateProductName()
        {
            db = new SalesDataContextDataContext();
            var ProQ = from ProdList in db.products
                       where ProdList.product_id == Int32.Parse(cbPID.Text)
                       select ProdList.product_name;
            foreach (var product_name in ProQ)
                cbProName.SelectedItem = product_name;
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
            cbSID.Focus();
            MySetStoreID();
            MySetStoreName();
            MySetProductID();
            MySetProductName();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MySetStoreID();
            MySetStoreName();
            MySetProductID();
            MySetProductName();
            Add = false;
            dtGridView_CellClick(null, null);
            SetBtEdit_On();
            cbSID.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!cbSID.Text.Trim().Equals(""))
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
                        cmd.CommandText = "INSERT INTO stocks VALUES('" + cbSID.Text
                            + "','" + cbPID.Text + "'," + Int32.Parse(txtQuantity.Text).ToString() + ")";
                        cmd.ExecuteNonQuery();
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm dữ liệu thành công!!!");
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
                        string strStore = dtGridView.Rows[r].Cells[0].Value.ToString();
                        string strProd = dtGridView.Rows[r].Cells[1].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE stocks SET " + "store_id='" +
                    cbSID.Text + "', product_id='" + cbPID.Text +
                    "',quantity=" + Int32.Parse(txtQuantity.Text).ToString() +
                    "WHERE store_id = '" + strStore + "' and product_id = '" + strProd + "'";
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
                MessageBox.Show("Lỗi rồi!");
                cbSID.Focus();
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

                    string StoreID = dtGridView.Rows[r].Cells[0].Value.ToString();
                    string ProductID = dtGridView.Rows[r].Cells[1].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM stocks WHERE store_id='" + StoreID + "' and product_id='" + ProductID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại dữ liệu trên DataGridVie

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công Store ID =" + StoreID + ", ProductID =" + ProductID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Stock hiện hành.");
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
            if (CheckExit == DialogResult.Yes) this.Close();
        }
        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            cbSID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            cbPID.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtQuantity.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            btEdit.Enabled = true;
        }

        private void StockListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            cbSID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            cbPID.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtQuantity.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            btEdit.Enabled = true;
        }

        private void cbSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateStoreName();
        }

        private void cbStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateStoreID();
        }

        private void cbPID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateProductName();
        }

        private void cbProName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateProductID();
        }
    }
}
