Imports DevExpress.ExpressApp.Xpo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Imports CustomFunctionCriteriaOperator.Module
Imports DevExpress.ExpressApp
Imports CustomFunctionCriteriaOperator.Module.BusinessObjects
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Security

Namespace CustomFunctionCriteriaOperator.Web
   Partial Public Class CustomFunctionCriteriaOperatorAspNetApplication
       Inherits WebApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
      Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
      Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
      Private module3 As CustomFunctionCriteriaOperator.Module.CustomFunctionCriteriaOperatorModule
      Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
      Private sqlConnection1 As System.Data.SqlClient.SqlConnection
      Private securityModule1 As SecurityModule
      Private securityStrategyComplex1 As SecurityStrategyComplex
      Private authenticationStandard1 As AuthenticationStandard
      Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

      Public Sub New()
         InitializeComponent()
      End Sub

      Private Sub CustomFunctionCriteriaOperatorAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
      End Sub

      Private Sub InitializeComponent()
          Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
          Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
          Me.module3 = New CustomFunctionCriteriaOperator.Module.CustomFunctionCriteriaOperatorModule()
          Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
          Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
          Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
          Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
          Me.securityStrategyComplex1 = New DevExpress.ExpressApp.Security.SecurityStrategyComplex()
          Me.authenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
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
          Me.securityStrategyComplex1.Authentication = Me.authenticationStandard1
          Me.securityStrategyComplex1.RoleType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemRole)
          Me.securityStrategyComplex1.UserType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser)
          ' 
          ' authenticationStandard1
          ' 
          Me.authenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
          ' 
          ' CustomFunctionCriteriaOperatorAspNetApplication
          ' 
          Me.ApplicationName = "CustomFunctionCriteriaOperator"
          Me.Connection = Me.sqlConnection1
          Me.Modules.Add(Me.module1)
          Me.Modules.Add(Me.module2)
          Me.Modules.Add(Me.module6)
          Me.Modules.Add(Me.securityModule1)
          Me.Modules.Add(Me.module3)
          Me.Modules.Add(Me.module5)
          Me.Security = Me.securityStrategyComplex1
          DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

      End Sub

      Private Sub CustomFunctionCriteriaOperatorAspNetApplication_LastLogonParametersRead(ByVal sender As Object, ByVal e As LastLogonParametersReadEventArgs) Handles MyBase.LastLogonParametersRead
         ' Just to read demo user name for logon.
         Dim logonParameters As AuthenticationStandardLogonParameters = TryCast(e.LogonObject, AuthenticationStandardLogonParameters)
         If logonParameters IsNot Nothing Then
            If String.IsNullOrEmpty(logonParameters.UserName) Then
               logonParameters.UserName = "Sam"
            End If
         End If
      End Sub
   End Class
End Namespace
