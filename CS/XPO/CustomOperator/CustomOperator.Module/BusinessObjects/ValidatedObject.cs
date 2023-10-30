using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace CustomFunctionCriteriaOperator.Module.BusinessObjects {
   [DefaultClassOptions]
   [RuleCriteria("", DefaultContexts.Save, "Company.Oid = CurrentCompanyOid()")]
   public class ValidatedObject : BaseObject {
      public ValidatedObject(Session session)
         : base(session) {}
      public override void AfterConstruction() {
         base.AfterConstruction();
      }
      private Company company;
      public Company Company {
         get {
            return company;
         }
         set {
            SetPropertyValue("Company", ref company, value);
         }
      }
      private string name;
      public string Name {
          get {
              return name;
          }
          set {
              SetPropertyValue("Name", ref name, value);
          }
      }
   }

}
