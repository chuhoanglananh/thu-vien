using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using quan_ly_thu_vien.Model;
using quan_ly_thu_vien.Objects;

namespace quan_ly_thu_vien.Control
{
    class ChiTietPhieuMuon_Control
    {
        //chinh sua thong tin truoc khi dua len view
        ChiTietPhieuMuon_Model ctMo = new ChiTietPhieuMuon_Model();
        public DataTable getData()
        {
            return ctMo.GetData();
        }

        public bool addData(ChiTietPhieuMuon_Ob ctObj )
        {
            return ctMo.AddData(ctObj);
        }

        public bool upDate(ChiTietPhieuMuon_Ob ciOj)
        {
            return ctMo.UpdateData(ciOj);
        }

        public bool delData(string ma)
        {
            return ctMo.DeleteData(ma);
        }
    }
}
