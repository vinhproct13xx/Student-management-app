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
   public class DAL_MonHoc:DAL_DBConnect
    {
        List<DTO_MonHoc> listMonHoc = new List<DTO_MonHoc>();
        public List<DTO_MonHoc> getListMonHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from MONHOC", _conn);
            DataTable lMH = new DataTable();
            da.Fill(lMH);
            foreach(DataRow item in lMH.Rows)
            {
                DTO_MonHoc dtoMonHoc = new DTO_MonHoc(item);
                listMonHoc.Add(dtoMonHoc);
            }
            return listMonHoc;
        }
    }
}
