using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;

using CustomFunctionCriteriaOperator.Module;
using DevExpress.ExpressApp;
using CustomFunctionCriteriaOperator.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Security;

namespace CustomFunctionCriteriaOperator.Web {
   public partial class CustomFunctionCriteriaOperatorAspNetApplication : WebApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
        }
      private DevExpress.ExpressApp.SystemModule.SystemModule module1;
      private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
      private CustomFunctionCriteriaOperator.Module.CustomFunctionCriteriaOperatorModule module3;
      private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
      private System.Data.SqlClient.SqlConnection sqlConnection1;
      private SecurityModule securityModule1;
      private SecurityStrategyComplex securityStrategyComplex1;
      private AuthenticationStandard authenticationStandard1;
      private DevExpress.ExpressApp.Validation.ValidationModule module5;

      public CustomFunctionCriteriaOperatorAspNetApplication() {
         InitializeComponent();
      }

      private void CustomFunctionCriteriaOperatorAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
      }

      private void InitializeComponent() {
          this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
          this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
          this.module3 = new CustomFunctionCriteriaOperator.Module.CustomFunctionCriteriaOperatorModule();
          this.module5 = new DevExpress.ExpressApp.Validation.ValidationModule();
          this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
          this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
          this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
          this.securityStrategyComplex1 = new DevExpress.ExpressApp.Security.SecurityStrategyComplex();
          this.authenticationStandard1 = new DevExpress.ExpressApp.Security.AuthenticationStandard();
          ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
          // 
          // module5
          // 
          this.module5.AllowValidationDetailsAccess = true;
          // 
          // sqlConnection1
          // 
          this.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=CustomFunctionCriteriaOperator;Integrated Sec" +
              "urity=SSPI;Pooling=false";
          this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
          // 
          // securityStrategyComplex1
          // 
          this.securityStrategyComplex1.Authentication = this.authenticationStandard1;
          this.securityStrategyComplex1.RoleType = typeof(DevExpress.ExpressApp.Security.Strategy.SecuritySystemRole);
          this.securityStrategyComplex1.UserType = typeof(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser);
          // 
          // authenticationStandard1
          // 
          this.authenticationStandard1.LogonParametersType = typeof(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters);
          // 
          // CustomFunctionCriteriaOperatorAspNetApplication
          // 
          this.ApplicationName = "CustomFunctionCriteriaOperator";
          this.Connection = this.sqlConnection1;
          this.Modules.Add(this.module1);
          this.Modules.Add(this.module2);
          this.Modules.Add(this.module6);
          this.Modules.Add(this.securityModule1);
          this.Modules.Add(this.module3);
          this.Modules.Add(this.module5);
          this.Security = this.securityStrategyComplex1;
          this.LastLogonParametersRead += new System.EventHandler<DevExpress.ExpressApp.LastLogonParametersReadEventArgs>(this.CustomFunctionCriteriaOperatorAspNetApplication_LastLogonParametersRead);
          this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.CustomFunctionCriteriaOperatorAspNetApplication_DatabaseVersionMismatch);
          ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      private void CustomFunctionCriteriaOperatorAspNetApplication_LastLogonParametersRead(object sender, LastLogonParametersReadEventArgs e) {
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
