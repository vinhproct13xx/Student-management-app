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
    public class DAL_NhapDiem : DAL_DBConnect
    {
        public SqlCommandBuilder sqlComd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataTable dtBangDiem = new DataTable();



        public DataTable getBangDiem(DTO_BangDiem A)
        {
            List<int> dsHocSinh = new List<int>();
            dsHocSinh = InsertDanhSach(A);
            foreach (int i in dsHocSinh)
            {
                string sql = "insert into BANGDIEM values ( " + A.MaNH + ", " + A.MaLop + " , " + A.MaHK + ", " + A.MaMH +  ", " + i + ", " + A.HeSo + ", " + A.LanKiemTra + ", '" + A.HinhThucKiemTra + "', NULL)";
                MessageBox.Show(sql);
                _conn.Open();
                SqlCommand cmdds = new SqlCommand(sql, _conn);
                cmdds.ExecuteNonQuery();
                _conn.Close();


            }

            try
            {
                string sql = "select HOCSINH.mahs, HOCSINH.HOTEN, BANGDIEM.DIEM   from BANGDIEM , HOCSINH   where HOCSINH.MAHS = BANGDIEM.MAHS and BANGDIEM.MALOP = " + A.MaLop + " and BANGDIEM.MAHK = " + A.MaHK + " and BANGDIEM.MANH= " + A.MaNH + " and BANGDIEM.HESO = " + A.HeSo + " and BANGDIEM.LANKIEMTRA = " + A.LanKiemTra+ " and BANGDIEM.MAMH = " + A.MaMH + " and BANGDIEM.HINHTHUCKIEMTRA = '" + A.HinhThucKiemTra +"'";
                MessageBox.Show(sql);
                da = new SqlDataAdapter(sql, _conn);
                da.Fill(dt);
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
           
                string sqlcmd = "UPDATE BANGDIEM SET DIEM = "+ A.Diem +" where "+"HESO = "+ A.HeSo+ " and LANKIEMTRA =  "+ A.LanKiemTra+" and MAHS = "+  A.MaHS +" and MALOP= "+ A.MaLop +" and MANH ="+ A.MaNH +" and MAHK ="+A.MaHK+" and MAMH ="+A.MaMH;
                //string sqlhocsinh = "select mahs from chitietlop where malop = " + A.MaLop + " manh = " + A.MaNH;

                MessageBox.Show(sqlcmd);
                _conn.Open();
                SqlCommand sqlCom = new SqlCommand(sqlcmd, _conn);
               int i =  sqlCom.ExecuteNonQuery();
                //MessageBox.Show(i.ToString());
                _conn.Close();
                //int i = sqlCom.ExecuteNonQuery();
                //if (i<0) MessageBox.Show("Không thể lưu dữ liệu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu dữ liệu!");
            }
        }
         List<int> InsertDanhSach(DTO_BangDiem A)
        {
            _conn.Open();
            string sql = "select mahs from chitietlop where malop = " + A.MaLop + " and  manh = " + A.MaNH;
            MessageBox.Show(sql);
            SqlDataAdapter d = new SqlDataAdapter(sql, _conn);
            DataTable temp = new DataTable();
            d.Fill(temp);
            _conn.Close();
            List<int> lHocSinh = new List<int>();
            foreach(DataRow item in temp.Rows)
            {
                int i = int.Parse(item[0].ToString());
                lHocSinh.Add(i); 

            }
            return lHocSinh;
        }
    }
}


