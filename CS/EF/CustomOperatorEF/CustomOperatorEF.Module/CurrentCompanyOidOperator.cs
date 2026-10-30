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
        // XAF replaces this function with a constant in the OnCustomizeSecurityCriteriaOperator handler (see Startup.cs),
        // so in-memory evaluation is not required. Do not use SecuritySystem.Instance here (XAF0035).
        public object Evaluate(params object[] operands) {
            // Called only when a criterion bypasses the Object Space and goes directly to ExpressionEvaluator: in-memory grid filters
            // (WinForms Client/DataView modes, Blazor Client mode) or custom CriteriaOperator evaluation code. To support these cases
            // in WinForms or Blazor (not in the Web API Service), uncomment the previous implementation below and remove the throw statement.
            // The #pragma directives suppress the XAF0035 warning that this code causes:
            //#pragma warning disable XAF0035
            //            return CurrentOrgIdFunctionCore(SecuritySystem.Instance);
            //#pragma warning restore XAF0035
            throw new NotSupportedException($"The {FUNCTION_NAME} function is evaluated by the SecurityOptions.Events.OnCustomizeSecurityCriteriaOperator handler.");
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
