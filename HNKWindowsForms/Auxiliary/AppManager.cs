using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HNKCore.Proto;

namespace HNKWindowsForms.Auxiliary {
    public class AppManager {
        private static readonly Lazy<AppManager> Instance 
            = new Lazy<AppManager>(() => new AppManager());
        /// <summary>
        /// Current User Infomation
        /// </summary>
        public Users User { get; set; }
        /// <summary>
        /// Web Api Url
        /// </summary>
        public string ApiUrl { get; set; }
        /// <summary>
        /// User login state 
        /// </summary>
        public UserState UserLoginState { get; set; }
        public enum UserState:Int32 {
            LOGIN,LOGOUT,
        }
        public static AppManager GetInstance() {
            return Instance.Value;
        }
    }
}
