using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.MOHINH
{
    class KCSDL
    {

        //các hàm có sẵn
        #region available
        private SqlConnection conn;
        private SqlCommand _cmd;

        public SqlCommand Cmd
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        public SqlConnection Connection { get { return conn; } }
        private string error;

        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        string StrCon;

        #endregion
        //constructor
        #region Constructor
        public KCSDL()
        {
            StrCon = @"Data Source=DESKTOP-P7B7DMM;Initial Catalog=quanlythuvien;Integrated Security=True";
            conn = new SqlConnection(StrCon);
        }
        #endregion
        //các phương thức
        #region methods
        //mở kết nối
        public bool OpenConn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        //đóng kết nối
        public bool CloseConn()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
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
