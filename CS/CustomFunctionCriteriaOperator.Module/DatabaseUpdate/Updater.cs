using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;

using CustomFunctionCriteriaOperator.Module.BusinessObjects;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp.Security.Strategy.PermissionMatrix;

namespace CustomFunctionCriteriaOperator.Module.DatabaseUpdate {
   public class Updater : ModuleUpdater {
      public Updater(IObjectSpace objectSpace, Version currentDBVersion)
         : base(objectSpace, currentDBVersion) {
      }
      public override void UpdateDatabaseAfterUpdateSchema() {
         base.UpdateDatabaseAfterUpdateSchema();

         if (ObjectSpace.CreateCollection(typeof(Company)).Count == 0) {

             SecuritySystemRole adminRole = ObjectSpace.FindObject<SecuritySystemRole>(new BinaryOperator("Name", SecurityStrategy.AdministratorRoleName));
            if (adminRole == null) {
                adminRole = ObjectSpace.CreateObject<SecuritySystemRole>();
                adminRole.Name = SecurityStrategy.AdministratorRoleName;
                adminRole.IsAdministrative = true;
            }
            SecuritySystemRole userRole = ObjectSpace.FindObject<SecuritySystemRole>(new BinaryOperator("Name", "User"));
            if (userRole == null) {
                userRole = ObjectSpace.CreateObject<SecuritySystemRole>();
                userRole.Name = "User";
                SecuritySystemTypePermissionObject userTypePermission =
            ObjectSpace.CreateObject<SecuritySystemTypePermissionObject>();
                userTypePermission.TargetType = typeof(SecuritySystemUser);                
                SecuritySystemObjectPermissionsObject currentUserObjectPermission =
                    ObjectSpace.CreateObject<SecuritySystemObjectPermissionsObject>();
                currentUserObjectPermission.Criteria = "[Oid] = CurrentUserId()";
                currentUserObjectPermission.AllowNavigate = true;
                currentUserObjectPermission.AllowRead = true;
                userTypePermission.ObjectPermissions.Add(currentUserObjectPermission);
                userRole.TypePermissions.Add(userTypePermission);
                
                SecuritySystemTypePermissionObject validatedObjectTypePermission =
ObjectSpace.CreateObject<SecuritySystemTypePermissionObject>();
                validatedObjectTypePermission.TargetType = typeof(ValidatedObject);
                validatedObjectTypePermission.AllowWrite = true;
                validatedObjectTypePermission.AllowNavigate = true;
                validatedObjectTypePermission.AllowCreate = true;
                validatedObjectTypePermission.AllowDelete = true;
                validatedObjectTypePermission.AllowRead = true;
                
                userRole.TypePermissions.Add(validatedObjectTypePermission);

                SecuritySystemTypePermissionObject companyTypePermission =
ObjectSpace.CreateObject<SecuritySystemTypePermissionObject>();
                companyTypePermission.TargetType = typeof(Company);
                companyTypePermission.AllowRead = true;

                userRole.TypePermissions.Add(companyTypePermission);
            }

            Employee admin = ObjectSpace.CreateObject<Employee>();
            admin.UserName = "Administrator";
            admin.SetPassword("");
            admin.Roles.Add(adminRole);
            admin.Save();

            Company company1 = ObjectSpace.CreateObject<Company>();
            company1.Name = "Company 1";
            company1.Employees.Add(admin);
            company1.Save();

            Employee user = ObjectSpace.CreateObject<Employee>();
            user.UserName = "Sam";
            user.SetPassword("");
            user.Roles.Add(userRole);
            user.Save();

            Employee user2 = ObjectSpace.CreateObject<Employee>();
            user2.UserName = "John";
            user2.SetPassword("");
            user2.Roles.Add(userRole);
            user2.Save();

            Company company2 = ObjectSpace.CreateObject<Company>();
            company2.Name = "Company 2";
            company2.Employees.Add(user);
            company2.Employees.Add(user2);
            company2.Save();
         }

      }
   }
}
