using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DOITUONG
{
    class SachDT
    {
        string masach, tensach, tacgia, manxb, namxb, lanxb, soluong, noidung, maLS;

        public string Lanxb
        {
            get
            {
                return lanxb;
            }

            set
            {
                lanxb = value;
            }
        }

        public string MaLS
        {
            get
            {
                return maLS;
            }

            set
            {
                maLS = value;
            }
        }

        public string Manxb
        {
            get
            {
                return manxb;
            }

            set
            {
                manxb = value;
            }
        }

        public string Masach
        {
            get
            {
                return masach;
            }

            set
            {
                masach = value;
            }
        }

        public string Namxb
        {
            get
            {
                return namxb;
            }

            set
            {
                namxb = value;
            }
        }

        public string Noidung
        {
            get
            {
                return noidung;
            }

            set
            {
                noidung = value;
            }
        }

        public string Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Tacgia
        {
            get
            {
                return tacgia;
            }

            set
            {
                tacgia = value;
            }
        }

        public string Tensach
        {
            get
            {
                return tensach;
            }

            set
            {
                tensach = value;
            }
        }

        public SachDT()
        {

        }

        public SachDT(string masach, string tensach, string tacgia, string manxb, string maLS, string namxb, string lanxb, string soluong, string noidung)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tacgia = tacgia;
            this.manxb = manxb;
            this.maLS = maLS;
            this.namxb = namxb;
            this.lanxb = lanxb;
            this.soluong = soluong;
            this.noidung = noidung;
        }
    }
}
