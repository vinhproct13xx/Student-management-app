using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
namespace DAL
{
    public class DAL_ChuyenLop:DAL_DBConnect
    {
        public void ChuyenLop(int MaHS, int OldMaLop, int OldMaNH, int MaLop, int MaNH)
        {
            if(OldMaNH == MaNH)
            {
                try
                {
                    string sql = "update CHITIETLOP set MALOP = " + MaLop + "where MAHS = " + MaHS;
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.ExecuteNonQuery();
                    _conn.Close();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Chuyển lớp không thành công!");
                }
            }
            else
            {
                try
                {
                    string sql = "insert CHITIETLOP values (" + MaHS + ", " + MaLop + ", " + MaNH + ")";
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, _conn);
                    cmd.ExecuteNonQuery(); ;
                    _conn.Close();

                }catch(Exception e)
                {
                    MessageBox.Show("Chuyển lớp không thành công!");
                }
            }
            
        }


        public DataTable getDanhSachLopCoSan(int NamHoc, int Lop)
        {
            //_conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select mahs, hoten from hocsinh where mahs  in  (select mahs from chitietlop where malop = " + Lop + "and manh = " + NamHoc + ")", _conn);
            DataTable dtDanhSachLopCoSan = new DataTable();
            da.Fill(dtDanhSachLopCoSan);
            //_conn.Close();
            return dtDanhSachLopCoSan;
        }
    }
}
