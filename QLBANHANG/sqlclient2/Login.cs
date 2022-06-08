using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace sqlclient2
{
    public class Login
    {
        private static Login instances;
        public static Login Instances
        {
            get { if (instances == null) instances = new Login(); return instances; }
            private set { instances = value; }
        }
        public bool Login_hh(string userName, string passWord)
        {
            string query =  "select * from TAI_KHOAN where Username = '" + userName + "' and Password = '" + passWord + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cls_ketnoi.kn_qlbh);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count > 0;
        }
    }
}
