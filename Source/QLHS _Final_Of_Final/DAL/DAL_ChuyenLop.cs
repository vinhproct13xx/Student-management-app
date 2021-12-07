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
        public bool CheckSiSo(int SiSo, int MaLop, int MaNH)
        {
            string sql = " select count(mahs) from chitietlop where malop = " + MaLop + " and manh = " + MaNH;
            int i;
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            i = (int)cmd.ExecuteScalar();
            _conn.Close();
            if (i < SiSo)
                return true;
            return false;
        }
        public void insertdata(int MaHS, int OldMaLop, int OldMaNH, int MaLop, int MaNH, int MaMH)
        {
            if (OldMaNH == MaNH)
            {
                try
                {
                    string insertdata = "update DIEMTBMON set MALOP = " + MaLop + " where MAHS = " + MaHS + " and MANH = " + MaNH;
                    string insertBangDiem = "update BANGDIEM set MALOP = " + MaLop + " where MAHS = " + MaHS + " and MANH = " + MaNH;
                    _conn.Open();
                    SqlCommand insertDTBMon = new SqlCommand(insertdata, _conn);
                    SqlCommand cmdBangDiem = new SqlCommand(insertBangDiem, _conn);
                    cmdBangDiem.ExecuteNonQuery();
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
                    string sqlBangDiem = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},1,1,'Mieng',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem2 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},1,1,'Diem15p',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem3 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},1,2,'Diem15p',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem4 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},1,3,'Diem15p',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem5 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},2,1,'Diem1T',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem6 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},2,2,'Diem1T',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem7 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},2,3,'Diem1T',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem8 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},3,1,'DiemThi',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem9 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},1,1,'Mieng',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem10 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},1,1,'Diem15p',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem11 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},1,2,'Diem15p',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem12 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},1,3,'Diem15p',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem13 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},2,1,'Diem1T',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem14 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},2,2,'Diem1T',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem15 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},2,3,'Diem1T',NULL)", MaNH, MaLop, MaMH, MaHS);
                    string sqlBangDiem16 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},3,1,'DiemThi',NULL)", MaNH, MaLop, MaMH, MaHS);
                    _conn.Open();
                    SqlCommand cmdBangDiem = new SqlCommand(sqlBangDiem, _conn);
                    SqlCommand cmdBangDiem2 = new SqlCommand(sqlBangDiem2, _conn);
                    SqlCommand cmdBangDiem3 = new SqlCommand(sqlBangDiem3, _conn);
                    SqlCommand cmdBangDiem4 = new SqlCommand(sqlBangDiem4, _conn);
                    SqlCommand cmdBangDiem5 = new SqlCommand(sqlBangDiem5, _conn);
                    SqlCommand cmdBangDiem6 = new SqlCommand(sqlBangDiem6, _conn);
                    SqlCommand cmdBangDiem7 = new SqlCommand(sqlBangDiem7, _conn);
                    SqlCommand cmdBangDiem8 = new SqlCommand(sqlBangDiem8, _conn);
                    SqlCommand cmdBangDiem9 = new SqlCommand(sqlBangDiem9, _conn);
                    SqlCommand cmdBangDiem10 = new SqlCommand(sqlBangDiem10, _conn);
                    SqlCommand cmdBangDiem11 = new SqlCommand(sqlBangDiem11, _conn);
                    SqlCommand cmdBangDiem12 = new SqlCommand(sqlBangDiem12, _conn);
                    SqlCommand cmdBangDiem13 = new SqlCommand(sqlBangDiem13, _conn);
                    SqlCommand cmdBangDiem14 = new SqlCommand(sqlBangDiem14, _conn);
                    SqlCommand cmdBangDiem15 = new SqlCommand(sqlBangDiem15, _conn);
                    SqlCommand cmdBangDiem16 = new SqlCommand(sqlBangDiem16, _conn);
                    SqlCommand cmd = new SqlCommand(insertdata, _conn);
                    cmd.ExecuteNonQuery();
                    cmdBangDiem.ExecuteNonQuery();
                    cmdBangDiem2.ExecuteNonQuery();
                    cmdBangDiem3.ExecuteNonQuery();
                    cmdBangDiem4.ExecuteNonQuery();
                    cmdBangDiem5.ExecuteNonQuery();
                    cmdBangDiem6.ExecuteNonQuery();
                    cmdBangDiem7.ExecuteNonQuery();
                    cmdBangDiem8.ExecuteNonQuery();
                    cmdBangDiem9.ExecuteNonQuery();
                    cmdBangDiem10.ExecuteNonQuery();
                    cmdBangDiem11.ExecuteNonQuery();
                    cmdBangDiem12.ExecuteNonQuery();
                    cmdBangDiem13.ExecuteNonQuery();
                    cmdBangDiem14.ExecuteNonQuery();
                    cmdBangDiem15.ExecuteNonQuery();
                    cmdBangDiem16.ExecuteNonQuery();
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
                   // MessageBox.Show(insertdata);
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
                   // MessageBox.Show(insertdata);
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
