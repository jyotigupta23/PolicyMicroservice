using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Policy_Microservice.Services;
using Policy_Microservice.Model;

namespace Policy_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Policy_List_By_Consumer_IdController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(DeleteAvesByPolicyIdController));

        private readonly IPolicy_List_By_Consumer_IdService policy_List_By_Consumer_IdService;
        public Policy_List_By_Consumer_IdController(IPolicy_List_By_Consumer_IdService policy_List_By_Consumer_IdServices)
        {
            policy_List_By_Consumer_IdService = policy_List_By_Consumer_IdServices;
            _log4net.Info("Initiating The Policy_List_By_Consumer_IdController for assigning policy to the property......This Is Part Of Policy Microservice");
            _log4net.Info("DateTime : " + DateTime.Now);
        }

        [HttpGet()]
        [Route("GetAves/{Property_Id}")]
        public List<Aves> GetAves(int Property_Id)
        {
            _log4net.Info("Getting The List Of The Aves - Entity That Stores The Assigned Policies And Property Data......");
            return policy_List_By_Consumer_IdService.GetAves(Property_Id);
        }

        [HttpDelete()]
        [Route("DeleteAvesByPropertyId/{Property_Id}")]
        public void DeleteAvesByPropertyId(int Property_Id)
        {
            _log4net.Info("Deleting The Aves Entity By Property_Id......");
            policy_List_By_Consumer_IdService.DeleteAvesByPropertyId(Property_Id);
        }
    }
}
