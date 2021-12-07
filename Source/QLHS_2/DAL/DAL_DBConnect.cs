using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DBConnect
    {
            public SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-OOGJF5J\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True");
    }
}
