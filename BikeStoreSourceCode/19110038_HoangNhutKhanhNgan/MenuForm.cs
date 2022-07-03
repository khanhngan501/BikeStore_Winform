using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19110038_HoangNhutKhanhNgan
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        string ID;
        private void storeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoreListForm openStore = new StoreListForm();
            this.Hide();
            openStore.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult CheckExit = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cancel confirm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void staffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffListForm openStaff = new StaffListForm();
            this.Hide();
            openStaff.ShowDialog();
            this.Show();
        }

        private void custommerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListForm openCustomer = new CustomerListForm();
            this.Hide();
            openCustomer.ShowDialog();
            this.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderListForm openOrder = new OrderListForm();
            this.Hide();
            openOrder.ShowDialog();
            this.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryListForm openCategory = new CategoryListForm();
            this.Hide();
            openCategory.ShowDialog();
            this.Show();
        }

        private void brandListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandListForm openBrand = new BrandListForm();
            this.Hide();
            openBrand.ShowDialog();
            this.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm openProduct = new ProductListForm();
            this.Hide();
            openProduct.ShowDialog();
            this.Show();
        }

        private void orderItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_ItemListForm openOrderItem = new Order_ItemListForm();
            this.Hide();
            openOrderItem.ShowDialog();
            this.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockListForm openStock = new StockListForm();
            this.Hide();
            openStock.ShowDialog();
            this.Show();
        }

        private void stateProvinceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinceListForm openProvince = new ProvinceListForm();
            this.Hide();
            openProvince.ShowDialog();
            this.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountForm openaccount = new AccountForm();
            this.Hide();
            openaccount.ShowDialog();
            this.Show();
        }
    }
}
