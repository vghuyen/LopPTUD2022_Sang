using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LopPTUD2022_Sang
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.tblDMHH' table. You can move, or remove it, as needed.
            this.tblDMHHTableAdapter.Fill(this.qLBHDataSet.tblDMHH);
            constr = "Data Source=DESKTOP-SP4JH5O\\SQLEXPRESS2012;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select MaNhom, MaHH, Tenhh, dvt, dgVND, SanXuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            NapCT();
        }
        private void NapCT()
        {
            i = dataGridView1.CurrentRow.Index;
            txtManhom.Text = dataGridView1.Rows[i].Cells["manhom"].Value.ToString();
            txtMahh.Text = dataGridView1.Rows[i].Cells["mahh"].Value.ToString();
            txtTenhh.Text = dataGridView1.Rows[i].Cells["tenhh"].Value.ToString();
            txtdvt.Text = dataGridView1.Rows[i].Cells["dvt"].Value.ToString();
            txtDGvnd.Text = dataGridView1.Rows[i].Cells["dgvnd"].Value.ToString();
            txtsx.Text = dataGridView1.Rows[i].Cells["sanxuat"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();

        }
    }
}
