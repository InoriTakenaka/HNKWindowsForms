using HNKCore.Proto;
using System.Collections;
using System.Collections.Generic;

namespace HNKInfrastructure.Api {
    public class MenuServiceClient:RestClient {
        public MenuServiceClient(string url):base(url){
             
        }

        public ResponseModel GetMenu(int userId) {
            Hashtable hashtable = new Hashtable {
                { "id",userId }
           };
            return RequestGet("GetMenu", hashtable);
        }
        public ResponseModel GetMenus() {
            return RequestGet("GetMenus", null);
        }
        public ResponseModel SaveMenus(List<Menus> menus) {
            return RequestPut("SaveMenus", menus);
        }
    }
}
