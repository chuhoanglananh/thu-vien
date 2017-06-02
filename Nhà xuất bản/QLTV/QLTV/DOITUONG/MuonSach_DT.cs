using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DOITUONG
{
    class MuonSach_DT
    {
        string sophieumuon, mathe, manv, ngaymuon;

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

        public string Ngaymuon
        {
            get
            {
                return ngaymuon;
            }

            set
            {
                ngaymuon = value;
            }
        }

        public string Sophieumuon
        {
            get
            {
                return sophieumuon;
            }

            set
            {
                sophieumuon = value;
            }
        }
        public MuonSach_DT()
        {

        }

        public MuonSach_DT (string sophieumuon, string mathe, string manv, string ngaymuon)
        {
            this.sophieumuon = sophieumuon;
            this.mathe = mathe;
            this.manv = manv;
            this.ngaymuon = ngaymuon;
        }
    }
}
