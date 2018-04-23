using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

using DevExpress.ExpressApp.Security.Strategy;

namespace CustomFunctionCriteriaOperator.Module.BusinessObjects {
   [DefaultClassOptions(), DefaultProperty("UserName")]
   public class Employee : SecuritySystemUser {
      private Company company;

      public Employee(Session session)
         : base(session) {}

      [Association("Company-Employees", typeof(Company))]
      public Company Company {
         get {
            return company;
         }
         set {
            SetPropertyValue("Company", ref company, value);
         }
      }
   }

}
