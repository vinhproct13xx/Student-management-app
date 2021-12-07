using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DTB
    { 
        public int _MaHS;
        public int _MaLop;
        public int _MaMH;
        public int _MaNH;
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

        public DTO_DTB() { }
        public DTO_DTB(int mahs, int malop, int mahk, int namhoc, int monhoc)
        {
            this.MaHS = mahs;
            this.MaLop = malop;
            this.MaNH = namhoc;
            this.MaMH = monhoc;
        }
    }
}
