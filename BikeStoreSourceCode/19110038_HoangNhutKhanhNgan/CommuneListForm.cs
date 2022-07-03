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
    public partial class CommuneListForm : Form
    {
        public CommuneListForm()
        {
            InitializeComponent();
        }
        SalesDataContextDataContext db = null;
        private void MySetDistrict()
        {
            db = new SalesDataContextDataContext();
            var DistQ = from DistList in db.districts select DistList.district_name;
            foreach (string DistName in DistQ)
            {
                cbDis.Items.Add(DistName);
            }
            cbDis.SelectedIndex = 0;
        }
        private void MySetCommune()
        {
            var CommQ = from CommList in db.communes
                        join DistList in db.districts on CommList.district_id equals
                        DistList.district_id
                        where (DistList.district_name == cbDis.Text)
                        //select CommList.commune_id with CommList.commune_name with CommList.degree && CommList.district_id;
                        select CommList;
            dtGridView.DataSource = CommQ;
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
            string tempCID = dtGridView.Rows[r].Cells[0].Value.ToString();
            commune CommQ = db.communes.Single(x => x.commune_id == tempCID);
            CommQ.commune_id = txtCID.Text;
            CommQ.commune_name = txtCName.Text;
            CommQ.degree = Int32.Parse((txtDegree.Text).ToString());
            CommQ.district_id = txtCID.Text;
            db.SubmitChanges();
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtCID.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtCName.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtDegree.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtCID.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int r = dtGridView.CurrentCell.RowIndex;
            string tempCID = dtGridView.Rows[r].Cells[0].Value.ToString();
            commune CommQ = db.communes.Single(x => x.commune_id == tempCID);
            db.communes.DeleteOnSubmit(CommQ);
            db.SubmitChanges();
            MySetDistrict();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            db.communes.InsertOnSubmit(new commune
            {
                commune_id = txtCID.Text,
                commune_name = txtCName.Text,
                degree = Int32.Parse(txtDegree.Text.ToString()),
                district_id = txtCID.Text
            });
            db.SubmitChanges();
            MySetDistrict();
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            MySetDistrict();
        }

        private void cbDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySetCommune();
        }
        private void CommuneListForm_Load(object sender, EventArgs e)
        {
            MySetDistrict();
        }
    }
}
