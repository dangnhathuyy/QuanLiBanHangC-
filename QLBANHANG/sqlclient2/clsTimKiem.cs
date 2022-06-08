using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace sqlclient2
{
    public class clsTimKiem
    {
        public static DataTable timkiem(string txttimkiem)
        {
            DataTable dt = new DataTable();
            string sq = String.Format("select * from HANG_HOA where maHH LIKE '{0}'", txttimkiem.Trim());
            SqlDataAdapter da = new SqlDataAdapter(sq, cls_ketnoi.kn_qlbh);
            da.Fill(dt);
            return dt;

        }
        public static DataTable timkiemtheoten(string txttimkiem)
        {
            DataTable dt = new DataTable();
            string gt = String.Format("select * from HANG_HOA where TenHH LIKE '%{0}%'", txttimkiem.Trim());
            SqlDataAdapter da = new SqlDataAdapter(gt, cls_ketnoi.kn_qlbh);
            da.Fill(dt);
            return dt;

        }
    }
}
