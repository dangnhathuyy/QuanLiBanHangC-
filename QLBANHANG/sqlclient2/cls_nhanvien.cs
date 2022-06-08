using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace sqlclient2
{
    public class cls_nhanvien
    {
        public static DataTable Select_NV()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select TenNV from NHAN_VIEN", cls_ketnoi.kn_qlbh);
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
