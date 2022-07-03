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
    public partial class ProvinceListForm : Form
    {
        public ProvinceListForm()
        {
            InitializeComponent();
        }
        SalesDataContextDataContext db = null;
        private void MySetProvince()
        {
            db = new SalesDataContextDataContext();
            var ProvQ = from ProvinceList in db.provinces
                        select ProvinceList;

            dtGridView.DataSource = ProvQ;
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

        private void btSave_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempPID = dtGridView.Rows[r].Cells[0].Value.ToString();
            province ProQ = db.provinces.Single(x => x.province_id == tempPID);
            ProQ.province_id = txtPID.Text;
            ProQ.province_name = txtPName.Text;
            db.SubmitChanges();
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtPID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtPName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempPID = dtGridView.Rows[r].Cells[0].Value.ToString();
            province ProvQ = db.provinces.Single(x => x.province_id == tempPID);
            db.provinces.DeleteOnSubmit(ProvQ);
            db.SubmitChanges();
            MySetProvince();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            db.provinces.InsertOnSubmit(new province
            {
                province_id = txtPID.Text,
                province_name = txtPName.Text
            });
            db.SubmitChanges();
            MySetProvince();
        }

        private void btDistrict_Click(object sender, EventArgs e)
        {
            this.Hide();
            DistrictListForm dt = new DistrictListForm();
            dt.ShowDialog();
            this.Show();
        }

        private void ProvinceListForm_Load(object sender, EventArgs e)
        {
            MySetProvince();
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            MySetProvince();
        }
    }
}
