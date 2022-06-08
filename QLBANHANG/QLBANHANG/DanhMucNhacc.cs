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
    public partial class DanhMucNhacc : Form
    {
        public DanhMucNhacc()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void buoc_dtg()
        {
            dtg_showNcc.DataSource = nhacc.select_nhacc();
        }
        private void DanhMucNhacc_Load(object sender, EventArgs e)
        {
            buoc_dtg();
        }

        private void dtg_showNcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
