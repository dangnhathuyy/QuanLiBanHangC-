using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace sqlclient2
{
    public class cls_PX
    {
        public static DataTable select_PX()
        {
            DataTable dt = new DataTable();
            cls_ketnoi.kn_qlbh.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEU_XUAT", cls_ketnoi.kn_qlbh);
            da.Fill(dt);
            cls_ketnoi.kn_qlbh.Close();
            return dt;
        }
        public static bool insert_PX(string sopx, string ngaypx, string makh, long sotienphaitra)
        {
            bool rs = false;
            cls_ketnoi.kn_qlbh.Open();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO PHIEU_XUAT(SOPX, NgayPX, MaKHG,SoTienPhaiTra, SoTienDaTra)  VALUES('{0}', '{1}', '{2}', '{3}', 0)", sopx, ngaypx, makh, sotienphaitra), cls_ketnoi.kn_qlbh);
            cmd.ExecuteNonQuery();
            cls_ketnoi.kn_qlbh.Close();
            return rs;
        }
    }
}
