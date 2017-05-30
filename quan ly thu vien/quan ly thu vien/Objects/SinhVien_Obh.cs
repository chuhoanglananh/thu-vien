using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_thu_vien.Objects
{
    class SinhVien_Obh
    {
        string mathe, tenSV, ngaysinh, diaChi, lop, khoa, ngayCapThe, ngayHetHan, gioitinh;

        
        
        
        public SinhVien_Obh()
        {
        }
        public SinhVien_Obh(string mathe,string tenSV, string ngaysinh, string diaChi, string lop, string khoa, string ngayCapThe, string ngayHetHan, string gioitinh)
        {
            this.mathe = mathe;
            this.tenSV = tenSV;
            this.ngaysinh = ngaysinh;
            this.diaChi = diaChi;
            this.lop = lop;
            this.khoa =khoa;
            this.ngayCapThe = ngayCapThe;
            this.ngayHetHan = ngayHetHan;
            this.gioitinh = gioitinh;
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
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

        public string Khoa
        {
            get
            {
                return khoa;
            }

            set
            {
                khoa = value;
            }
        }

        public string Lop
        {
            get
            {
                return lop;
            }

            set
            {
                lop = value;
            }
        }

        public string Mathe
        {
            get
            {
                return mathe;
            }

            set
            {
                mathe = value;
            }
        }

        public string NgayCapThe
        {
            get
            {
                return ngayCapThe;
            }

            set
            {
                ngayCapThe = value;
            }
        }

        public string NgayHetHan
        {
            get
            {
                return ngayHetHan;
            }

            set
            {
                ngayHetHan = value;
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

        public string TenSV
        {
            get
            {
                return tenSV;
            }

            set
            {
                tenSV = value;
            }
        }
    }
}

