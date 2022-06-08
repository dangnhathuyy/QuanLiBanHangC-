using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace sqlclient2
{
    public class cls_khachhang
    {
        public static DataTable select_KH()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KHACH_HANG", cls_ketnoi.kn_qlbh);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cls_ketnoi.kn_qlbh.Close();
            }
            return dt;
        }
        public static DataTable select_kh(string makh, string tenkh, string dc, string dt, string tp)
        {
            DataTable dt1 = new DataTable();
            string str = String.Format("insert into KHACH_HANG(MaKHG,TenKHG,DiaChiKHG,DienThoaiKHG,TinhTP) VALUES ('{0}',N'{1}',N'{2}','{3}',N'{4}')", makh, tenkh, dc, dt, tp);
            SqlDataAdapter da = new SqlDataAdapter(str, cls_ketnoi.kn_qlbh);
            da.Fill(dt1);
            return dt1;
        }
    }
}
