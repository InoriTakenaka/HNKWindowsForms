using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNKCore.Proto {
    public class Users {
        public int id { get; set; }
        public int user_status { get; set; }
        public string user_code { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public string user_id { get; set; }
        public DateTime create_time { get; set; }
    }
}
