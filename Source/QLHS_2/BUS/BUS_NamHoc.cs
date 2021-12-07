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
   public class BUS_NamHoc
    {
        DAL_NamHoc busNamHoc = new DAL_NamHoc();
        public List<DTO_NamHoc> bgetListNamHoc()
        {
            return busNamHoc.getlistNamHoc(); 
        }
             
    }
}
