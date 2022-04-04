using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Policy_Microservice.Model;
using Policy_Microservice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Policy_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class AutomaticController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AutomaticController));
        public readonly IAutomaticService automaticService;
        public AutomaticController(IAutomaticService automaticServices)
        {
            automaticService = automaticServices;
            _log4net.Info("Initiating AutomaticController Of The Policy Microservice......");
            _log4net.Info("DateTime : " + DateTime.Now.ToString());
        }

        [HttpPost("IssuePolicy")]
        public void IssuePolicy([FromBody] AvesMeta data)
        {
            automaticService.IssuePolicy(data);
            _log4net.Info("Issuing The Policy To The Consumer......");
        }

        [HttpDelete()]
        [Route("DeletePoliciesByConsumerId/{Consumer_Id}")]
        public ActionResult DeletePoliciesByConsumerId(int Consumer_Id)
        {
            automaticService.DeletePoliciesByConsumerId(Consumer_Id);
            _log4net.Info("Deleting Policies By The Consumer ID......");
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
