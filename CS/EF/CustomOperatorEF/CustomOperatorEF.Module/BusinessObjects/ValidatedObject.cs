using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;

namespace CustomFunctionCriteriaOperator.Module.BusinessObjects {
    [DefaultClassOptions]
    [RuleCriteria("", DefaultContexts.Save, "Company.ID = CurrentCompanyOid()", SkipNullOrEmptyValues = false)]
    public class ValidatedObject : BaseObject {
        public virtual Company Company { get; set; }
        public virtual string Name { get; set; }
    }

}
