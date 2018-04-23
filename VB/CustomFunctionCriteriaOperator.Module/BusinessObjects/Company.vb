Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace CustomFunctionCriteriaOperator.Module.BusinessObjects
   <DefaultClassOptions()> _
   Public Class Company
       Inherits BaseObject

      Public Sub New(ByVal session As Session)
          MyBase.New(session)
      End Sub


      Private name_Renamed As String
      Public Property Name() As String
         Get
            Return name_Renamed
         End Get
         Set(ByVal value As String)
            SetPropertyValue("Name", name_Renamed, value)
         End Set
      End Property

      <Association("Company-Employees", GetType(Employee))> _
      Public ReadOnly Property Employees() As XPCollection
         Get
            Return GetCollection("Employees")
         End Get
      End Property
   End Class
End Namespace
