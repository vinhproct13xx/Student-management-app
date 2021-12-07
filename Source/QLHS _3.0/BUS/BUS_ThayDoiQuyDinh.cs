using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
namespace BUS
{
    public class BUS_ThayDoiQuyDinh
    {
        DAL_ThayDoiQuyDinh dalQuyDinh = new DAL_ThayDoiQuyDinh();
        public DataTable getQuyDinh()
        {
            return dalQuyDinh.getQuyDinh();
        }      
        public DataTable AddQuyDinh(DTO_ThayDoiQuyDinh dtoQuyDinh)
        {
            return dalQuyDinh.AddQuyDinh(dtoQuyDinh);
        }  
        
    }
}
