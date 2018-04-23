Imports System
Imports System.Collections.Generic

Imports DevExpress.ExpressApp
Imports System.Reflection


Namespace CustomFunctionCriteriaOperator.Module
   Public NotInheritable Partial Class CustomFunctionCriteriaOperatorModule
       Inherits ModuleBase

      Public Sub New()
         InitializeComponent()
         CurrentCompanyOidOperator.Register()
      End Sub
   End Class
End Namespace
