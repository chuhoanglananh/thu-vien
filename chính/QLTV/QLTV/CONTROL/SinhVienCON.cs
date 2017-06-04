using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLTV.MOHINH;
using QLTV.DOITUONG;

namespace QLTV.CONTROL
{
    class SinhVienCON
    {
        SinhVienMH MH = new SinhVienMH();
        public DataTable GetData()
        {
            return MH.GetData();
        }
        public bool AddData(SinhVienDT dt)
        {
            return MH.AddData(dt);
        }
        public bool UpdateData(SinhVienDT dt)
        {
            return MH.UpdateData(dt);
        }
        public bool DeleteData(string ma)
        {
            return MH.DeleteData(ma);
        }
    }
}
