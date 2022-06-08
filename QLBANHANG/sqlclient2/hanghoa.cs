using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sqlclient2
{
    public class hanghoa
    {
        public static DataTable Select_HH()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HANG_HOA", cls_ketnoi.kn_qlbh);
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
        public static DataTable insertdata(string mahh, string tenhh, int sl)
        {
            DataTable dt = new DataTable();
            string str = String.Format("insert into HANG_HOA(MaHH , TenHH, DonGiaHienTai) values( N'{0}', N'{1}', {2})", mahh, tenhh, sl);
            SqlDataAdapter da = new SqlDataAdapter(str, cls_ketnoi.kn_qlbh);
            da.Fill(dt);
            return dt;
        }
    }
}
