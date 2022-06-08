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
    public partial class Form2 : Form
    {
        SqlConnection kn_qlbh = new SqlConnection(@"Server=DESKTOP-DB40KO8; Database=QLBH;Integrated Security = True");
        public Form2()
        {
            InitializeComponent();
        }
        public void buoc_dtgHH()
        {
            dtg_hanghoa.DataSource = hanghoa.Select_HH();
        }
        public void buoc_sopx()
        {
            txt_sopx.Text = "PX" + Convert.ToInt32(cls_PX.select_PX().Rows.Count + 1);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            buoc_dtgHH();
            buoc_cboKH();
            buoc_cbonv();
            buoc_sopx();
        }

        public void buoc_cboKH()
        {
            this.cb_kh.DataSource = cls_khachhang.select_KH();
            this.cb_kh.DisplayMember = "TenKHG";
            this.cb_kh.ValueMember = "TenKHG";
            cb_kh.SelectedIndex = -1;
        }
        public void buoc_cbonv()
        {
            this.cb_nv.DataSource = cls_nhanvien.Select_NV();
            this.cb_nv.DisplayMember = "TenNV";
            this.cb_nv.ValueMember = "TenNV";
            cb_nv.SelectedIndex = -1;
        }
        public void them()
        {
            string mahang = dtg_hanghoa.CurrentRow.Cells[0].Value.ToString();
            string tenhang = dtg_hanghoa.CurrentRow.Cells[1].Value.ToString();
            int sl = Convert.ToInt32(numericUpDown3.Value);
            int gianhap = Convert.ToInt32(dtg_hanghoa.CurrentRow.Cells[2].Value.ToString());
            int thanhtien = gianhap * sl;

            if (sl > 0 && hongcothem(mahang))
            {
                dtg_ctpx.Rows.Add(mahang, tenhang, gianhap, sl, thanhtien);
                MessageBox.Show("Dữ liệu đã được thêm");
            }
            else if (!hongcothem(mahang))
                MessageBox.Show("Không ổn rùi, tớ đã thêm rồi mà");
            else
            {
                MessageBox.Show("Số lượng phải lớn hơn '0'");
            }
            tong_tienhang();
        }
        public bool hongcothem(string th)
        {
            bool flag = true;
            for (int i = 0; i < dtg_ctpx.Rows.Count - 1; i++)
            {
                if (th == dtg_ctpx.Rows[i].Cells["MAHANG"].Value.ToString())
                    flag = false;
            }
            return flag;
        }
        public void tong_tienhang()
        {
            long tienhang = 0;
            long thue = 0;
            long chietkhau;
            long tongcong = 0;
            for (int i = 0; i < this.dtg_ctpx.RowCount - 1; i++)
            {
                tienhang += Convert.ToInt32(this.dtg_ctpx.Rows[i].Cells["THANHTIEN"].Value.ToString());
            }
            this.txt_tienhang.Text = tienhang.ToString();
            thue = Convert.ToInt64(numericUpDown1.Value * tienhang / 100);
            this.txt_thue.Text = thue.ToString();
            chietkhau = Convert.ToInt64(numericUpDown2.Value / 100 * thue);
            this.txt_chietkhau.Text = chietkhau.ToString();
            tongcong = tienhang + thue - chietkhau;
            this.txt_tongcong.Text = tongcong.ToString();
        }
        private void bt_themkh_Click(object sender, EventArgs e)
        {
            formKhachHang f = new formKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            int sl_moi = Convert.ToInt32(numericUpDown3.Value);

            int sl_cu = Convert.ToInt32(dtg_hanghoa.CurrentRow.Cells[3].Value);
            if (sl_moi > sl_cu)
            {
                MessageBox.Show("khong du");
            }
            else
            {
                them();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tong_tienhang();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tong_tienhang();
        }

        private void txt_tienhang_TextChanged(object sender, EventArgs e)
        {
            tong_tienhang();
        }

        private void bt_themsp_Click(object sender, EventArgs e)
        {
            THEMSP t = new THEMSP();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void bt_taomoi_Click(object sender, EventArgs e)
        {
            buoc_sopx();
            buoc_cboKH();
            dtp_ngaypx.Text = "";
            cb_kh.Text = "";
            txt_timkiem.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            rd_timma.Checked = true;
            checkBox1.Checked = false;
            buoc_dtgHH();
            dtg_ctpx.Rows.Clear();
        }
        public void luu()
        {
            long ttl = Convert.ToInt64(txt_tongcong.Text);
            cls_PX.insert_PX(txt_sopx.Text, dtp_ngaypx.Text, Convert.ToString(cb_kh.SelectedValue), ttl);
            for (int i = 0; i < dtg_ctpx.Rows.Count; i++)
            {
                string mahh = Convert.ToString(dtg_ctpx.Rows[i].Cells[0].Value);
                int soluong = Convert.ToInt32(dtg_ctpx.Rows[i].Cells[3].Value);
                long dongia = Convert.ToInt64(dtg_ctpx.Rows[i].Cells[2].Value);
                cls_CTPX.Insert_px(txt_sopx.Text, mahh, soluong, dongia);
            }
            try
            {
                MessageBox.Show("Thêm thành công vào hai bảng CTPN và Phiếu Nhập");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
           


             

            if (cb_nv.Text == "")
            {
                MessageBox.Show("Cần chọn nhân viên tạo phiếu", "Thông báo");
            }
            else
            {
                luu();
            }
        }
        private void txt_sopx_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtg_hanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
