using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TiepNhanHocSinh
    {
        public int _MAHS;
        public string _HOTEN;
        public string _DIACHI;
        public string _NGAYSINH;
        public string _GIOITINH;
        public string _TONGIAO;
        public string _DANTOC;
        public string _HOTENCHA;
        public string _NGHENGHIEPCHA;
        public string _HOTENME;
        public string _NGHENGHIEPME;
        public int _NAMHOC;
        public int MAHS
        {
            get
            {
                return _MAHS;
            }

            set
            {
                _MAHS = value;
            }
        }
        public string HOTEN
        {
            get
            {
                return _HOTEN;
            }

            set
            {
                _HOTEN = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return _DIACHI;
            }

            set
            {
                _DIACHI = value;
            }
        }
        public string NGAYSINH
        {
            get
            {
                return _NGAYSINH;
            }

            set
            {
                _NGAYSINH = value;
            }
        }
        public string GIOITINH
        {
            get
            {
                return _GIOITINH;
            }

            set
            {
                _GIOITINH = value;
            }
        }
        public string TONGIAO
        {
            get
            {
                return _TONGIAO;
            }

            set
            {
                _TONGIAO = value;
            }
        }
        public string DANTOC
        {
            get
            {
                return _DANTOC;
            }

            set
            {
                _DANTOC = value;
            }
        }
        public string HOTENCHA
        {
            get
            {
                return _HOTENCHA;
            }

            set
            {
                _HOTENCHA = value;
            }
        }
        public string NGHENGHIEPCHA
        {
            get
            {
                return _NGHENGHIEPCHA;
            }

            set
            {
                _NGHENGHIEPCHA = value;
            }
        }
        public string HOTENME
        {
            get
            {
                return _HOTENME;
            }

            set
            {
                _HOTENME = value;
            }
        }
        public string NGHENGHIEPME
        {
            get
            {
                return _NGHENGHIEPME;
            }

            set
            {
                _NGHENGHIEPME = value;
            }
        }
        public int MANAMHOC
        {
            get
            {
                return _NAMHOC;
            }

            set
            {
                _NAMHOC = value;
            }
        }
        public DTO_TiepNhanHocSinh()
        {

        }
        public DTO_TiepNhanHocSinh(int mahs, string hoten, string diachi, string ngaysinh, string gioitinh, string tongiao, string dantoc, string hotencha, string nghenghiepcha, string hotenme, string nghenghiepme, int manamhoc)
        {
            this.MAHS = mahs;
            this.HOTEN = hoten;
            this.DIACHI = diachi;
            this.NGAYSINH = ngaysinh;
            this.GIOITINH = gioitinh;
            this.TONGIAO = tongiao;
            this.DANTOC = dantoc;
            this.HOTENCHA = hotencha;
            this.NGHENGHIEPCHA = nghenghiepcha;
            this.HOTENME = hotenme;
            this.NGHENGHIEPME = nghenghiepme;
            this.MANAMHOC = manamhoc;
        }
    }
}
