using CustomOperatorEF.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.XtraReports.Design;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOperatorEF.Module {
    
    public class CurrentCompanyOidOperator : ICustomFunctionOperator {
        public string Name {
            get { return FUNCTION_NAME; }
        }
        public const string FUNCTION_NAME = "CurrentCompanyOid";
        static CurrentCompanyOidOperator() {
            CurrentCompanyOidOperator instance = new CurrentCompanyOidOperator();
            if (CriteriaOperator.GetCustomFunction(instance.Name) == null) {
                CriteriaOperator.RegisterCustomFunction(instance);
            }
        }
        public static void Register() { }
        public object Evaluate(params object[] operands) {
            return CurrentOrgIdFunctionCore(SecuritySystem.Instance);
        }
        public static void Evaluate(CustomCriteriaOperatorPatcherContext context) {
            context.Result = new ConstantValue(CurrentOrgIdFunctionCore(context.Security));
        }
        public static bool CanEvaluate(CustomCriteriaOperatorPatcherContext context) {
            if (context.Operator is FunctionOperator functionOperator) {
                return functionOperator.Operands.Count == 1 &&
                                FUNCTION_NAME.Equals((functionOperator.Operands[0] as ConstantValue)?.Value?.ToString(), StringComparison.InvariantCultureIgnoreCase);
            }
            return false;
        }
        private static Guid CurrentOrgIdFunctionCore(ISecurityStrategyBase security) => ((ApplicationUser)security.User)?.Company?.ID ?? Guid.Empty;
        public Type ResultType(params Type[] operands) {
            return typeof(Guid);
        }
    }
}
