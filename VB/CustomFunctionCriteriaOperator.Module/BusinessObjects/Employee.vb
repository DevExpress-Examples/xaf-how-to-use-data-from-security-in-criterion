Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Imports DevExpress.ExpressApp.Security.Strategy

Namespace CustomFunctionCriteriaOperator.Module.BusinessObjects
   <DefaultClassOptions(), DefaultProperty("UserName")> _
   Public Class Employee
       Inherits SecuritySystemUser


      Private company_Renamed As Company

      Public Sub New(ByVal session As Session)
          MyBase.New(session)
      End Sub

      <Association("Company-Employees", GetType(Company))> _
      Public Property Company() As Company
         Get
            Return company_Renamed
         End Get
         Set(ByVal value As Company)
            SetPropertyValue("Company", company_Renamed, value)
         End Set
      End Property
   End Class

End Namespace
