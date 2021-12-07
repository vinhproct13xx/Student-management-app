using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;



namespace DAL
{
    public class DAL_LopHoc : DBConnect
    {
     
        public List<DTO_LopHoc> getListDTO_LopHoc()
        {
            List<DTO_LopHoc> listDTO_LopHoc = new List<DTO_LopHoc>();

            SqlDataAdapter da = new SqlDataAdapter("select malop, tenlop from lophoc", _conn);
            DataTable dtLopHoc = new DataTable();
            da.Fill(dtLopHoc);
            foreach(DataRow item in dtLopHoc.Rows)
            {
                DTO_LopHoc dtoLopHoc = new DTO_LopHoc(item);
                listDTO_LopHoc.Add(dtoLopHoc);
            }
            return listDTO_LopHoc;
        }
        public void AddClass(int SoLop, int Makhoi)
        {
            int malop;
            int ChiSoLop;//chỉ số vd 10a5 chỉ số =5
            string Max = "select max(malop) from lophoc where makhoi = " + Makhoi;

            _conn.Open();
            SqlCommand cmdMaLop = new SqlCommand(Max, _conn);
            malop = (int)cmdMaLop.ExecuteScalar();
            _conn.Close();
            ChiSoLop = malop % 10;
            for (int i = 0; i < SoLop; i++)
            {
                malop++;
                ChiSoLop++;
                string sql = string.Format("insert into LOPHOC(malop, tenlop, makhoi) values ({0}, '{1}a{2}', {3})", malop, Makhoi, ChiSoLop, Makhoi);
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }

        }
        public int CountClass(int MaKhoi)
        {
            int count;
            string sql = "select count(malop) from lophoc where makhoi = " + MaKhoi;
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            count = (int)cmd.ExecuteScalar();
            _conn.Close();
            return count;
        }
    }
}
