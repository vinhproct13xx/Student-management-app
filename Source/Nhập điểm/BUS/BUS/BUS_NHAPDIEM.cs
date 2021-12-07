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
    public class BUS_NHAPDIEM
    {
        NHAPDIEM da = new NHAPDIEM();
        public DataTable getBangDiem(String MaLop, String MaHocKy, String Mon)
        {
            return da.getBangDiem(MaLop, MaHocKy, Mon);
        }

        public DataTable getMaLop(String maKhoi)
        {
            return da.getMaLop(maKhoi);

        }

        public void CapNhatDiem()
        {
            da.CapNhatDiem();
        }
    }
}
