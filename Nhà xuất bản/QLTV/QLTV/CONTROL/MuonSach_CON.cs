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
    class MuonSach_CON
    {

        //xu ly dich vu ,chinh sua thong tin giao vien truoc khi dua len bang
        MuonSach_MH MH = new MuonSach_MH();
        public DataTable GetData()
        {
            return MH.GetData();
        }
        public bool AddData(MuonSach_DT dt)
        {
            return MH.AddData(dt);
        }
        public bool UpdateData(MuonSach_DT dt)
        {
            return MH.UpdateData(dt);
        }
        public bool DeleteData(string ma)
        {
            return MH.DeleteData(ma);
        }
    }
}
