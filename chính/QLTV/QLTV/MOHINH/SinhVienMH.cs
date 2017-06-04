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
    class SinhVienMH
    {
        KCSDL conn = new KCSDL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from sinhvien";
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
        public bool AddData(SinhVienDT dt)
        {
            cmd.CommandText = "INSERT INTO loaisach VALUES ( '" + dt.Mathe + "', N'" + dt.Tensv + "', CONVERT ( '" + dt.Ngaysinh + "', 103), N'" + dt.Diachi + "', N'" + dt.Lop + "', N'" + dt.Khoa + "', CONVERT ('" + dt.Ngaycapthe + "', 103), CONVERT (N'" + dt.Ngayhethan + "', 103), N'" + dt.Gioitinh + "') ";
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
        public bool UpdateData(SinhVienDT dt)
        {
            cmd.CommandText = "UPDATE sinhvien SET TenSV= N'" + dt.Tensv + "', NgaySinh= CONVERT ( '" + dt.Ngaysinh + "', 103), N'" + dt.Diachi + "',Lop= N'" + dt.Lop + "', Khoa= N'" + dt.Khoa + "', NgayCapThe= CONVERT ('" + dt.Ngaycapthe + "', 103),NgayHetHan= CONVERT (N'" + dt.Ngayhethan + "', 103), gioitinh= N'" + dt.Gioitinh + "' WHERE MaThe ='" + dt.Mathe + "'";
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
            cmd.CommandText = "Delete sinhvien  WHERE MaThe ='" + Ma + "'";
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
