using CustomOperatorEF.Module.BusinessObjects;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.Collections.ObjectModel;

namespace CustomFunctionCriteriaOperator.Module.BusinessObjects {
    [DefaultClassOptions()]
    public class Company : BaseObject {
        public virtual string Name { get; set; }
        public virtual IList<ApplicationUser> ApplicationUsers { get; set; } = new ObservableCollection<ApplicationUser>();
    }
}
