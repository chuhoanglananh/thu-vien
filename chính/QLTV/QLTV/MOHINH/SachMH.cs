using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLTV.DOITUONG;

namespace QLTV.MOHINH
{
    class SachMH
    {
      
            KCSDL conn = new KCSDL();
            SqlCommand cmd = new SqlCommand();

            public DataTable GetData()
            {
                DataTable dt = new DataTable();
                cmd.CommandText = "select * from sach";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn.Connection;
                try
                {
                    //mở kết nối
                    conn.OpenConn();
                    //thao tác với dữ liệu sử dụng dataAdapter,vận chuyển dl về
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    //đổ dl từ dataAdapter vao dataTable
                    sda.Fill(dt);
                    conn.CloseConn();

                }
                catch (Exception ex)
                {
                    string mex = ex.Message;
                    cmd.Dispose();//xóa bỏ phiên làm việc,loại bỏ ra khỏi hẳn bộ nhớ
                    conn.CloseConn();
                }
                return dt;
            }
            //thêm mới dl
            public bool AddData(SachDT dt)
            {
                cmd.CommandText = "INSERT INTO sach VALUES ( '" + dt.Masach + "',N'" + dt.Tensach + "', N'" + dt.Tacgia + "', '" + dt.Manxb + "', '" + dt.MaLS + "', '" + dt.Namxb + "', '" + dt.Lanxb + "', '" + dt.Soluong + "', N'" + dt.Noidung + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn.Connection;
                try
                {
                    conn.OpenConn();
                    cmd.ExecuteNonQuery();
                    conn.CloseConn();
                    return true;

                }
                catch (Exception ex)
                {
                    string mex = ex.Message;
                    cmd.Dispose();
                    conn.CloseConn();
                }
                return false;
            }
            //SỬA dl
            public bool UpdateData(SachDT dt)
            {
                cmd.CommandText = "UPDATE sach SET TenSach= N'" + dt.Tensach + "', TacGia=  N'" + dt.Tacgia + "', '" + dt.Manxb + "', MaNXB= '" + dt.MaLS + "', MaLS ='" + dt.Namxb + "',NamXB= '" + dt.Lanxb + "',SoLuong= '" + dt.Soluong + "',NoiDung= N'" + dt.Noidung + "'  WHERE MaSach='"+dt.Masach+"' ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn.Connection;
                try
                {
                    conn.OpenConn();
                    cmd.ExecuteNonQuery();
                    conn.CloseConn();
                    return true;
                }
                catch (Exception ex)
                {
                    string mex = ex.Message;
                    cmd.Dispose();
                    conn.CloseConn();
                }
                return false;
            }
            //xóa
            public bool DeleteData(string Ma)
            {
                cmd.CommandText = "Delete sach  WHERE MaSach ='" + Ma + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn.Connection;
                try
                {
                    conn.OpenConn();
                    cmd.ExecuteNonQuery();
                    conn.CloseConn();
                    return true;
                }
                catch (Exception ex)
                {
                    string mex = ex.Message;
                    cmd.Dispose();
                    conn.CloseConn();
                }
                return false;
            }
        }
}

