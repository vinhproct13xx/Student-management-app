using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;



namespace BUS
{
    public class BUS_TaoLop
    {
        DAL_TaoLop dsLop = new DAL_TaoLop();
        DAL_TaoLop dsLopCoSan = new DAL_TaoLop();

        public DataTable getDSLop()
        {
            return dsLop.getDanhSachLop();
        }
        public DataTable getLopHocCoSan(int NamHoc, int Lop)
        {
            return dsLopCoSan.getDanhSachLopCoSan(NamHoc, Lop);
        }
        public bool CheckSiSo(int SiSo, int malop, int manh)
        {
            return dsLop.CheckSiSo(SiSo, malop, manh);
        }
        public void ChuyenLop(int mahs, int malop, int manh)
        {
            dsLop.ChuyenLop(mahs, malop, manh);
        }
        public void InsertDataDiemTBMon(int manh, int malop, int mamh, int mahs)
        {
            dsLop.InsertData(manh, malop, mamh, mahs);
        }
        public void InsertDiemTBChung(int manh, int malop, int mahs)
        {
            dsLop.InsertDiemTBChung(manh, malop, mahs);
        }
        public void InsertBaoCaoChung(int manh,int malop)
        {
            dsLop.InsertBaoCaoChung(manh, malop);
        }
        public void InsertBaoCao(int manh,int malop, int mamh)
        {
            dsLop.InsertBaoCao(manh, malop, mamh);
        }
    }
}
