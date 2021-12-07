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
    public class DAL_NamHoc:DBConnect
    {
        public List<DTO_NamHoc> getlistNamHoc()
        {
            List<DTO_NamHoc> listDTO_NamHoc = new List<DTO_NamHoc>();

            SqlDataAdapter da = new SqlDataAdapter("select MANH,TENNH from NAMHOC", _conn);
            DataTable dtNamHoc = new DataTable();
            da.Fill(dtNamHoc);
            foreach (DataRow item in dtNamHoc.Rows)
            {
                DTO_NamHoc dtoNamHoc = new DTO_NamHoc(item);
                listDTO_NamHoc.Add(dtoNamHoc);

            }
            return listDTO_NamHoc;

        }
    }
}
