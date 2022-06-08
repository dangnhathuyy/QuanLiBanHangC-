using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace sqlclient2
{
    public class cls_ketnoi
    {
        public static SqlConnection kn_qlbh = new SqlConnection(@"Server=DESKTOP-DB40KO8;Database=QLBH;Integrated security = True");

    }
}
