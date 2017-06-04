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
    class NhanVienMH
    {

        KCSDL conn = new KCSDL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from nhanvien";
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
        public bool AddData(NhanVienDT dt)
        {
            cmd.CommandText = "INSERT INTO nhanvien VALUES ( '" + dt.Manv + "', N'" + dt.Tennv + "', N'" + dt.Diachi + "', CONVERT ('" + dt.Ngaysinh + "', 103), '" + dt.Gioitinh+ "', '" + dt.Dienthoai + "', '" + dt.Matkhau + "' )";
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
        public bool UpdateData(NhanVienDT dt)
        {
            cmd.CommandText = "UPDATE nhanvien SET TenNV= N'" + dt.Tennv + "', DiaChi= N'" + dt.Diachi + "', NgaySinh= CONVERT ('" + dt.Ngaysinh + "', 103), GioiTinh= '" + dt.Gioitinh + "', DienThoai= '" + dt.Dienthoai + "', MatKhau=  '" + dt.Matkhau + "'  WHERE MaNV = '" + dt.Manv + "' ";
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
            cmd.CommandText = "Delete nhanvien  WHERE MaNV ='" + Ma + "'";
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
