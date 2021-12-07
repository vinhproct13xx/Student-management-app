using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_LopHoc
    {
        DAL_LopHoc busLop = new DAL_LopHoc();
        
       
        public List<DTO_LopHoc> bgetlistLopHoc()
        {
            return busLop.getListDTO_LopHoc();
        }
    }
}
