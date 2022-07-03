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
    public partial class BrandListForm : Form
    {
        public BrandListForm()
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
        SqlDataAdapter adBrand = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtBrand = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            txtBrID.ResetText();
            txtBrName.ResetText();
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
                adBrand = new SqlDataAdapter("SELECT * FROM brands", conn);
                dtBrand = new DataTable();
                adBrand.Fill(dtBrand);
                dtGridView.DataSource = dtBrand;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng brands", "Lỗi dữ liệu!");
            }
        }
        void CheckBrandNameExit()
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
                cmd.CommandText = "SELECT Count(*) FROM brands WHERE brand_name = '" +
                    txtBrName.Text + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("Brand Name (" + txtBrName.Text.Trim() + ") đã có. Nhập lại!");
                    txtBrName.ResetText();
                    txtBrName.Focus();
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
        private void Brand_Load(object sender, EventArgs e)
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
            //
            txtBrID.Text = (tmp++).ToString();
            // Đưa con trỏ đến đầu TextBox Stores ID
            txtBrName.Focus();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtGridView_CellClick(null, null);
            SetBtEdit_On();
            txtBrName.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
            if (!txtBrName.Text.Trim().Equals(""))
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
                        cmd.CommandText = "INSERT INTO brands VALUES('" + txtBrName.Text + "')";
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
                        string strBrandID = dtGridView.Rows[r].Cells[0].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE brands SET " + "brand_name='" + txtBrName.Text +
                    "'WHERE brand_id = '" + strBrandID + "'";
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
                txtBrID.Focus();
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

                    string BrandID = dtGridView.Rows[r].Cells[0].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM brands WHERE brand_id='" + BrandID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();
                    
                    // Cập nhật lại dữ liệu trên DataGridVie
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công Brand ID = " + BrandID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Brand hiện hành.");
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

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtBrID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtBrName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            btEdit.Enabled = true;
        }
        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtBrID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtBrName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            btEdit.Enabled = true;
        }

        private void txtBrName_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckBrandNameExit();
            }
        }
    }
}
