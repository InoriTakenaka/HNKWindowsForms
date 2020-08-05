using HNKCore.Proto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HNKInfrastructure.Api {
    public class RbacServiceClient {
        public RbacServiceClient(RestClient client) {
            client_ = client;
        }
        
        public ResponseModel UserLogin(string account,string password) {
            Hashtable hashtable = new Hashtable {
                { "user_account", account },
                { "user_password", password }
            };
            return client_.RequestGet("UserLogin", hashtable);
        }

        public ResponseModel GetUserRole(int uid) {
            Hashtable hashtable = new Hashtable {
                {"id",uid }
            };
            return client_.RequestGet("GetRole", hashtable);
        }

        private RestClient client_;
    }
}
