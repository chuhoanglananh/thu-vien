using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_thu_vien.Objects
{
    class NhanVien_Object
    {
        string maNV, tenNV, diachi, ngaysinh, gioitinh, dienthoai, matkhau;

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Dienthoai
        {
            get
            {
                return dienthoai;
            }

            set
            {
                dienthoai = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }
            set
            {
                maNV = value;
            }
        }

        

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }
        public NhanVien_Object() { }

        public NhanVien_Object (string maNV, string tenNV, string diachi, string ngaysinh, string gioitinh, string dienthoai, string matkhau )

        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.dienthoai = dienthoai;
            this.matkhau = matkhau;
        }
    }
}
