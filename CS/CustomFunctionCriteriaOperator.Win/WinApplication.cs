using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

using CustomFunctionCriteriaOperator.Module;
using CustomFunctionCriteriaOperator.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Security;

namespace CustomFunctionCriteriaOperator.Win {
   public partial class CustomFunctionCriteriaOperatorWindowsFormsApplication : WinApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
        }
      public CustomFunctionCriteriaOperatorWindowsFormsApplication() {
         InitializeComponent();
         DelayedViewItemsInitialization = true;
      }

      private void CustomFunctionCriteriaOperatorWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
      }

      private void CustomFunctionCriteriaOperatorWindowsFormsApplication_LastLogonParametersRead(object sender, LastLogonParametersReadEventArgs e) {
         // Just to read demo user name for logon.
         AuthenticationStandardLogonParameters logonParameters = e.LogonObject as AuthenticationStandardLogonParameters;
         if (logonParameters != null) {
            if (String.IsNullOrEmpty(logonParameters.UserName)) {
               logonParameters.UserName = "Sam";
            }
         }
      }
   }
}
