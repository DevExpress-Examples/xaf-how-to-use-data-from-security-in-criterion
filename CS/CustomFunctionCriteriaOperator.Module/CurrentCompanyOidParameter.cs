using System;
using System.Collections.Generic;
using System.Text;

using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using CustomFunctionCriteriaOperator.Module.BusinessObjects;

namespace CustomFunctionCriteriaOperator.Module {
   public class CurrentCompanyOidOperator : ICustomFunctionOperator {
      public string Name {
         get {
            return "CurrentCompanyOid";
         }
      }
      public object Evaluate(params object[] operands) {
         return ((Employee)SecuritySystem.CurrentUser).Company.Oid;
      }
      public Type ResultType(params Type[] operands) {
         return typeof(object);
      }
      static CurrentCompanyOidOperator() {
         CurrentCompanyOidOperator instance = new CurrentCompanyOidOperator();
         if (CriteriaOperator.GetCustomFunction(instance.Name) == null) {
            CriteriaOperator.RegisterCustomFunction(instance);
         }
      }
      public static void Register() {
      }
   }
}
