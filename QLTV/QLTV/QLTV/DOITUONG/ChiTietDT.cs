using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DOITUONG
{
    class ChiTietDT
    {
        string sophieu, masach, hentra;

        public string Hentra
        {
            get
            {
                return hentra;
            }

            set
            {
                hentra = value;
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

        public string Sophieu
        {
            get
            {
                return sophieu;
            }

            set
            {
                sophieu = value;
            }
        }
        public ChiTietDT()
        {

        }

        public ChiTietDT(string sophieu, string masach, string hentra)
        {
            this.sophieu = sophieu;
            this.masach = masach;
            this.hentra = hentra;
        }
        

    }
}
