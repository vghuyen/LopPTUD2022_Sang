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
    public partial class frmLTCB : Form
    {
        int i, n, T; 
        public frmLTCB()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            lblKQ.Text = "Kết quả tính theo While là: " + Convert.ToString(T);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            do
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            while (i <= n);
            lblKQ.Text = "Kết quả tính bằng Do While là: " + Convert.ToString(T);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            for (i=1; i<=n;i++)
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
            }
            lblKQ.Text = "Kết quả tính theo For là: " + Convert.ToString(T);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
