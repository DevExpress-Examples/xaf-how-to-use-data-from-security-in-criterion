
#Application CustomFunctionCriteriaOperator.Win
#Application CustomFunctionCriteriaOperator.Web

*Action Log On

*Action New(Validated Object)

*FillForm
 Company = Company 1
*Action Save
*CheckValidationResult
 Message = Problems were detected during data validation. * 
*OptionalAction Close

*FillForm
 Company = Company 2
*Action Save
!CheckValidationResult
 Message = ?*
