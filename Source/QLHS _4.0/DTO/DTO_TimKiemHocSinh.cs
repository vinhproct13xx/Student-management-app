using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TimKiemHocSinh
    {
        public string _TenCot;
        public string _TenTimKiem;
        public string TenCot
        {
            get
            {
                return _TenCot;
            }

            set
            {
                _TenCot = value;
            }
        }
        public string TenTimKiem
        {
            get
            {
                return _TenTimKiem;
            }

            set
            {
                _TenTimKiem = value;
            }
        }
        public DTO_TimKiemHocSinh(string tencot, string tentimkiem)
        {
            this.TenCot = tencot;
            this.TenTimKiem = tentimkiem;
        }
    }
   
}
