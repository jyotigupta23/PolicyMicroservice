using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Policy_Microservice.Services;

namespace Policy_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DeleteAvesByPolicyIdController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(DeleteAvesByPolicyIdController));

        private readonly IDeleteAvesByPolicyIdService service;
        public DeleteAvesByPolicyIdController(IDeleteAvesByPolicyIdService services) 
        {
            service = services;
            _log4net.Info("Initiating The DeleteAvesByPolicyIdController for assigning policy to the property......This Is Part Of Policy Microservice");
            _log4net.Info("DateTime : " + DateTime.Now);
        }

        [HttpDelete()]
        [Route("DeleteAves/{Policy_Id}")]
        public ActionResult DeleteAves(int Policy_Id)
        {
            service.DeleteAves(Policy_Id);
            _log4net.Info("Deleting The Aves - The Assigned Stuffs......");
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
