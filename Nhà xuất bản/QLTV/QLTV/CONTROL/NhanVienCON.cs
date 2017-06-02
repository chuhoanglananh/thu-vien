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
    class NhanVienCON
    {
        NhanVienMH MH = new NhanVienMH();
        public DataTable GetData()
        {
            return MH.GetData();
        }
        public bool AddData(NhanVienDT dt)
        {
            return MH.AddData(dt);
        }
        public bool UpdateData(NhanVienDT dt)
        {
            return MH.UpdateData(dt);
        }
        public bool DeleteData(string ma)
        {
            return MH.DeleteData(ma);
        }
    }
}
