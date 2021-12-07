using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;

namespace DAL
{
    public class NHAPDIEM
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=USER;Initial Catalog=TestNhapDiem;Integrated Security=True");
        public SqlDataAdapter da;
        public SqlCommandBuilder sqlComd;
        public DataSet dtBangDiem;
        public DataTable getMaLop(String maKhoi)
        {
            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select MALOP from LOP where MALOP like '" + maKhoi + "%' order by MALOP ASC", conn);
                DataTable dtMaLop = new DataTable();
                da1.Fill(dtMaLop);
                return dtMaLop;
            }
            catch (Exception ex)
            {

            }
            return null;
        }


        public DataTable getBangDiem(String MaLop, String MaHocKy, String Mon)
        {

            try
            {
                conn.Open();
                dtBangDiem = new DataSet();
                string str = DateTime.Now.ToString().Trim();
                string sql = "select HSHS.MAHS as 'Mã Học Sinh' , HSHS.HOTEN as 'Họ Tên', KTM1 , KTM2, KTM3, KTM4, KTM5, KT15P1, KT15P2, KT15P3, KT15P4, KT15P5, KT15P6, KT1T1, KT1T2, KT1T3, KT1T4, KT1T5, KT1T6, DIEMTHI, DIEMTB  from BANGDIEM , HSHS   where HSHS.MAHS = BANGDIEM.MAHS and MALOP = '" + MaLop + "' and MAHK = " + MaHocKy + " and MAMONHOC= '" + Mon + "' and BANGDIEM.MANAMHOC = " + str.Substring(6, 4);
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                //dtBangDiem = new DataSet();
                using (cmd)
                {
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dtBangDiem);
                }
                return dtBangDiem.Tables[0];
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            return null;
        }


        public void CapNhatDiem()
        {
            try
            {
                conn.Open();
                sqlComd = new SqlCommandBuilder(da);
                da.Update(dtBangDiem);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
