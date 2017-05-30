using System;
using quan_ly_thu_vien.Objects;
using System.Data;
using System.Data.SqlClient;
namespace quan_ly_thu_vien.Model

{
    class SinhVien_Model
    {
        KetNoiDB con = new KetNoiDB();
        
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from sinhvien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenCon();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseCon();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//xoa bo phien lam viec
                con.CloseCon();

            }
            return dt;
        }

        //them data
        public bool AddData(SinhVien_Obh svObj)
        {
            cmd.CommandText = "insert into sinhvien values ('" + svObj.Mathe + "',N'" + svObj.TenSV + "',CONVERT(DATE, '" + svObj.Ngaysinh + "',103),N'" + svObj.DiaChi + "',N'" + svObj.Lop + "',N'" + svObj.Khoa + "',CONVERT(DATE, '" + svObj.NgayCapThe + "',103)CONVERT(DATE, '" + svObj.NgayHetHan + "',103),'" + svObj.Gioitinh + "' )";
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

        public bool UpdateData(SinhVien_Obh svObj)
        {
            cmd.CommandText = "Update sinhvien set MaThe ='" + svObj.Mathe + "', TenSV  = N'" + svObj.TenSV + "', Ngaysinh = CONVERT(DATE, '" + svObj.Ngaysinh + "',103),DiaChi=N'"+svObj.DiaChi+"', Lop=N'"+svObj.Lop+"',Khoa=N'"+svObj.Khoa+ "',NgayCapThe = CONVERT(DATE, '" + svObj.NgayCapThe + "',103), NgayHetHan = CONVERT(DATE, '" + svObj.NgayHetHan + "',103),gioitinh= '" + svObj.Gioitinh + "' where sophieu= '" + svObj.Mathe + "')";
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

        public bool DeleteData(String mathe)
        {
            cmd.CommandText = "delete sinhvien where sophieu='" + mathe + "'";
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

