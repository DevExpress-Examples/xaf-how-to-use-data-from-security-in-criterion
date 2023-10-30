using DevExpress.ExpressApp.Core;
using DevExpress.ExpressApp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CustomFunctionCriteriaOperator.Module.BusinessObjects;
using DevExpress.Persistent.Validation;
using DevExpress.Data.Filtering;

namespace CustomOperator.WebApi.API {
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomEndpointController : ControllerBase {
        IObjectSpaceFactory objectSpaceFactory;
        public CustomEndpointController(IObjectSpaceFactory objectSpaceFactory, IValidator validator) {
            this.objectSpaceFactory = objectSpaceFactory;
            this.validator = validator;
        }
        readonly IValidator validator;
        [HttpGet]
        public IActionResult Get() {
            IObjectSpace newObjectSpace = objectSpaceFactory.CreateObjectSpace<ValidatedObject>();

            var obj = newObjectSpace.CreateObject<ValidatedObject>();
            var validationResult = validator.RuleSet.ValidateAllTargets(newObjectSpace, new object[] { obj }, DefaultContexts.Save);

            var compAdm = newObjectSpace.FindObject<Company>(CriteriaOperator.FromLambda<Company>(c => c.Name == "AdminCompany"));

            obj.Company = compAdm;
            var validationResult2 = validator.RuleSet.ValidateAllTargets(newObjectSpace, new object[] { obj }, DefaultContexts.Save);

            // ...
            return Ok();
        }
        //...
    }
}
