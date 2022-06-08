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
using sqlclient2;

namespace QLBANHANG
{
    public partial class THEMSP : Form
    {
        SqlConnection kn_qlbhang = new SqlConnection(@"Server=DESKTOP-M2L6IER\SQLEXPRESS; Database=QLBH;Integrated Security = True");
        public THEMSP()
        {
            InitializeComponent();
        }
        public void buoc_maHH()
        {
            txt_mahh.Text = "HH" + Convert.ToInt32(hanghoa.Select_HH().Rows.Count + 1);
        }
        public void buoc_dtghh()
        {
            this.dtg_hanghoa.DataSource = hanghoa.Select_HH();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_taomoi_Click(object sender, EventArgs e)
        {
            buoc_maHH();
            txt_tenhh.Clear();
            txt_dongia.Text = "0";
            buoc_dtghh();
        }

        private void THEMSP_Load(object sender, EventArgs e)
        {
            buoc_maHH();
            buoc_dtghh();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txt_dongia.Text);
            dtg_hanghoa.DataSource = hanghoa.insertdata(txt_mahh.Text, txt_tenhh.Text, i);
            buoc_dtghh();
        }
        private void dtg_hanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_mahh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
