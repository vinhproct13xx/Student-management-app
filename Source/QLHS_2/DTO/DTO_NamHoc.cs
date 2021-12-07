using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NamHoc
    {
        int _MaNH;
        string _TenNH;
        public int MaNH
        {
            get { return _MaNH; }
            set { _MaNH = value; }
        }
        public string TenNH
        {
            get { return _TenNH; }
            set { _TenNH = value; }
        }
        public DTO_NamHoc(DataRow row)
        {
            this._MaNH = (int)row["manh"];
            this._TenNH = row["tennh"].ToString();
        }
        public DTO_NamHoc() { }
    }
}
