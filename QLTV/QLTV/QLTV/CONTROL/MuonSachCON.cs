using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLTV.DOITUONG;
using QLTV.MOHINH;


namespace QLTV.CONTROL
{
    class MuonSachCON
    {
        MuonSachMH MH = new MuonSachMH();
        public DataTable GetData()
        {
            return MH.GetData();
        }
        public bool AddData(MuonSachDT dt)
        {
            return MH.AddData(dt);
        }
        public bool UpdateData(MuonSachDT dt)
        {
            return MH.UpdateData(dt);
        }
        public bool DeleteData(string ma)
        {
            return MH.DeleteData(ma);
        }
    }
}
