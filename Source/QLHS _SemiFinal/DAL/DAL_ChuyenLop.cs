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
    public class DAL_ChuyenLop : DBConnect
    {
        public void ChuyenLop(int MaHS, int OldMaLop, int OldMaNH, int MaLop, int MaNH)
        {
            if (OldMaNH == MaNH)
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
                }
                catch (Exception e)
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
        public void insertdata(int MaHS, int OldMaLop, int OldMaNH, int MaLop, int MaNH, int MaMH)
        {
            if (OldMaNH == MaNH)
            {
                try
                {
                    string insertdata = "update DIEMTBMON set MALOP = " + MaLop + " where MAHS = " + MaHS + " and MANH = " + MaNH;
                    MessageBox.Show(insertdata);
                    _conn.Open();
                    SqlCommand insertDTBMon = new SqlCommand(insertdata, _conn);
                    insertDTBMon.ExecuteNonQuery();
                    _conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Không thêm được vào csdl dtb");
                }
            }
            else
            {
                try
                {
                    string insertdata = "insert DIEMTBMON values (" + MaNH + ", " + MaLop + ", " + MaMH + " , " + MaHS + ", NULL, NULL, NULL)";
                    MessageBox.Show(insertdata);
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(insertdata, _conn);
                    cmd.ExecuteNonQuery(); ;
                    _conn.Close();

                }
                catch (Exception e)
                {
                }
            }

        }
        public void updateDiemTBChung(int MaHS, int OldMaLop, int OldMaNH, int MaLop, int MaNH)
        {
            if (OldMaNH == MaNH)
            {
                try
                {
                    string insertdata = "update DIEMTBCHUNG set MALOP = " + MaLop + " where MAHS = " + MaHS + " and MANH = " + MaNH;
                    MessageBox.Show(insertdata);
                    _conn.Open();
                    SqlCommand insertDTBChung = new SqlCommand(insertdata, _conn);
                    insertDTBChung.ExecuteNonQuery();
                    _conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Không thêm được vào csdl dtbCHUNG");
                }
            }
            else
            {
                try
                {
                    string insertdata = "insert DIEMTBCHUNG values (" + MaNH + ", " + MaLop + ", " + MaHS + ", NULL, NULL, NULL)";
                    MessageBox.Show(insertdata);
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand(insertdata, _conn);
                    cmd.ExecuteNonQuery(); ;
                    _conn.Close();

                }
                catch (Exception e)
                {
                }
            }

        }
        //public void updateBaoCaoChung(int OldMaLop, int OldMaNH, int MaLop, int MaNH)
        //{
        //    if (OldMaNH == MaNH)
        //    {
        //        try
        //        {
        //            string insertdata = "update BAOCAOCHUNG set MALOP = " + MaLop + " where MANH = " + MaNH;
        //            MessageBox.Show(insertdata);
        //            _conn.Open();
        //            SqlCommand insertBaoCaoChung = new SqlCommand(insertdata, _conn);
        //            insertBaoCaoChung.ExecuteNonQuery();
        //            _conn.Close();
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("Không thêm được vào csdl baocaochung");
        //        }
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string insertdata = "insert BAOCAOCHUNG values (" + MaNH + ", " + MaLop + ", NULL, NULL, NULL)";
        //            MessageBox.Show(insertdata);
        //            _conn.Open();
        //            SqlCommand cmd = new SqlCommand(insertdata, _conn);
        //            cmd.ExecuteNonQuery(); ;
        //            _conn.Close();

        //        }
        //        catch (Exception e)
        //        {
        //        }
        //    }

        //}
        //public void updateBaoCao(int OldMaLop, int OldMaNH, int MaLop, int MaNH, int MaMH)
        //{
        //    if (OldMaNH == MaNH)
        //    {
        //        try
        //        {
        //            string insertdata = "update BAOCAO set MALOP = " + MaLop + " where MANH = " + MaNH;
        //            MessageBox.Show(insertdata);
        //            _conn.Open();
        //            SqlCommand insertBaoCao = new SqlCommand(insertdata, _conn);
        //            insertBaoCao.ExecuteNonQuery();
        //            _conn.Close();
        //        }
        //        catch (Exception e)
        //        {
        //        }
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string insertdata = "insert BAOCAO values (" + MaNH + ", " + MaLop + ", " + MaMH + ", NULL, NULL, NULL)";
        //            MessageBox.Show(insertdata);
        //            _conn.Open();
        //            SqlCommand cmd = new SqlCommand(insertdata, _conn);
        //            cmd.ExecuteNonQuery(); ;
        //            _conn.Close();

        //        }
        //        catch (Exception e)
        //        {
        //        }
        //    }

        //}
    }
}
