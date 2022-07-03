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
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
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
        SqlDataAdapter adCate = null;
        //Đối tượng hiển thị dữ liệu trên Form
        DataTable dtCate = null;
        //Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Add = false;
        //Phương thức dùng chung
        void ResetAllTextBox()
        {
            txtCaID.ResetText();
            txtCaName.ResetText();
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
                adCate = new SqlDataAdapter("SELECT * FROM categories", conn);
                dtCate = new DataTable();
                adCate.Fill(dtCate);
                dtGridView.DataSource = dtCate;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối lấy được dữ liệu từ bảng categories", "Lỗi dữ liệu!");
            }
        }
        void CheckCateIDExit()
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
                cmd.CommandText = "SELECT Count(*) FROM categories WHERE category_id = '" +
                    txtCaID.Text + "'";
                int nCount;
                nCount = Int32.Parse(cmd.ExecuteScalar().ToString());
                if (nCount > 0)
                {
                    MessageBox.Show("CategoryID (" + txtCaID.Text.Trim() + ") đã có. Nhập lại!");
                    txtCaID.ResetText();
                    txtCaID.Focus();
                }
                else
                {
                    txtCaName.Focus();
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
        private void Category_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            tmp = dtGridView.Rows.Count;
            // Kich hoạt biến Them
            Add = true;
            // Xóa trống các đối tượng trong Panel
            ResetAllTextBox();
            // Kích hoạt chế độ nhập/sửa dữ liệu
            SetBtEdit_On();
            // Đưa con trỏ đến đầu TextBox Stores ID
            txtCaID.Text = (tmp++).ToString();
            txtCaName.Focus();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            dtGridView_CellClick(null, null);
            SetBtEdit_On();
            txtCaName.Focus();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!txtCaID.Text.Trim().Equals(""))
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
                        cmd.CommandText = "INSERT INTO categories VALUES('"+ txtCaName.Text + "')";
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
                        string strCateID = dtGridView.Rows[r].Cells[0].Value.ToString();
                        //Câu lệnh SQL
                        cmd.CommandText = "UPDATE categories SET " + "category_name='" + txtCaName.Text +
                    "'WHERE category_id = '" + strCateID + "'";
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
                txtCaID.Focus();
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

                    string CateID = dtGridView.Rows[r].Cells[0].Value.ToString();

                    // Lệnh truy vấn SQL

                    cmd.CommandText = "DELETE FROM categories WHERE s=category_id='" + CateID + "'";

                    cmd.CommandType = CommandType.Text;
                    // Thực hiện lệnh truy vấn
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại dữ liệu trên DataGridVie

                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa thành công Category ID = " + CateID + ".");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được Category hiện hành.");
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
            txtCaID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtCaName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            btEdit.Enabled = true;
        }
        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy Row hiện tại
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtCaID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtCaName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            btEdit.Enabled = true;
        }

        private void txtCaID_Leave(object sender, EventArgs e)
        {
            if (Add)
            {
                CheckCateIDExit();
            }
        }
    }
}
