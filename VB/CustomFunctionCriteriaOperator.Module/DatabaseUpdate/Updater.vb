Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Security

Imports CustomFunctionCriteriaOperator.Module.BusinessObjects
Imports DevExpress.ExpressApp.Security.Strategy
Imports DevExpress.ExpressApp.Security.Strategy.PermissionMatrix

Namespace CustomFunctionCriteriaOperator.Module.DatabaseUpdate
   Public Class Updater
       Inherits ModuleUpdater

      Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
          MyBase.New(objectSpace, currentDBVersion)
      End Sub
      Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
         MyBase.UpdateDatabaseAfterUpdateSchema()

         If ObjectSpace.CreateCollection(GetType(Company)).Count = 0 Then

             Dim adminRole As SecuritySystemRole = ObjectSpace.FindObject(Of SecuritySystemRole)(New BinaryOperator("Name", SecurityStrategy.AdministratorRoleName))
            If adminRole Is Nothing Then
                adminRole = ObjectSpace.CreateObject(Of SecuritySystemRole)()
                adminRole.Name = SecurityStrategy.AdministratorRoleName
                adminRole.IsAdministrative = True
            End If
            Dim userRole As SecuritySystemRole = ObjectSpace.FindObject(Of SecuritySystemRole)(New BinaryOperator("Name", "User"))
            If userRole Is Nothing Then
                userRole = ObjectSpace.CreateObject(Of SecuritySystemRole)()
                userRole.Name = "User"
                Dim userTypePermission As SecuritySystemTypePermissionObject = ObjectSpace.CreateObject(Of SecuritySystemTypePermissionObject)()
                userTypePermission.TargetType = GetType(SecuritySystemUser)
                Dim currentUserObjectPermission As SecuritySystemObjectPermissionsObject = ObjectSpace.CreateObject(Of SecuritySystemObjectPermissionsObject)()
                currentUserObjectPermission.Criteria = "[Oid] = CurrentUserId()"
                currentUserObjectPermission.AllowNavigate = True
                currentUserObjectPermission.AllowRead = True
                userTypePermission.ObjectPermissions.Add(currentUserObjectPermission)
                userRole.TypePermissions.Add(userTypePermission)

                Dim validatedObjectTypePermission As SecuritySystemTypePermissionObject = ObjectSpace.CreateObject(Of SecuritySystemTypePermissionObject)()
                validatedObjectTypePermission.TargetType = GetType(ValidatedObject)
                validatedObjectTypePermission.AllowWrite = True
                validatedObjectTypePermission.AllowNavigate = True
                validatedObjectTypePermission.AllowCreate = True
                validatedObjectTypePermission.AllowDelete = True
                validatedObjectTypePermission.AllowRead = True

                userRole.TypePermissions.Add(validatedObjectTypePermission)

                Dim companyTypePermission As SecuritySystemTypePermissionObject = ObjectSpace.CreateObject(Of SecuritySystemTypePermissionObject)()
                companyTypePermission.TargetType = GetType(Company)
                companyTypePermission.AllowRead = True

                userRole.TypePermissions.Add(companyTypePermission)
            End If

            Dim admin As Employee = ObjectSpace.CreateObject(Of Employee)()
            admin.UserName = "Administrator"
            admin.SetPassword("")
            admin.Roles.Add(adminRole)
            admin.Save()

            Dim company1 As Company = ObjectSpace.CreateObject(Of Company)()
            company1.Name = "Company 1"
            company1.Employees.Add(admin)
            company1.Save()

            Dim user As Employee = ObjectSpace.CreateObject(Of Employee)()
            user.UserName = "Sam"
            user.SetPassword("")
            user.Roles.Add(userRole)
            user.Save()

            Dim user2 As Employee = ObjectSpace.CreateObject(Of Employee)()
            user2.UserName = "John"
            user2.SetPassword("")
            user2.Roles.Add(userRole)
            user2.Save()

            Dim company2 As Company = ObjectSpace.CreateObject(Of Company)()
            company2.Name = "Company 2"
            company2.Employees.Add(user)
            company2.Employees.Add(user2)
            company2.Save()
         End If

      End Sub
   End Class
End Namespace
