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
    public partial class DistrictListForm : Form
    {
        public DistrictListForm()
        {
            InitializeComponent();
        }
        SalesDataContextDataContext db = null;
        private void MySetProvince()
        {
            db = new SalesDataContextDataContext();
            var ProvQ = from ProvList in db.provinces select ProvList.province_name;
            foreach (string ProvName in ProvQ)
            {
                cbProv.Items.Add(ProvName);
            }
            cbProv.SelectedIndex = 0;
        }
        private void MySetDistrict()
        {
            var DistQ = from DistList in db.districts
                        join ProvList in db.provinces on DistList.province_id equals
                        ProvList.province_id
                        where (ProvList.province_name == cbProv.Text)
                        select DistList;
            dtGridView.DataSource = DistQ;
        }

        private void cbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySetDistrict();
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
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            district DistQ = db.districts.Single(x => x.district_id == tempDID);
            DistQ.district_id = txtDID.Text;
            DistQ.district_name = txtDName.Text;
            DistQ.province_id = txtPID.Text;
            db.SubmitChanges();
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtDID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtDName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtPID.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempDID = dtGridView.Rows[r].Cells[0].Value.ToString();
            district DistQ = db.districts.Single(x => x.district_id == tempDID);
            db.districts.DeleteOnSubmit(DistQ);
            db.SubmitChanges();
            MySetDistrict();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            db.districts.InsertOnSubmit(new district
            {
                district_id = txtDID.Text,
                district_name = txtDName.Text,
                province_id = txtPID.Text
            });
            db.SubmitChanges();
            MySetDistrict();
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            MySetProvince();
        }

        private void btCommune_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommuneListForm cm = new CommuneListForm();
            cm.ShowDialog();
            this.Show();
        }

        private void DistrictListForm_Load(object sender, EventArgs e)
        {
            MySetProvince();
        }
    }
}
