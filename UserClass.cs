using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LSTV_Desktop_App
{
    public static class UserClass
    {

        private static string xusername;
        private static string xfullname;

        public static void setUsername(string value) {
            xusername = value;
        }

        public static string getUsername() {
            return xusername;
        }

        public static void setFullname(string value) {
            xfullname = value;
        }

        public static string getFullname() {
            return xfullname;
        }

    }
}
