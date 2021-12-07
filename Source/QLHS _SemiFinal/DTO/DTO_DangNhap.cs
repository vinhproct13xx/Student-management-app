using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        public string _NGUOIDUNG;
        public string _PASS;
        public string NGUOIDUNG
        {
            get
            {
                return _NGUOIDUNG;
            }
            set
            {
                _NGUOIDUNG = value;
            }
        }
        public string PASS
        {
            get
            {
                return _PASS;
            }
            set
            {
                _PASS = value;
            }
        }
        public DTO_DangNhap(string nguoidung, string pass)
        {
            this.NGUOIDUNG = nguoidung;
            this.PASS = pass;
        }
    }
}
