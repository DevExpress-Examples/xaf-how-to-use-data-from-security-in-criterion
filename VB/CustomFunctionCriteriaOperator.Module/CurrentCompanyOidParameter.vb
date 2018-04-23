Imports System
Imports System.Collections.Generic
Imports System.Text

Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports CustomFunctionCriteriaOperator.Module.BusinessObjects

Namespace CustomFunctionCriteriaOperator.Module
   Public Class CurrentCompanyOidOperator
       Implements ICustomFunctionOperator

        Public ReadOnly Property Name() As String Implements ICustomFunctionOperator.Name
            Get
                Return "CurrentCompanyOid"
            End Get
        End Property
        Public Function Evaluate(ByVal ParamArray operands() As Object) As Object Implements ICustomFunctionOperator.Evaluate
            Return CType(SecuritySystem.CurrentUser, Employee).Company.Oid
        End Function
        Public Function ResultType(ByVal ParamArray operands() As Type) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Object)
        End Function
      Shared Sub New()
         Dim instance As New CurrentCompanyOidOperator()
         If CriteriaOperator.GetCustomFunction(instance.Name) Is Nothing Then
            CriteriaOperator.RegisterCustomFunction(instance)
         End If
      End Sub
      Public Shared Sub Register()
      End Sub
   End Class
End Namespace
