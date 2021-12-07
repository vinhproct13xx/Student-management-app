using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TongKet
    {
        public int _MaNH;
        public int _MaMH;
        public int MaNH
        {
            get { return _MaNH; }
            set { _MaNH = value; }
        }
        public int MaMH
        {
            get { return _MaMH; }
            set { _MaMH = value; }
        }
        public DTO_TongKet() { }
        public DTO_TongKet(int manh, int mamh)
        {
            this.MaNH = manh;
            this.MaMH = mamh;
        }
    }
}
