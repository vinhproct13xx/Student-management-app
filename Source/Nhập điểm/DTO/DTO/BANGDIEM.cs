using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BANGDIEM
    {
        public int _MAHS;
        public string _MALOP;
        public int _MAHK;
        public string _MAMONHOC;
        public int _MANAMHOC;
        public float _KTM1;
        public float _KTM2;
        public float _KTM3;
        public float _KTM4;
        public float _KTM5;
        public float _KT15P1;
        public float _KT15P2;
        public float _KT15P3;
        public float _KT15P4;
        public float _KT15P5;
        public float _KT15P6;
        public float _KT1T1;
        public float _KT1T2;
        public float _KT1T3;
        public float _KT1T4;
        public float _KT1T5;
        public float _KT1T6;
        public float _DIEMTHI;
        public float _DIEMTB;

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

        public string MALOP
        {
            get
            {
                return _MALOP;
            }

            set
            {
                _MALOP = value;
            }
        }

        public int MAHK
        {
            get
            {
                return _MAHK;
            }

            set
            {
                _MAHK = value;
            }
        }

        public string MAMONHOC
        {
            get
            {
                return _MAMONHOC;
            }

            set
            {
                _MAMONHOC = value;
            }
        }

        public int MANAMHOC
        {
            get
            {
                return _MANAMHOC;
            }

            set
            {
                _MANAMHOC = value;
            }
        }

        public float KTM1
        {
            get
            {
                return _KTM1;
            }

            set
            {
                _KTM1 = value;
            }
        }

        public float KTM2
        {
            get
            {
                return _KTM2;
            }

            set
            {
                _KTM2 = value;
            }
        }

        public float KTM3
        {
            get
            {
                return _KTM3;
            }

            set
            {
                _KTM3 = value;
            }
        }

        public float KTM4
        {
            get
            {
                return _KTM4;
            }

            set
            {
                _KTM4 = value;
            }
        }

        public float KTM5
        {
            get
            {
                return _KTM5;
            }

            set
            {
                _KTM5 = value;
            }
        }

        public float KT15P1
        {
            get
            {
                return _KT15P1;
            }

            set
            {
                _KT15P1 = value;
            }
        }

        public float KT15P2
        {
            get
            {
                return _KT15P2;
            }

            set
            {
                _KT15P2 = value;
            }
        }

        public float KT15P3
        {
            get
            {
                return _KT15P3;
            }

            set
            {
                _KT15P3 = value;
            }
        }

        public float KT15P4
        {
            get
            {
                return _KT15P4;
            }

            set
            {
                _KT15P4 = value;
            }
        }

        public float KT15P5
        {
            get
            {
                return _KT15P5;
            }

            set
            {
                _KT15P5 = value;
            }
        }

        public float KT15P6
        {
            get
            {
                return _KT15P6;
            }

            set
            {
                _KT15P6 = value;
            }
        }

        public float KT1T1
        {
            get
            {
                return _KT1T1;
            }

            set
            {
                _KT1T1 = value;
            }
        }

        public float KT1T2
        {
            get
            {
                return _KT1T2;
            }

            set
            {
                _KT1T2 = value;
            }
        }

        public float KT1T3
        {
            get
            {
                return _KT1T3;
            }

            set
            {
                _KT1T3 = value;
            }
        }

        public float KT1T4
        {
            get
            {
                return _KT1T4;
            }

            set
            {
                _KT1T4 = value;
            }
        }

        public float KT1T5
        {
            get
            {
                return _KT1T5;
            }

            set
            {
                _KT1T5 = value;
            }
        }

        public float KT1T6
        {
            get
            {
                return _KT1T6;
            }

            set
            {
                _KT1T6 = value;
            }
        }
        
        public float DIEMTB
        {
            get
            {
                return _DIEMTB;
            }

            set
            {
                _DIEMTB = value;
            }
        }

        public float DIEMTHI
        {
            get
            {
                return _DIEMTHI;
            }

            set
            {
                _DIEMTHI = value;
            }
        }
        public BANGDIEM(int mahs, string malop, int mahk, int namhoc, string monhoc, int diemtb, int ktm1, int ktm2, int ktm3, int ktm4, int ktm5, int kt15p1, int kt15p2, int kt15p3, int kt15p4, int kt15p5, int kt15p6, int kt1t1, int kt1t2, int kt1t3, int kt1t4, int kt1t5, int kt1t6, int diemthi)
        {
            this.MAHS = mahs;
            this.MALOP = malop;
            this.MAHK = mahk;
            this.MANAMHOC = namhoc;
            this.MAMONHOC = monhoc;
            this.DIEMTB = diemtb;
            this.KTM1 = ktm1;
            this.KTM2 = ktm2;
            this.KTM3 = ktm3;
            this.KTM4 = ktm4;
            this.KTM5 = ktm5;
            this.KT15P1 = kt15p1;
            this.KT15P2 = kt15p2;
            this.KT15P3 = kt15p3;
            this.KT15P4 = kt15p4;
            this.KT15P5 = kt15p5;
            this.KT15P6 = kt15p6;
            this.KT1T1 = kt1t1;
            this.KT1T2 = kt1t2;
            this.KT1T3 = kt1t3;
            this.KT1T4 = kt1t4;
            this.KT1T5 = kt1t5;
            this.KT1T6 = kt1t6;
            this.DIEMTHI = diemthi;
        }
    }
}
