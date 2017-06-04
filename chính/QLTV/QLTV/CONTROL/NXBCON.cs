using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLTV.MOHINH;
using QLTV.DOITUONG;

namespace QLTV.CONTROL
{
    class NXBCON
    {
        //xu ly dich vu ,chinh sua thong tin giao vien truoc khi dua len bang
        NHBMH MH = new NHBMH();
        public DataTable GetData()
        {
            return MH.GetData();
        }
        public bool AddData(NVBDT dt)
        {
            return MH.AddData(dt);
        }
        public bool UpdateData(NVBDT dt)
        {
            return MH.UpdateData(dt);
        }
        public bool DeleteData(string ma)
        {
            return MH.DeleteData(ma);
        }
    }
}
