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
    public partial class Nhacungcap : Form
    {
        SqlConnection kn_qlbh =new SqlConnection(@"Server=DESKTOP-DB40KO8; Database=QLBH;Integrated Security = True");
        public Nhacungcap()
        {
            InitializeComponent();
        }
        public void buoc_manhacc()
        {
            txt_mancc.Text = "NCC" + Convert.ToInt32(nhacc.select_nhacc().Rows.Count + 1);
        }
        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            buoc_manhacc();
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            DanhMucNhacc d = new DanhMucNhacc();
            this.Hide();
            d.ShowDialog();
            this.Close();

        }
        
        private void bt_luu_Click(object sender, EventArgs e)
        {
            insertNhacc.select_ncc(txt_mancc.Text, txt_tenncc.Text, txt_phone.Text, txt_address.Text);
            MessageBox.Show("lưu thành công");
            txt_tenncc.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            buoc_manhacc();
        }
    }
}
