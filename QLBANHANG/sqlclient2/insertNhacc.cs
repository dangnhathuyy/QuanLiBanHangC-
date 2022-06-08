using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace sqlclient2
{
    public class insertNhacc
    {
        public static DataTable select_ncc(string macc,string tencc, string sdt, string dc)
        {
            DataTable dt = new DataTable();
            string str = String.Format("insert into NHA_CC(MaNCC,TenNCC,DienThoaiNCC,DiaChiNCC) VALUES ('{0}',N'{1}','{2}',N'{3}')", macc, tencc, sdt, dc);
            SqlDataAdapter da = new SqlDataAdapter(str, cls_ketnoi.kn_qlbh);
            da.Fill(dt);
            return dt;
        }
    }
}
