using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_thu_vien.Objects
{
    class ChiTietPhieuMuon_Ob
    {
        string SoPhieuMuon, MaSach;
        string HenTra;

        public string HenTra1
        {
            get
            {
                return HenTra;
            }

            set
            {
                HenTra = value;
            }
        }

        public string MaSach1
        {
            get
            {
                return MaSach;
            }

            set
            {
                MaSach = value;
            }
        }

        internal bool AddData(ChiTietPhieuMuon_Ob ctOj)
        {
            throw new NotImplementedException();
        }

        public string SoPhieuMuon1
        {
            get
            {
                return SoPhieuMuon;
            }

            set
            {
                SoPhieuMuon = value;
            }
        }
        public ChiTietPhieuMuon_Ob() { }
        public ChiTietPhieuMuon_Ob(string SoPhieuMuon, string MaSach, string HenTra)
        {
            this.SoPhieuMuon = SoPhieuMuon;
            this.MaSach = MaSach;
            this.HenTra = HenTra;
        }
    }
}
