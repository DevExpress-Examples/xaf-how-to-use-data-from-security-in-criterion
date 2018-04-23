using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace CustomFunctionCriteriaOperator.Module.BusinessObjects {
   [DefaultClassOptions()]
   public class Company : BaseObject {

      public Company(Session session)
         : base(session) {}

      private string name;
      public string Name {
         get {
            return name;
         }
         set {
            SetPropertyValue("Name", ref name, value);
         }
      }

      [Association("Company-Employees", typeof(Employee))]
      public XPCollection Employees {
         get {
            return GetCollection("Employees");
         }
      }
   }
}
