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
    class NhanVien_Model
    {
        KetNoiDB conn = new KetNoiDB();
        SqlCommand cmd = new SqlCommand();

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select nhanvien.* from nhanvien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
             
            try
            {
                //mo ket noi
                conn.OpenCon();
                //thao tac voi du lieu su dugn dataAdapter, van chuyen du lieu ve
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                conn.CloseCon();
            }

            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//xoa bo phien lam viec, loai khoi bo nho
                conn.CloseCon();
            
            }
            return dt;
        }

        public bool AddData(NhanVien_Object nvObj)
        {

            cmd.CommandText = "INSERT INTO nhanvien values ('" + nvObj.MaNV + "', N'" + nvObj.TenNV + "', N '" + nvObj.Diachi + "', CONVERT(DATE,'" + nvObj.Ngaysinh + "',103),'" + nvObj.Gioitinh + "', '" + nvObj.Dienthoai + "', '" + nvObj.Matkhau + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenCon();
                cmd.ExecuteNonQuery();
                conn.CloseCon();
                return true;
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseCon();
            }
            return false;
        }

        //sua du lieu
        public bool UpdateData(NhanVien_Object nvObj)
        {
            cmd.CommandText = "UPDATE nhanvien SET MaNV= '" + nvObj.MaNV + "',TenNV =  N'" + nvObj.TenNV + "',DiaChi= N '" + nvObj.Diachi + "', NgaySinh=CONVERT(DATE,'" + nvObj.Ngaysinh + "',103), GioiTinh= '" + nvObj.Gioitinh + "', DienThoai='" + nvObj.Dienthoai + "', MatKhau='" + nvObj.Matkhau + "' WHERE MaNV='" + nvObj.MaNV + "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenCon();
                cmd.ExecuteNonQuery();
                conn.CloseCon();
                return true;
            }

            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseCon();

            }
            return false;
        }
         //xoa
         public bool DeleteData(string ma)
        {
            cmd.CommandText="Delete nhanvien WHERE = '"+ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenCon();
                cmd.ExecuteNonQuery();
                conn.CloseCon();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseCon();
            }
            return false;


        }
        
    }

     
}
