using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserCache
    {
        public static string IdUser { get; set; }
        public static string LoginName { get; set; }
        public static string Password { get; set; }
        public static string Name { get; set; }
        public static string Position { get; set; }
        public static string Email { get; set; }
        public static byte Image { get; set; }
    }
}
