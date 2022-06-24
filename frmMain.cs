using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopPTUD2022_Sang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status1.Text = "Hello World!";
            Form f = new Form1();
            f.ShowDialog();
            Status1.Text = "Sẵn sàng nhận lệnh";
        }

        private void tínhTổngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmLTCB();
            f.Show();
        }

        private void máyTínhCầmTayToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Status2.Text = System.DateTime.Now.ToString();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();
        }
    }
}
