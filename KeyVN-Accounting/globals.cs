using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyVN_Accounting
{
    static class globals
    {
        public static String _staff_username = "debug_user1234";
        public static String _staff_userid = "DBG001";

        public static String _orderid = "";
        public static String _accountid = "";

        public static String orderid
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        public static String accountid
        {
            get { return _accountid; }
            set { _accountid = value; }
        }
        public static String staff_username
        {
            get { return _staff_username; }
            set { _staff_username = value; }
        }
        public static String staff_userid
        {
            get { return _staff_userid; }
            set { _staff_userid = value; }
        }
    }
}
