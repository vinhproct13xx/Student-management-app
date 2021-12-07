using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_ChuyenLop
    {
        DAL_ChuyenLop dschuyenlop = new DAL_ChuyenLop();
        public void ChuyenLop(int mahs, int oldmalop, int oldmanh, int malop, int manh)
        {
            dschuyenlop.ChuyenLop(mahs, oldmalop, oldmanh, malop, manh);
        }
        public DataTable getDSLop(int MaNH, int MaLop)
        {
            return dschuyenlop.getDanhSachLopCoSan(MaNH, MaLop);
        }
        public void insertdataDTBMon(int mahs, int oldMaLop, int OldMaNH, int MaLop, int MaNH, int MaMH)
        {
            dschuyenlop.insertdata(mahs, oldMaLop, OldMaNH, MaLop, MaNH, MaMH);
        }
        public void updateDTBChung(int mahs, int oldMaLop, int OldMaNH, int MaLop, int MaNH)
        {
            dschuyenlop.updateDiemTBChung(mahs, oldMaLop, OldMaNH, MaLop, MaNH);
        }
        public bool CheckSiSo(int SiSo, int malop, int manh)
        {
            return dschuyenlop.CheckSiSo(SiSo, malop, manh);
        }
    }
}
