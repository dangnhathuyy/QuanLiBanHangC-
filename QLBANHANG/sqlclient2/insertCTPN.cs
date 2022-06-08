﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace sqlclient2
{
    public class insertCTPN
    {
        public static DataTable select_ctpn()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CTPN", cls_ketnoi.kn_qlbh);
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
        public static bool Insert(string sopn, string mahh, int soluong, long dongia)
        {
            bool rs = true;
            SqlCommand CMD = new SqlCommand();
            try
            {
                cls_ketnoi.kn_qlbh.Open();
                string strCMD = string.Format("insert into CTPN(SOPN, MAHH, SOLUONG, DONGIA) values('{0}', '{1}', '{2}', '{3}')", sopn, mahh, soluong, dongia);
                CMD = new SqlCommand(strCMD, cls_ketnoi.kn_qlbh);
                CMD.ExecuteNonQuery();
            }
            catch(Exception ex)
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
