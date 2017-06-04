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
    class LoaiSachCTRL
    {
        //xu ly dich vu ,chinh sua thong tin giao vien truoc khi dua len bang
        LoaiSachMH MH = new LoaiSachMH();
        public DataTable GetData()
        {
            return MH.GetData();
        }
        public bool AddData(LoaiSachDT dt)
        {
            return MH.AddData(dt);
        }
        public bool UpdateData(LoaiSachDT dt)
        {
            return MH.UpdateData(dt);
        }
        public bool DeleteData(string ma)
        {
            return MH.DeleteData(ma);
        }

        
    }
}
