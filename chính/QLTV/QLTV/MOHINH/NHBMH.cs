using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DOITUONG;
using System.Data;
using System.Data.SqlClient;

namespace QLTV.MOHINH
{
    class NHBMH
    {
        KCSDL conn = new KCSDL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NXB";
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
        public bool AddData(NVBDT dt)
        {
            cmd.CommandText = "INSERT INTO NXB VALUES ( '" + dt.Manxb + "',N'" + dt.Tennxb + "', N'" + dt.Diachi + "', N'" + dt.Web + "' )";
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
        public bool UpdateData(NVBDT dt)
        {
            cmd.CommandText = "UPDATE loaisach SET TenNXB= N'" + dt.Tennxb + "', DiaChiNXB= N'" + dt.Diachi + "', Website=  N'" + dt.Web + "' WHERE MaNXB ='" + dt.Manxb + "'";
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
            cmd.CommandText = "Delete NXB  WHERE MaNXB ='" + Ma + "'";
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
