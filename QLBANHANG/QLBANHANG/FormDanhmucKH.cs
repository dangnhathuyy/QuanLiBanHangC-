using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlclient2;
namespace QLBANHANG
{
    public partial class FormDanhmucKH : Form
    {
        public FormDanhmucKH()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void buoc_dtgKH()
        {
            dtg_showkh.DataSource = cls_khachhang.select_KH();
        }
        private void dtg_showkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDanhmucKH_Load(object sender, EventArgs e)
        {
            buoc_dtgKH();
        }
    }
}
