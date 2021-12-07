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
    public class BUS_TiepNhanHocSinh
    {
        DAL_TiepNhanHocSinh dalHocSinh = new DAL_TiepNhanHocSinh();

        public DataTable getHocSinh()
        {
            return dalHocSinh.getHocSinh();
        }

        public bool themHocSinh(DTO_TiepNhanHocSinh hs)
        {
            return dalHocSinh.themHocSinh(hs);
        }

        public bool suaHocSinh(DTO_TiepNhanHocSinh hs)
        {
            return dalHocSinh.suaHocSinh(hs);
        }

        public bool xoaHocSinh(int MAHS, int MANAMHOC)
        {
            return dalHocSinh.xoaHocSinh(MAHS,MANAMHOC);
        }
    }
}
