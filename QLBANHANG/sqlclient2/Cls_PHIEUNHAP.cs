using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace sqlclient2
{
    public class Cls_PHIEUNHAP
    {
        public static DataTable select_PN()
        {
            DataTable dt = new DataTable();
            cls_ketnoi.kn_qlbh.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEU_NHAP", cls_ketnoi.kn_qlbh);
            da.Fill(dt);
            cls_ketnoi.kn_qlbh.Close();
            return dt;
        }
        public static bool insert_PN(string sopn, string ngaypn,string mancc, long sotienphaitra)
        {
            bool rs = false;
            cls_ketnoi.kn_qlbh.Open();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO PHIEU_NHAP(SoPN, NgayPN, MaNCC,SoTienPhaiTra, SoTieDaTra) VALUES('{0}', '{1}', '{2}', '{3}', 0)", sopn,ngaypn,mancc,sotienphaitra),cls_ketnoi.kn_qlbh);
            cmd.ExecuteNonQuery();
            cls_ketnoi.kn_qlbh.Close();
            return rs;
        }
    }
}
