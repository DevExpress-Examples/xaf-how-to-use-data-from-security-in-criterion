<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3945)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# XAF - How to use data from a securiy user's property in a criterion

This example shows how to use data from the currently logged-in user in a criterion, such as a validation rule.

![image](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-function-criteria-operator-e3945/assets/14300209/979f25d7-23d3-4f60-a30f-18e61f8e0d7b)

## Implementation Details

Since criterion security system data is not accessible, you should patch a criterion using the `DevExpress.ExpressApp.Security.SecurityEvents.OnCustomizeSecurityCriteriaOperator` event. 

```cs{2}
[DefaultClassOptions]
[RuleCriteria("", DefaultContexts.Save, "Company.ID = CurrentCompanyOid()", SkipNullOrEmptyValues = false)]
public class ValidatedObject : BaseObject {
    public virtual Company Company { get; set; }
    public virtual string Name { get; set; }
}

```

```cs{4-12}
builder.Security
    .UseIntegratedMode(options => {
        //...    
        options.Events.OnCustomizeSecurityCriteriaOperator = context => {
            if (context.Operator is FunctionOperator functionOperator) {
                if (functionOperator.Operands.Count == 1 &&
                    "CurrentCompanyOid".Equals((functionOperator.Operands[0] as ConstantValue)?.Value?.ToString(), StringComparison.InvariantCultureIgnoreCase)) {
                    context.Result = new ConstantValue(((ApplicationUser)context.Security.User)?.Company?.ID ?? Guid.NewGuid());
                }
            }
        };
    })
```


## Documentation

- [Core - ValueManager API availability and deprecated static helpers in XAF .NET 6+ apps (Blazor, Web API Service, WinForms)](https://supportcenter.devexpress.com/ticket/details/t1121273/core-valuemanager-api-availability-and-deprecated-static-helpers-in-xaf-net-6-apps)


## Files to Review

- [ValidatedObject.cs](CS/EF/CustomOperatorEF/CustomOperatorEF.Module/BusinessObjects/ValidatedObject.cs)
- [Startup.cs](CS/EF/CustomOperatorEF/CustomOperatorEF.Blazor.Server/Startup.cs)

