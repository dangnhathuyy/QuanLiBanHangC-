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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void DangNhap_Load(object sender, EventArgs e)
        {
         
        }
        bool Login_h1(string userName, string passWord)
        {
            return Login.Instances.Login_hh(userName, passWord);
        }
        private void bt_Account_Click(object sender, EventArgs e)
        {
            string userName = txt_tk.Text;
            string passWord = txt_mk.Text;
            if (Login_h1(userName, passWord))
            {
                //MessageBox.Show("Đăng nhập thành công!","Thông báo");
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu rồi!");
            }
            
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy đăng nhập không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
