using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DOITUONG
{
    class SinhVienDT
    {
        string mathe, tensv, ngaysinh, diachi, lop, khoa, ngaycapthe, ngayhethan, gioitinh;

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

        public string Ngaycapthe
        {
            get
            {
                return ngaycapthe;
            }

            set
            {
                ngaycapthe = value;
            }
        }

        public string Ngayhethan
        {
            get
            {
                return ngayhethan;
            }

            set
            {
                ngayhethan = value;
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

        public string Tensv
        {
            get
            {
                return tensv;
            }

            set
            {
                tensv = value;
            }
        }
        public SinhVienDT()
        {

        }

        public SinhVienDT(string mathe, string tensv, string ngaysinh, string diachi,string lop, string khoa, string ngaycapthe, string ngayhethan, string gioitinh)
        {
            this.mathe = mathe;
            this.tensv = tensv;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.lop = lop;
            this.khoa = khoa;
            this.ngaycapthe = ngaycapthe;
            this.ngayhethan = ngayhethan;
            this.gioitinh = gioitinh;
        }
    }
}
