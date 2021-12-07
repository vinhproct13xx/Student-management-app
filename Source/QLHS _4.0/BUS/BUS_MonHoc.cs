using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
  public  class BUS_MonHoc
    {
        DAL_MonHoc busMonHoc = new DAL_MonHoc();
        public List<DTO_MonHoc> bgetlistMonHoc()
        {
            return busMonHoc.getListMonHoc();
        }
    }
}
