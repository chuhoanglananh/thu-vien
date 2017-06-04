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
    class SachCON
    {
        SachMH MH = new SachMH();
        public DataTable GetData()
        {
            return MH.GetData();
        }
        public bool AddData(SachDT dt)
        {
            return MH.AddData(dt);
        }
        public bool UpdateData(SachDT dt)
        {
            return MH.UpdateData(dt);
        }
        public bool DeleteData(string ma)
        {
            return MH.DeleteData(ma);
        }
    }
}
