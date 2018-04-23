Namespace CustomFunctionCriteriaOperator.Win
   Partial Public Class CustomFunctionCriteriaOperatorWindowsFormsApplication
      ''' <summary> 
      ''' Required designer variable.
      ''' </summary>
      Private components As System.ComponentModel.IContainer = Nothing

      ''' <summary> 
      ''' Clean up any resources being used.
      ''' </summary>
      ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      Protected Overrides Sub Dispose(ByVal disposing As Boolean)
         If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
         End If
         MyBase.Dispose(disposing)
      End Sub

      #Region "Component Designer generated code"

      ''' <summary> 
      ''' Required method for Designer support - do not modify 
      ''' the contents of this method with the code editor.
      ''' </summary>
      Private Sub InitializeComponent()
          Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
          Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
          Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
          Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
          Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
          Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
          Me.scriptRecorderWindowsFormsModule1 = New DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule()
          Me.scriptRecorderModuleBase1 = New DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase()
          Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
          Me.module3 = New CustomFunctionCriteriaOperator.Module.CustomFunctionCriteriaOperatorModule()
          Me.securityStrategyComplex1 = New DevExpress.ExpressApp.Security.SecurityStrategyComplex()
          Me.authenticationStandard2 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
          DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
          ' 
          ' module5
          ' 
          Me.module5.AllowValidationDetailsAccess = True
          ' 
          ' sqlConnection1
          ' 
          Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=CustomFunctionCriteriaOperator;Integrated Sec" & "urity=SSPI;Pooling=false"
          Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
          ' 
          ' securityStrategyComplex1
          ' 
          Me.securityStrategyComplex1.Authentication = Me.authenticationStandard2
          Me.securityStrategyComplex1.RoleType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemRole)
          Me.securityStrategyComplex1.UserType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser)
          ' 
          ' authenticationStandard2
          ' 
          Me.authenticationStandard2.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
          ' 
          ' CustomFunctionCriteriaOperatorWindowsFormsApplication
          ' 
          Me.ApplicationName = "CustomFunctionCriteriaOperator"
          Me.Connection = Me.sqlConnection1
          Me.Modules.Add(Me.module1)
          Me.Modules.Add(Me.module2)
          Me.Modules.Add(Me.module6)
          Me.Modules.Add(Me.securityModule1)
          Me.Modules.Add(Me.module3)
          Me.Modules.Add(Me.module5)
          Me.Modules.Add(Me.module7)
          Me.Modules.Add(Me.scriptRecorderModuleBase1)
          Me.Modules.Add(Me.scriptRecorderWindowsFormsModule1)
          Me.Security = Me.securityStrategyComplex1
          DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

      End Sub

      #End Region

      Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
      Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
      Private module3 As CustomFunctionCriteriaOperator.Module.CustomFunctionCriteriaOperatorModule
      Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
      Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
      Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
      Private sqlConnection1 As System.Data.SqlClient.SqlConnection
      Private scriptRecorderWindowsFormsModule1 As DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule
      Private scriptRecorderModuleBase1 As DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase
      Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
      Private securityStrategyComplex1 As DevExpress.ExpressApp.Security.SecurityStrategyComplex
      Private authenticationStandard2 As DevExpress.ExpressApp.Security.AuthenticationStandard
   End Class
End Namespace
