using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThayDoiQuyDinh
    {
        public int _TuoiMax;
        public int _TuoiMin;
        public int _SiSo;
        public int _DiemDat;
        public int _DiemMax;
        public int _DiemMin;
        public int _Lop10;
        public int _Lop11;
        public int _Lop12;

        public int TuoiMax
        {
            get { return _TuoiMax; }
            set { _TuoiMax = value; }
        }

        public int TuoiMin
        {
            get { return _TuoiMin; }
            set { _TuoiMin = value; }
        }
        public int SiSo
        {
            get { return _SiSo; }
            set { _SiSo = value; }
        }
        public int DiemDat
        {
            get { return _DiemDat; }
            set { _DiemDat = value; }
        }
        public int DiemMax
        {
            get { return _DiemMax; }
            set { _DiemMax = value; }
        }
        public int DiemMin
        {
            get { return _DiemMin; }
            set { _DiemMin = value; }
        }
        public int Lop10
        {
            get { return _Lop10; }
            set { _Lop10 = value; }
        }
        public int Lop11
        {
            get { return _Lop11; }
            set { _Lop11 = value; }
        }
        public int Lop12
        {
            get { return _Lop12; }
            set { _Lop12 = value; }
        }
        //DTO_ThayDoiQuyDinh(int tuoimax, int tuoimin, int siso, int diemdat, int diemmax,int diemmin, int slmon)
        //{
        //    _TuoiMax = tuoimax;
        //    _TuoiMin = tuoimin;
        //    _SiSo = siso;
        //    _DiemDat = diemdat;
        //    _DiemMax = diemmax;
        //    _DiemMin = diemmin;
        //    _SLMon = slmon; 
        //}
    }
}
