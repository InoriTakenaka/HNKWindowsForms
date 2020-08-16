using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using HNKWindowsForms.Auxiliary;
using HNKWindowsForms.Forms;
using HNKWindowsForms.Forms.Application;

namespace HNKWindowsForms {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            AppManager.GetInstance().ApiUrl = "https://localhost:5001/api/";
            AppManager.GetInstance().UserLoginState = AppManager.UserState.LOGOUT;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //----------------------//          
            FrmNavigation frmNavigation = new FrmNavigation();
            //----------------------//
            Application.Run(frmNavigation);
        }
    }
}
