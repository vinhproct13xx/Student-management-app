using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_NhapDiem : DBConnect
    {
        public SqlCommandBuilder sqlComd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();       
        //DataTable dtBangDiem = new DataTable();

        public DataTable getBangDiem(DTO_BangDiem A)
        {
            dt.Clear();
            //List<int> dsHocSinh = new List<int>();
            //dsHocSinh = InsertDanhSach(A); 
            try
            {
                string sqlSelectCoSan = "select HOCSINH.MAHS, HOCSINH.HOTEN, BANGDIEM.DIEM   from BANGDIEM , HOCSINH   where HOCSINH.MAHS = BANGDIEM.MAHS and BANGDIEM.MALOP = " + A.MaLop + " and BANGDIEM.MAHK = " + A.MaHK + " and BANGDIEM.MANH= " + A.MaNH + " and BANGDIEM.HESO = " + A.HeSo + " and BANGDIEM.LANKIEMTRA = " + A.LanKiemTra+ " and BANGDIEM.MAMH = " + A.MaMH + " and BANGDIEM.HINHTHUCKIEMTRA = '" + A.HinhThucKiemTra +"'";    
                string sqlSelectChuaCo = string.Format("select mahs, hoten from hocsinh where mahs  in  (select mahs from chitietlop where malop = " + A.MaLop + "and manh = " + A.MaNH + ")", _conn);
                da = new SqlDataAdapter(sqlSelectCoSan, _conn);           
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    da = new SqlDataAdapter(sqlSelectChuaCo, _conn);
                    da.Fill(dt);
                }
                A.Dem = dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy cơ sở dữ liệu mã lớp");
            }
            return dt;
        }

       
        public void CapNhatDiem(DTO_BangDiem A)
        {    
            try
            {
                string sqlUpdate = "UPDATE BANGDIEM SET DIEM = "+ A.Diem +" where "+"HESO = "+ A.HeSo+ " and LANKIEMTRA =  "+ A.LanKiemTra+" and MAHS = "+  A.MaHS +" and MALOP= "+ A.MaLop +" and MANH ="+ A.MaNH +" and MAHK ="+A.MaHK+" and MAMH ="+A.MaMH+" and HINHTHUCKIEMTRA ='"+A.HinhThucKiemTra+"'";
                string sqlInsert = string.Format("INSERT INTO BANGDIEM VALUES({0},{1},{2},{3},{4},{5},{6},'{7}',{8})",A.MaNH,A.MaLop,A.MaHK,A.MaMH,A.MaHS,A.HeSo,A.LanKiemTra,A.HinhThucKiemTra,A.Diem, _conn);
                _conn.Open();
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, _conn);
                SqlCommand cmdInsert = new SqlCommand(sqlInsert, _conn);
                try
                {
                    cmdInsert.ExecuteNonQuery();
                }
                catch
                {
                    cmdUpdate.ExecuteNonQuery();
                }
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu dữ liệu!");
            }
        }


    }
}


