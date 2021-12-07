using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonHoc
    {
        public int _MaMH;
        public  string _TenMH;
        public int MaMH
        {
            get { return _MaMH; }
            set { _MaMH = value; }
        }
        public string TenMH
        {
            get { return _TenMH; }
            set { _TenMH = value; }
        }
        public DTO_MonHoc(DataRow row)
        {
            this._MaMH = (int)row["mamh"];
            this._TenMH = row["tenmh"].ToString();
        }
        public DTO_MonHoc() { }
    }
}
