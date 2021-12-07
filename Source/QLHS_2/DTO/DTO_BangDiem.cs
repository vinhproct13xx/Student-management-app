using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BangDiem
    {

        public int _MaHS;
        public int _MaLop;
        public int _MaHK;
        public int _MaMH;
        public int _MaNH;
        public float _Diem;
        public int _HeSo;
        public int _LanKiemTra;
        public string _HinhThucKiemTra;


        public int MaHS
        {
            get
            {
                return _MaHS;
            }

            set
            {
                _MaHS = value;
            }
        }

        public int MaLop
        {
            get
            {
                return _MaLop;
            }

            set
            {
                _MaLop = value;
            }
        }

        public int MaHK
        {
            get
            {
                return _MaHK;
            }

            set
            {
                _MaHK = value;
            }
        }

        public int MaMH
        {
            get
            {
                return _MaMH;
            }

            set
            {
                _MaMH = value;
            }
        }

        public int MaNH
        {
            get
            {
                return _MaNH;
            }

            set
            {
                _MaNH = value;
            }
        }

        public float Diem
        {
            get
            {
                return _Diem;
            }

            set
            {
                _Diem = value;
            }
        }
        public string HinhThucKiemTra
        {
            get { return _HinhThucKiemTra; }
            set { _HinhThucKiemTra = value; }
        }
        public int LanKiemTra
        {
            get { return _LanKiemTra; }
            set { _LanKiemTra = value; }
        }
        public int HeSo
        {
            get { return _HeSo; }
            set { _HeSo = value; }
        }
        public DTO_BangDiem() { }
            public DTO_BangDiem(int mahs, int malop, int mahk, int namhoc, int monhoc, int diem, int heso, int lankiemtra, string hinhthuckiemtra)
            {
                this.MaHS = mahs;
                this.MaLop = malop;
                this.MaHK = mahk;
                this.MaNH = namhoc;
                this.MaMH = monhoc;
                this.Diem = diem;
            this.HinhThucKiemTra = hinhthuckiemtra;
            this.LanKiemTra = lankiemtra;
            this.HeSo = heso;
        }
        }
    
}
