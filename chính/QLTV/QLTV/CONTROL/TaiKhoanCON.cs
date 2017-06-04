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
    class TaiKhoanCON
    {
        TaiKhoanMH MH = new TaiKhoanMH();
        public DataTable GetData()
        {
            return MH.GetData();
        }
    }
}
