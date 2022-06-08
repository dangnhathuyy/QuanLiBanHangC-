using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace sqlclient2
{
    public class nhacc
    {
        public static DataTable select_nhacc()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NHA_CC", cls_ketnoi.kn_qlbh);
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
    }
}
