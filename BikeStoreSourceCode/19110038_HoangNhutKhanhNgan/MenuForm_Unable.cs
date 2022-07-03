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
    public partial class Menu_Unable : Form
    {
        public Menu_Unable()
        {
            InitializeComponent();
        }

        private void SignInRequire()
        {
            DialogResult CheckExit = MessageBox.Show("Không thể thực hiện tùy chọn do chưa đăng nhập!! Bạn có muốn đăng nhập không?", "Unable confirm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckExit == DialogResult.Yes)
            {
                User user = new User();
                this.Hide();
                user.ShowDialog();
                this.Close();
            }
        }

        private void storeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void staffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void custommerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void brandListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void orderItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void stateProvinceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SignInRequire();
        }

        private void đăngNhậpĐãĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.ShowDialog();
            this.Close();
        }
    }
}
