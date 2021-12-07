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
    public class BUS_TongKet
    {
        DAL_TongKet da = new DAL_TongKet();
        public DataTable getTongKetMon(DTO_TongKet tk)
        {
            return da.getTongKetMon(tk);
        }
        public DataTable getTongKetChung(DTO_TongKet tk)
        {
            return da.getTongKetChung(tk);
        }
        public void updateTongKet()
        {
            da.updateTongKet();
        }
        public void updateTongKetChung()
        {
            da.updateTongKetChung();
        }
    }
}
