using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sqlclient2
{
    public class cls_CTPT
    {
        public static DataTable select_CT()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PHIEU_THU", cls_ketnoi.kn_qlbh);
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
        public static bool Insert_px(string sopx, string ngpx , decimal stpt, decimal stdt, decimal stcl)
        {
            bool rs = true;
            SqlCommand CMD = new SqlCommand();
            try
            {
                cls_ketnoi.kn_qlbh.Open();
                string strCMD = string.Format("insert into PHIEU_THU(SOPX, NgayPX, SoTienPhaiTra, SoTienDaTra,SoTienConLai) values('{0}', '{1}', {2}, {3},{4})", sopx, ngpx, stpt,stdt,stcl);
                CMD = new SqlCommand(strCMD, cls_ketnoi.kn_qlbh);
                CMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                rs = false;
            }
            finally
            {
                cls_ketnoi.kn_qlbh.Close();
                CMD.Dispose();
            }
            return rs;

        }
        public static bool Insert_pt(string soct, string ngayct, decimal sotien, string diengiai, string sopx)
        {
            bool rs = true;
            SqlCommand CMD = new SqlCommand();
            try
            {
                cls_ketnoi.kn_qlbh.Open();
                string strCMD = string.Format("insert into PHIEU_THU(soct, NGAYCT, sotien, diengiai,sopx) values('{0}', '{1}', {2}, '{3}','{4}')", soct, ngayct, sotien, diengiai, sopx);
                CMD = new SqlCommand(strCMD, cls_ketnoi.kn_qlbh);
                rs = CMD.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                rs = false;
            }
            finally
            {
                cls_ketnoi.kn_qlbh.Close();
                CMD.Dispose();
            }
            return rs;

        }
    }
}
