using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_HANHKIEM
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=USER;Initial Catalog=TestHanhKiem;Integrated Security=True");
        public SqlDataAdapter da;
        public SqlCommandBuilder sqlComd;
        public DataSet dtBangHanhKiem;

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

        public DataTable getBangDiem(String MaLop, String MaHocKy)
        {

            try
            {
                conn.Open();
                dtBangHanhKiem = new DataSet();
                string str = DateTime.Now.ToString().Trim();
                string sql = "select HSHS.MAHS as 'Mã Học Sinh' , HSHS.HOTEN as 'Họ Tên', HANHKIEM as 'Hạnh Kiểm'  from HANHKIEM , HSHS   where HSHS.MAHS = HANHKIEM.MAHS and MALOP = '" + MaLop + "' and MAHK = " + MaHocKy + " and HANHKIEM.MANAMHOC = " + str.Substring(6, 4);
                //Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                using (cmd)
                {
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dtBangHanhKiem);
                }
                return dtBangHanhKiem.Tables[0];
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


        public void CapNhatDiem(string HANHKIEM, string MAHS, string MALOP, string HOCKY)
        {
            try
            {
                conn.Open();
                //sqlComd = new SqlCommandBuilder(da);
                //da.UpdateCommand = sqlComd.GetUpdateCommand();
                //da.Update(dtBangHanhKiem.Tables[0]);
                string str = DateTime.Now.ToString().Trim();
                string sqlcmd = "UPDATE HANHKIEM SET HANHKIEM = N'" + HANHKIEM + "' where  MAHS = " + MAHS + " and MALOP= '" + MALOP + "' and MANAMHOC =" + str.Substring(6, 4) + " and MAHK =" + HOCKY ;
                SqlCommand sqlCom = new SqlCommand(sqlcmd, conn);
                int i = sqlCom.ExecuteNonQuery();
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
