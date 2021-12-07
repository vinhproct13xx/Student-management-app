using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_DangNhap : DBConnect
    {
        public DataTable sosanhUsernamePassword(DTO_DangNhap dn)
        {      
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NGUOIDUNG WHERE TenDN='" + dn.NGUOIDUNG + "' AND PASS='" + dn.NGUOIDUNG + "'", _conn);
            DataTable dtcheckUsernamePassword = new DataTable();
            da.Fill(dtcheckUsernamePassword);
            da.Dispose();
            return dtcheckUsernamePassword;
        }
    }
}
