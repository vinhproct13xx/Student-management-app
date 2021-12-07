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
    public class DAL_LopHoc : DAL_DBConnect
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
    }
}
