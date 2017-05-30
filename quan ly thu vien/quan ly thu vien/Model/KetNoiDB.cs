using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace quan_ly_thu_vien.Model
{
    class KetNoiDB
    {
        #region Availible
        private SqlConnection con;
        private SqlCommand cmd;
        public SqlCommand CMD
        {
            get { return cmd; }
            set { cmd = value; }
        }
        public SqlConnection Connection { get { return con; } }
        private string error;
        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        string StrCon;
        #endregion
        #region Contructor
        public KetNoiDB ()
        {
            StrCon = @"Data Source=DESKTOP-NER56SG\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True";
            con = new SqlConnection(StrCon);
        }
        #endregion
        #region Methods
        public bool OpenCon()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseCon()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        #endregion
    }
}
