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
    public partial class Form1 : Form
    {
        SqlConnection kn_qlbhang = new SqlConnection(@"Server=DESKTOP-DB40KO8; Database=QLBH;Integrated Security = True");
        //SqlDataAdapter da;
        //DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        public void buocdl_dtghanghoa()
        {
            this.dtg_hanghoa.DataSource = hanghoa.Select_HH();
        }
        public void buoc_cbNCC()
        {
            this.cb_ncc.DataSource = nhacc.select_nhacc();
            this.cb_ncc.DisplayMember = "TenNCC";
            this.cb_ncc.ValueMember = "TenNCC";
            cb_ncc.SelectedIndex = -1;
        }
        public void buoc_cbonv()
        {
            this.cb_nv.DataSource = cls_nhanvien.Select_NV();
            this.cb_nv.DisplayMember = "TenNV";
            this.cb_nv.ValueMember = "TenNV";
            cb_nv.SelectedIndex = -1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buocdl_dtghanghoa();
            buoc_cbonv();
            buoc_cbNCC();
            buoc_sopn();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cb_nv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void buoc_sopn()
        {
            txt_sopn.Text = "PN" + Convert.ToInt32(insertCTPN.select_ctpn().Rows.Count + 1);
        }
        private void bt_tim_Click(object sender, EventArgs e)
        {
            if(rd_timma.Checked == true)
                dtg_hanghoa.DataSource = clsTimKiem.timkiem(txt_timkiem.Text);
            else if(rd_timten.Checked == true) 
                dtg_hanghoa.DataSource = clsTimKiem.timkiemtheoten(txt_timkiem.Text);
            else if(checkBox1.Checked == true)
            dtg_hanghoa.DataSource = clsTimKiem.timkiemtheoten(txt_timkiem.Text);
        }
        private void bt_themsp_Click(object sender, EventArgs e)
        {
            THEMSP t = new THEMSP();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }
        private void dtg_hanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void them()
        {
            string mahang = dtg_hanghoa.CurrentRow.Cells[0].Value.ToString();
            string tenhang = dtg_hanghoa.CurrentRow.Cells[1].Value.ToString();
            int sl = Convert.ToInt32(numericUpDown3 .Value);
            int gianhap = Convert.ToInt32(dtg_hanghoa.CurrentRow.Cells[2].Value.ToString());
            int thanhtien = gianhap * sl;

            if (sl > 0 && hongcothem(mahang))
            {
                dtg_ctpn.Rows.Add(mahang,tenhang, gianhap, sl, thanhtien);
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
        private void bt_them_Click(object sender, EventArgs e)
        {
            them();
        }
        public bool hongcothem(string th)
        {
            bool flag = true;
            for(int i = 0; i < dtg_ctpn.Rows.Count - 1; i++)
            {
                if (th == dtg_ctpn.Rows[i].Cells["MAHANG"].Value.ToString()) 
                    flag = false;
            }
            return flag;
        }
        public void tong_tienhang()
        {
            long tienhang = 0;
            long thue = 0 ;
            long chietkhau;
            long tongcong = 0;
            for (int i = 0; i < this.dtg_ctpn.RowCount - 1; i++)
            {
                tienhang += Convert.ToInt32(this.dtg_ctpn.Rows[i].Cells["THANHTIEN"].Value.ToString());
            }
            this.txt_tienhang.Text = tienhang.ToString();
            thue = Convert.ToInt64(numericUpDown1.Value * tienhang / 100);
            this.txt_thue.Text = thue.ToString();
            chietkhau = Convert.ToInt64(numericUpDown2.Value / 100 * thue);
            this.txt_chietkhau.Text = chietkhau.ToString();
            tongcong = tienhang+ thue - chietkhau;
            this.txt_tongcong.Text = tongcong.ToString();
        }
        private void bt_themncc_Click(object sender, EventArgs e)
        {
            Nhacungcap n = new Nhacungcap();
            this.Hide();
            n.ShowDialog();
            this.Show();
        }

        private void dtg_ctpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_tienhang_TextChanged(object sender, EventArgs e)
        {
            tong_tienhang();
        }

        private void txt_sopn_TextChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tong_tienhang();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tong_tienhang();
        }

        private void bt_taomoi_Click(object sender, EventArgs e)
        {
            buoc_sopn();
            buoc_cbNCC();
            dtp_ngaypn.Text = "";
            cb_ncc.Text = "";
            txt_timkiem.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            rd_timma.Checked = true;
            checkBox1.Checked = false;
            buocdl_dtghanghoa();
            dtg_ctpn.Rows.Clear();
        }
        public void luu()
        {
            long ttl = Convert.ToInt64(txt_tongcong.Text);
            Cls_PHIEUNHAP.insert_PN(txt_sopn.Text, dtp_ngaypn.Text, Convert.ToString(cb_ncc.SelectedValue), ttl);
            for (int i = 0; i < dtg_ctpn.Rows.Count; i++)
            {
                string mahh = Convert.ToString(dtg_ctpn.Rows[i].Cells[0].Value);
                int soluong = Convert.ToInt32(dtg_ctpn.Rows[i].Cells[2].Value);
                long dongia = Convert.ToInt64(dtg_ctpn.Rows[i].Cells[3].Value);
                insertCTPN.Insert(txt_sopn.Text, mahh, soluong, dongia);
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

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
