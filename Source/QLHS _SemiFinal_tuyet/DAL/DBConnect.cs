using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        public SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-OOGJF5J\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True");
    }
}
