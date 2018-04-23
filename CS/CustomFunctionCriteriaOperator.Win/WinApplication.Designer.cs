namespace CustomFunctionCriteriaOperator.Win {
   partial class CustomFunctionCriteriaOperatorWindowsFormsApplication {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
          this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
          this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
          this.module5 = new DevExpress.ExpressApp.Validation.ValidationModule();
          this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
          this.module7 = new DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule();
          this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
          this.scriptRecorderWindowsFormsModule1 = new DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule();
          this.scriptRecorderModuleBase1 = new DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase();
          this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
          this.module3 = new CustomFunctionCriteriaOperator.Module.CustomFunctionCriteriaOperatorModule();
          this.securityStrategyComplex1 = new DevExpress.ExpressApp.Security.SecurityStrategyComplex();
          this.authenticationStandard2 = new DevExpress.ExpressApp.Security.AuthenticationStandard();
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
          this.securityStrategyComplex1.Authentication = this.authenticationStandard2;
          this.securityStrategyComplex1.RoleType = typeof(DevExpress.ExpressApp.Security.Strategy.SecuritySystemRole);
          this.securityStrategyComplex1.UserType = typeof(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser);
          // 
          // authenticationStandard2
          // 
          this.authenticationStandard2.LogonParametersType = typeof(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters);
          // 
          // CustomFunctionCriteriaOperatorWindowsFormsApplication
          // 
          this.ApplicationName = "CustomFunctionCriteriaOperator";
          this.Connection = this.sqlConnection1;
          this.Modules.Add(this.module1);
          this.Modules.Add(this.module2);
          this.Modules.Add(this.module6);
          this.Modules.Add(this.securityModule1);
          this.Modules.Add(this.module3);
          this.Modules.Add(this.module5);
          this.Modules.Add(this.module7);
          this.Modules.Add(this.scriptRecorderModuleBase1);
          this.Modules.Add(this.scriptRecorderWindowsFormsModule1);
          this.Security = this.securityStrategyComplex1;
          this.LastLogonParametersRead += new System.EventHandler<DevExpress.ExpressApp.LastLogonParametersReadEventArgs>(this.CustomFunctionCriteriaOperatorWindowsFormsApplication_LastLogonParametersRead);
          this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.CustomFunctionCriteriaOperatorWindowsFormsApplication_DatabaseVersionMismatch);
          ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.ExpressApp.SystemModule.SystemModule module1;
      private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
      private CustomFunctionCriteriaOperator.Module.CustomFunctionCriteriaOperatorModule module3;
      private DevExpress.ExpressApp.Validation.ValidationModule module5;
      private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
      private DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule module7;
      private System.Data.SqlClient.SqlConnection sqlConnection1;
      private DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule scriptRecorderWindowsFormsModule1;
      private DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase scriptRecorderModuleBase1;
      private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
      private DevExpress.ExpressApp.Security.SecurityStrategyComplex securityStrategyComplex1;
      private DevExpress.ExpressApp.Security.AuthenticationStandard authenticationStandard2;
   }
}
