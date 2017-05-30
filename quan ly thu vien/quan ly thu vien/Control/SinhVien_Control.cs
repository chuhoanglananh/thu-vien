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
    class SinhVien_Control
    {
        //chinh sua thong tin truoc khi dua len view
        SinhVien_Model svMo = new SinhVien_Model();
        public DataTable getData()
        {
            return svMo.GetData();
        }

        public bool addData(SinhVien_Obh svObj)
        {
            return svMo.AddData(svObj);
        }

        public bool upDate(SinhVien_Obh svObj)
        {
            return svMo.UpdateData(svObj);
        }

        public bool delData(string ma)
        {
            return svMo.DeleteData(ma);
        }
    }
}

