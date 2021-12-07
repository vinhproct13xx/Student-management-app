using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;

namespace DAL
{
    public class DAL_TimKiemHocSinh : DBConnect
    {
        public DataTable TimKiemHocSinh(DTO_TimKiemHocSinh tk)
        {
            //if (tk.tencot == "MAHS")
            //{
            //    int a = Convert.ToInt32(tk.tencot);
            //    int b = Convert.ToInt32(tk.tentimkiem);
            //    SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM LOAINGUOIDUNG WHERE TenDNhap='" + a + "' like '%" + b + "%'", _conn);
            //    DataTable dtTimKiemHocSinh = new DataTable();
            //    da1.Fill(dtTimKiemHocSinh);
            //    da1.Dispose();
            //    return dtTimKiemHocSinh;
            //}
            //else
            //{
            if (tk.TenCot == "NGAYSINH")
            {
                int a = Convert.ToInt32(tk.TenTimKiem);
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM HOCSINH WHERE day(NGAYSINH) = " + a + "", _conn);
                DataTable dtTimKiemHocSinh = new DataTable();
                da2.Fill(dtTimKiemHocSinh);
                da2.Dispose();
                return dtTimKiemHocSinh;
            }
            else if (tk.TenCot == "THANGSINH")
            {
                int a = Convert.ToInt32(tk.TenTimKiem);
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM HOCSINH WHERE month(NGAYSINH) = " + a + "", _conn);
                DataTable dtTimKiemHocSinh = new DataTable();
                da2.Fill(dtTimKiemHocSinh);
                da2.Dispose();
                return dtTimKiemHocSinh;
            }
            else if (tk.TenCot == "NAMSINH")
            {
                int a = Convert.ToInt32(tk.TenTimKiem);
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM HOCSINH WHERE year(NGAYSINH) = " + a + "", _conn);
                DataTable dtTimKiemHocSinh = new DataTable();
                da2.Fill(dtTimKiemHocSinh);
                da2.Dispose();
                return dtTimKiemHocSinh;
            }
            else if (tk.TenCot == "NGAYTHANGNAMSINH")
            {
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM HOCSINH WHERE NGAYSINH = '" + tk.TenTimKiem + "'", _conn);
                DataTable dtTimKiemHocSinh = new DataTable();
                da2.Fill(dtTimKiemHocSinh);
                da2.Dispose();
                return dtTimKiemHocSinh;
            }
            else
            {
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM HOCSINH WHERE " + tk.TenCot + " like N'%" + tk.TenTimKiem + "%'", _conn);
                DataTable dtTimKiemHocSinh = new DataTable();
                da2.Fill(dtTimKiemHocSinh);
                da2.Dispose();
                return dtTimKiemHocSinh;
            }
        }
        public DataTable getHocSinh()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOCSINH order by MAHS desc", _conn);
            DataTable dtHocSinh = new DataTable();
            da.Fill(dtHocSinh);
            return dtHocSinh;
        }
    }
}
