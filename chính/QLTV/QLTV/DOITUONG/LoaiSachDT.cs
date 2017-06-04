using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DOITUONG
{
    class LoaiSachDT
    {
        string maLS, tenLS;

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

        public string TenLS
        {
            get
            {
                return tenLS;
            }

            set
            {
                tenLS = value;
            }
        }
        public LoaiSachDT()
        {

        }

        public LoaiSachDT(string maLS, string tenLS)
        {
            this.maLS = maLS;
            this.tenLS = tenLS;
        }
    }
}
