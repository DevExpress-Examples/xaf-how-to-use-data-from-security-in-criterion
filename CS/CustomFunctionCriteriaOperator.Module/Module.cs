using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using System.Reflection;


namespace CustomFunctionCriteriaOperator.Module {
   public sealed partial class CustomFunctionCriteriaOperatorModule : ModuleBase {
      public CustomFunctionCriteriaOperatorModule() {
         InitializeComponent();
         CurrentCompanyOidOperator.Register();
      }
   }
}
