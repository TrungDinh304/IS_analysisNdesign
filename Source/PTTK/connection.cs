using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PTTK
{
    internal class ConnectionStr
    {
        //public static string connectionStr = @"DATA SOURCE=localhost:1521/xe;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=D:\Oracle\homes\OraDB21Home1\network\admin;PERSIST SECURITY INFO=True;USER ID=SYS;PASSWORD=123456";
        //public static string connectionStr = @"DATA SOURCE=localhost:1521/xe;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=D:\Oracle\homes\OraDB21Home1\network\admin;PERSIST SECURITY INFO=True;USER ID=ADMIN1;PASSWORD=123";
        public static string connectionStr = $@"DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;USER ID=admin2;PASSWORD=123";
    }
    internal class Login_information
    {
        public static string username;
        public static string password;
        public static string fullname;
        public static string role;

    }
}