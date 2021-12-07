using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
   public class BUS_NhapDiem
    {
       DAL_NhapDiem da = new DAL_NhapDiem();
        public DataTable getBangDiem(DTO_BangDiem A)
        {
            return da.getBangDiem(A);
        }


        public void CapNhatDiem(DTO_BangDiem A)
        {   

            da.CapNhatDiem(A);
        }

    }
}
