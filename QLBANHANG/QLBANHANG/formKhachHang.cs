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
    public partial class formKhachHang : Form
    {
        SqlConnection kn_qlbh = new SqlConnection(@"Server=DESKTOP-DB40KO8; Database=QLBH;Integrated Security = True");
        public formKhachHang()
        {
            InitializeComponent();
        }
        public void buoc_makh()
        {
            txt_makh.Text = "KH" + Convert.ToInt32(cls_khachhang.select_KH().Rows.Count + 1);
        }
        private void bt_showkh_Click(object sender, EventArgs e)
        {
            FormDanhmucKH f = new FormDanhmucKH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {
            buoc_makh();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            cls_khachhang.select_kh(txt_makh.Text, txt_tenkh.Text, txt_phone.Text, txt_tp.Text, txt_dc.Text);
            MessageBox.Show("lưu thành công");
            txt_tenkh.Text = "";
            txt_phone.Text = "";
            txt_tp.Text = "";
            txt_dc.Text = "";
            buoc_makh();
        }
    }
}
