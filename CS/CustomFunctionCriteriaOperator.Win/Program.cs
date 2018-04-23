using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Xpo;

namespace CustomFunctionCriteriaOperator.Win {
   static class Program {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() {
#if EASYTEST
			DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
         CustomFunctionCriteriaOperatorWindowsFormsApplication winApplication = new CustomFunctionCriteriaOperatorWindowsFormsApplication();
         InMemoryDataStoreProvider.Register();
         winApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString;
         try {
            // Uncomment this line when using the Middle Tier application server:
            // new DevExpress.ExpressApp.MiddleTier.MiddleTierClientApplicationConfigurator(winApplication);
            winApplication.Setup();
            winApplication.Start();
         }
         catch (Exception e) {
            winApplication.HandleException(e);
         }
      }
   }
}
