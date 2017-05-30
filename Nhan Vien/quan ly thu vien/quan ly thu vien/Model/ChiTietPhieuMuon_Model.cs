using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using quan_ly_thu_vien.Objects;

namespace quan_ly_thu_vien.Model
{
    class ChiTietPhieuMuon_Model
    {
        KetNoiDB con = new KetNoiDB();
        SqlCommand cmd = new SqlCommand();
        
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from chitietphieumuon";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenCon();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseCon();
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//xoa bo phien lam viec
                con.CloseCon();

            }
            return dt;
        }
       
        //them data
        public bool AddData(ChiTietPhieuMuon_Ob ctOj)
        {
            cmd.CommandText = "insert into chitietphieumuon values ('"+ctOj.SoPhieuMuon1 + "','"+ctOj.MaSach1 + "',CONVERT(DATE, '"+ctOj.HenTra1+"',103) )";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenCon();
                cmd.ExecuteNonQuery();
                con.CloseCon();
                return true;

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//xoa bo phien lam viec
                con.CloseCon();

            }
            return false;
        }

        public bool UpdateData(ChiTietPhieuMuon_Ob ctOj)
        {
            cmd.CommandText = "Update chitietphieumuon set SoPhieuMuon ='" + ctOj.SoPhieuMuon1 + "', MaSach = '" + ctOj.MaSach1 + "', HenTra = CONVERT(DATE, '" + ctOj.HenTra1 + "',103) where sophieu= '"+ctOj.SoPhieuMuon1+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenCon();
                cmd.ExecuteNonQuery();
                con.CloseCon();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//xoa bo phien lam viec
                con.CloseCon();

            }
            return false;
        }

        public bool DeleteData(String ma)
        {
            cmd.CommandText = "delete chitietphieumuon where sophieu='"+ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenCon();
                cmd.ExecuteNonQuery();
                con.CloseCon();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//xoa bo phien lam viec
                con.CloseCon();

            }
            return false;
        }
    }
}
