using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTabProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProfileForm().ShowDialog();
            this.Close();
        }

        private void btnTabShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShopForm().ShowDialog();
            this.Close();
        }

        private void btnTabHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TransactionHistoryForm().ShowDialog();
            this.Close();
        }

        private void btnTabPointHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PointHistoryForm().ShowDialog();
            this.Close();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CartForm().ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
