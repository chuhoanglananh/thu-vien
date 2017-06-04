using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DOITUONG
{
    class NVBDT
    {
        string manxb, tennxb, diachi, web;

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

        public string Tennxb
        {
            get
            {
                return tennxb;
            }

            set
            {
                tennxb = value;
            }
        }

        public string Web
        {
            get
            {
                return web;
            }

            set
            {
                web = value;
            }
        }

        public NVBDT ()
        {

        }
        public NVBDT (string manxb, string tennxb, string diachi, string web )
        {
            this.manxb = manxb;
            this.tennxb = tennxb;
            this.diachi = diachi;
            this.web = web;
        }
    }
}
