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
    public class BUS_DTB
    {
        DAL_DTB da = new DAL_DTB();
        public DataTable getDTB(DTO_DTB dtb)
        {
            return da.getDTB(dtb);
        }

        public void updateDTB()
        {
            da.updateDTB();
        }
        public DataTable getDTBChung(DTO_DTB dtb)
        {
            return da.getDTBChung(dtb);
        }
    }
}
