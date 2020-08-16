using HNKCore.Proto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;

namespace HNKInfrastructure.Api {
    public class RbacServiceClient :RestClient{
        public RbacServiceClient(string url):base(url) {
        }

        public ResponseModel UserLogin(string account, string password) {
            Hashtable hashtable = new Hashtable {
                { "user_account", account },
                { "user_password", password }
            };
            return RequestGet("UserLogin", hashtable);
        }

        public ResponseModel GetUserRole(int uid) {
            Hashtable hashtable = new Hashtable {
                {"id",uid }
            };
            return RequestGet("GetRoleByUser", hashtable);
        }

        public ResponseModel GetRoles() {
            return RequestGet("GetRoles", null);
        }
        public ResponseModel SaveRole(Roles role) {
            Hashtable hashtable = new Hashtable {
                {"role",role }
            };
            return RequestPost("SaveRole", hashtable);
        }
        public ResponseModel SaveRoleMenuMap(RoleMenuMaps[] roleMenuMaps) {
            Hashtable hashtable = new Hashtable {
                {"roleMenuMaps",roleMenuMaps }
            };
            return RequestPost("SaveRoleMenu", hashtable);
        }
        public ResponseModel AddUser(Users user) {
            Hashtable hashtable = new Hashtable {
                {"UsersDto",user }
            };
            return RequestPost("AddUser", hashtable);
        }
        public ResponseModel ModifyUser(Users user) {
            Hashtable hashtable = new Hashtable {
                {"UsersDto",user }
            };
            return RequestPost("ModifyUser", user);
        }
        public ResponseModel SaveUserRoleMap(UserRoleMaps[] userRoleMaps) {
            Hashtable hashtable = new Hashtable {
                {"maps",userRoleMaps }
            };
            return RequestPost("SaveUserRole", hashtable);
        }
        public ResponseModel DeleteUserById(int uid) {
            Hashtable hashtable = new Hashtable {
                {"id",uid}
            };
            return RequestGet("DeleteUser", hashtable);
        }
    }
}
