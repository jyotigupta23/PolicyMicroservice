using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Policy_Microservice.Model;
using Policy_Microservice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Policy_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PolicyController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(PolicyController));

        private readonly IPolicyService policyService;
        public PolicyController(IPolicyService poilicyServices)
        {
            policyService = poilicyServices;
            _log4net.Info("Initiating PolicyController Of The Policy Microservice......");
            _log4net.Info("DateTime : " + DateTime.Now.ToString());
        }

        [HttpGet("GetPolicies")]
        public List<Policy> GetPolicies()
        {
            _log4net.Info("Returning Policies");
            return policyService.GetPolicies();
        }

        [HttpPost("AddPolicy")]
        public ActionResult AddPolicy([FromBody] Policy data)
        {
            policyService.AddPolicy(data);
            _log4net.Info("Adding Policies");
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpPut("UpdatePolicy")]
        public ActionResult UpdatePolicy([FromBody] Policy data)
        {
            policyService.UpdatePolicy(data);
            _log4net.Info("Updating Policy");
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpDelete()]
        [Route("DeletePolicy/{id}")]
        public ActionResult DeletePolicy(int id)
        {
            policyService.DeletePolicy(id);
            _log4net.Info("Deleting Policiy Having ID : " + id);
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpGet()]
        [Route("GetPolicyDataMethod/{id}")]
        public Policy GetPolicyDataMethod(int id)
        {
            _log4net.Info("Returning Policy By ID : " + id);
            return policyService.GetPolicyDataMethod(id);
        }
    }
}