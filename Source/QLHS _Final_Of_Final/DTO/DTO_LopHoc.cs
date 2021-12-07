using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_LopHoc
    {
        public int _Malop;
        public string _TenLop;
        public int _MaKhoi;
        
        public int MaLop
        {
            get { return _Malop; }
            set { _Malop = value; }
        }

        public int MaKhoi
        {
            get { return _MaKhoi; }
            set { _MaKhoi = value; }
        }
        public string TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }
        

       public DTO_LopHoc (int malop, string tenlop, int siso, int manh)
        {
            this._Malop = malop;
            this._TenLop = tenlop;
        }
        public DTO_LopHoc(DataRow row)
        {
            this._Malop = (int)row["malop"];
            this._TenLop = row["tenlop"].ToString();
        }
        public DTO_LopHoc()
        {

        }
        
    }
}
