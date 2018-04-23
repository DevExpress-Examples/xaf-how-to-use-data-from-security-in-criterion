Imports DevExpress.ExpressApp.Xpo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Imports CustomFunctionCriteriaOperator.Module
Imports CustomFunctionCriteriaOperator.Module.BusinessObjects
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Security

Namespace CustomFunctionCriteriaOperator.Win
   Partial Public Class CustomFunctionCriteriaOperatorWindowsFormsApplication
       Inherits WinApplication

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
      Public Sub New()
         InitializeComponent()
         DelayedViewItemsInitialization = True
      End Sub

      Private Sub CustomFunctionCriteriaOperatorWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
      End Sub

      Private Sub CustomFunctionCriteriaOperatorWindowsFormsApplication_LastLogonParametersRead(ByVal sender As Object, ByVal e As LastLogonParametersReadEventArgs) Handles MyBase.LastLogonParametersRead
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
