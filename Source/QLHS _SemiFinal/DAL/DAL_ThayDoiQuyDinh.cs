using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_ThayDoiQuyDinh:DBConnect
    {
        public DataTable getQuyDinh()
        {
            string sql = "select top 1 * from QUYDINH ";
            SqlDataAdapter dt  = new SqlDataAdapter(sql, _conn);
            DataTable quydinh = new DataTable();
            dt.Fill(quydinh);
            return quydinh;
        }
        public DataTable AddQuyDinh(DTO_ThayDoiQuyDinh dtoQuyDinh)

        {
            string sqlDelete = "delete from QUYDINH";
            string sqlInsert = "insert into QUYDINH values ( " + dtoQuyDinh._TuoiMax + ", " + dtoQuyDinh._TuoiMin + " , " + dtoQuyDinh._SiSo + ", " + dtoQuyDinh._DiemDat + ", " + dtoQuyDinh._DiemMax + "," + dtoQuyDinh._DiemMin + "," + dtoQuyDinh._SLMon +", " + dtoQuyDinh._Lop10 + "," + dtoQuyDinh._Lop11 +","+ dtoQuyDinh._Lop12 +")";
            _conn.Open();

            SqlCommand cmdDelete = new SqlCommand(sqlDelete, _conn);
            cmdDelete.ExecuteNonQuery();
            SqlCommand cmdInsert = new SqlCommand(sqlInsert, _conn);
            cmdInsert.ExecuteNonQuery();
            _conn.Close();
            DataTable dt = new DataTable();
            dt = getQuyDinh();
            return dt;
        }
        
    }
}
