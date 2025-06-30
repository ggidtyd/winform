using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB01
{
    public class Users
    {
        public int idx { get; set; }
        public string user_id { get; set; }
        public string user_pwd { get; set; }
        public string user_role { get; set; }
        public string user_name { get; set; }
        public DateTime login_date { get; set; }
    }
}
