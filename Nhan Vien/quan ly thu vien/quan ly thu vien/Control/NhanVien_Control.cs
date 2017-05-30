using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using quan_ly_thu_vien.Objects;
using quan_ly_thu_vien.Model;

namespace quan_ly_thu_vien.Control
{
    class NhanVien_Control
    {
        NhanVien_Model nvMo = new NhanVien_Model();
        public DataTable getData()
        {
            return nvMo.getData();
        }
        public bool AddData(NhanVien_Object nvObj)
        {
            return nvMo.AddData(nvObj);

        }
        public bool UpdateData(NhanVien_Object nvObj)
        {
            return nvMo.UpdateData(nvObj);
        }
        public bool DeleteData(string ma)
        {
            return nvMo.DeleteData(ma);
        }
    }
     
}
