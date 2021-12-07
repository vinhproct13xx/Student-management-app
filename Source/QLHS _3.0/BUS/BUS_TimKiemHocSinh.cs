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
    public class BUS_TimKiemHocSinh
    {
        DAL_TimKiemHocSinh dalTimKiem = new DAL_TimKiemHocSinh();
        public DataTable TimKiemHocSinh(DTO_TimKiemHocSinh tk)
        {
            return dalTimKiem.TimKiemHocSinh(tk);
        }
        public  bool checkTimKiem(DTO_TimKiemHocSinh tk)
        {
            DataTable dt = dalTimKiem.TimKiemHocSinh(tk);
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        public DataTable getHocSinh()
        {
            return dalTimKiem.getHocSinh();
        }
    }
    
}
