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
    public partial class ProductListForm : Form
    {
        public ProductListForm()
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
        SqlDataAdapter adPro = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtPro = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            txtPID.ResetText();
            txtPName.ResetText();
            cbBrID.ResetText();
            cbBrandName.ResetText();
            cbCaID.ResetText();
            cbCateName.ResetText();
            txtModel_year.ResetText();
            txtListPrice.ResetText();
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
                adPro = new SqlDataAdapter("SELECT * FROM products", conn);
                dtPro = new DataTable();
                adPro.Fill(dtPro);
                dtGridView.DataSource = dtPro;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng Product", "Lỗi dữ liệu!");
            }
        }
        void CheckProIDExit()
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
                cmd.CommandText = "SELECT Count(*) FROM products WHERE product_id = '" + txtPID.Text.Trim() + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("Product ID (" + txtPID.Text.Trim() + ") đã có. Nhập  lại!");
                    txtPID.ResetText();
                    txtPID.Focus();
                }
                else
                {
                    txtPName.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu!");
            }

        }
        void CheckProNameExit()
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
                cmd.CommandText = "SELECT Count(*) FROM products WHERE product_name = '" + txtPName.Text.Trim() + "'";

                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("Product name (" + txtPName.Text.Trim() + ") đã có.Nhập lại!");
                    txtPName.ResetText();
                    txtPName.Focus();
                }
                else
                {
                    cbBrID.Focus();
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
        SalesDataContextDataContext db = null;
        private void MySetBrandID()
        {
            db = new SalesDataContextDataContext();
            var BrandQ = from BrandList in db.brands
                         select BrandList.brand_id;
            cbBrID.DataSource = BrandQ;
        }
        private void MyUpdateBrandID()
        {
            db = new SalesDataContextDataContext();
            var BrandQ = from BrandList in db.brands
                        where BrandList.brand_name == cbBrandName.Text
                        select BrandList.brand_id;
            //cbPID.SelectedItem = ProdQ.Where ;
            foreach (var brand_id in BrandQ)
                cbBrID.SelectedItem = brand_id;
        }
        private void MySetBrandName()
        {
            db = new SalesDataContextDataContext();
            var BrandQ = from BrandList in db.brands
                        select BrandList.brand_name;
            cbBrandName.DataSource = BrandQ;
        }
        private void MyUpdateBrandName()
        {
            db = new SalesDataContextDataContext();
            var BrandQ = from BrandList in db.brands
                       where BrandList.brand_id == Int32.Parse(cbBrID.Text)
                       select BrandList.brand_name;
            foreach (var brand_name in BrandQ)
                cbBrandName.SelectedItem = brand_name;
        }
        //
        private void MySetCategoryID()
        {
            db = new SalesDataContextDataContext();
            var CateQ = from CateList in db.categories
                         select CateList.category_id;
            cbCaID.DataSource = CateQ;
        }
        private void MyUpdateCateID()
        {
            db = new SalesDataContextDataContext();
            var CateQ = from CateList in db.categories
                        where CateList.category_name == cbCateName.Text
                        select CateList.category_id;
            foreach (var cate_id in CateQ)
                cbCaID.SelectedItem = cate_id;
        }
        private void MySetCateName()
        {
            db = new SalesDataContextDataContext();
            var CateQ = from CateList in db.categories
                        select CateList.category_name;
            cbCateName.DataSource = CateQ;
        }
        private void MyUpdateCateName()
        {
            db = new SalesDataContextDataContext();
            var CateQ = from CateList in db.categories
                       where CateList.category_id == Int32.Parse(cbCaID.Text)
                       select CateList.category_name;
            foreach (var cate_name in CateQ)
                cbCateName.SelectedItem = cate_name;
        }
        private void Product_Load(object sender, EventArgs e)
        {
            LoadData();
        }

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
            // Đưa con trỏ đến đầu TextBox Stores ID
            txtPID.Text = (tmp++).ToString();
            txtPName.Focus();
            MySetBrandID();
            MySetBrandName();
            MyUpdateBrandName();
            MySetCategoryID();
            MySetCateName();
            MyUpdateCateName();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MySetBrandID();
            MySetBrandName();
            MySetCategoryID();
            MySetCateName();
            MyUpdateCateName();
            MyUpdateBrandName();
            
            Add = false;
            dtGridView_CellClick(null, null);
            SetBtEdit_On();
            txtPID.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!txtPID.Text.Trim().Equals(""))
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
                        cmd.CommandText = "INSERT INTO products VALUES('" + txtPName.Text + "','" + cbBrID.Text + "','" +
                            cbCaID.Text + "'," + Int32.Parse(txtModel_year.Text).ToString() + "," +
                            decimal.Parse(txtListPrice.Text).ToString() + ")";
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
                        string strProID = dtGridView.Rows[r].Cells[0].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE products SET " + "product_name='" + txtPName.Text + "',brand_id ='" +
                    cbBrID.Text + "',category_id ='" + cbCaID.Text
                    + "', model_year=" + Int32.Parse(txtModel_year.Text).ToString() + ",list_price =" +
                    decimal.Parse(txtListPrice.Text).ToString() + "WHERE product_id = '" + strProID + "'";
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
                txtPID.Focus();
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

                    string ProID = dtGridView.Rows[r].Cells[0].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM products WHERE product_id='" + ProID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại dữ liệu trên DataGridVie

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công ProductID =" + ProID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Product hiện hành.");
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
            txtPID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtPName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbBrID.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            cbCaID.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtModel_year.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtListPrice.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            btEdit.Enabled = true;
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtPID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtPName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbBrID.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            cbCaID.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtModel_year.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtListPrice.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            btEdit.Enabled = true;
        }


        private void txtPName_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckProNameExit();
            }
        }

        private void txtPID_Leave(object sender, EventArgs e)
        {
            if (Add)
                CheckProIDExit();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbBrID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateBrandName();
        }

        private void cbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateBrandID();
        }

        private void cbCaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateCateName();
        }

        private void cbCateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyUpdateCateID();
        }
    }
}
