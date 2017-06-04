using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DOITUONG
{
    class TaiKhoan
    {
        string tentk, matkhau;

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

        public string Tentk
        {
            get
            {
                return tentk;
            }

            set
            {
                tentk = value;
            }
        }
        public TaiKhoan()
        {

        }

        public TaiKhoan(string tentk, string matkhau)
        {
            this.tentk = tentk;
            this.matkhau = matkhau;
        }
    }
}
