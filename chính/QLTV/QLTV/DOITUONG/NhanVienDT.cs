using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DOITUONG
{
    class NhanVienDT
    {
        string manv, tennv, diachi, ngaysinh, gioitinh, dienthoai, matkhau;

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

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
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

        public string Tennv
        {
            get
            {
                return tennv;
            }

            set
            {
                tennv = value;
            }
        }
        public NhanVienDT() { }

        public NhanVienDT (string manv, string tennv, string diachi, string ngaysinh, string gioitinh, string dienthoai, string matkhau)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.dienthoai = dienthoai;
            this.matkhau = matkhau;
        }
    }
}
