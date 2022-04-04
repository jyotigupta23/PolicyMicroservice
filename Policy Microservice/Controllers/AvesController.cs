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
    public class AvesController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AvesController));

        private readonly IAvesService avesService;
        public AvesController(IAvesService avesServices)
        {
            avesService = avesServices;
            _log4net.Info("Initiating The AvesController for assigning policy to the property......This Is Part Of Policy Microservice");
            _log4net.Info("DateTime : " + DateTime.Now);
        }

        [HttpGet("Get")]
        public List<Aves> Get()
        {
            _log4net.Info("Returning The List Of Assigned Stuffs......");
            return avesService.Get();
        }

        [HttpPost("AddAves")]
        public ActionResult AddAves([FromBody] Aves data)
        {
            avesService.AddAves(data);
            _log4net.Info("Assigning Requested Policy To The Property......");
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpPut("UpdateAves")]
        public ActionResult UpdateAves([FromBody] Aves data)
        {
            avesService.UpdateAves(data);
            _log4net.Info("Updating The Assigned Stuffs Called Aves......");
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpDelete()]
        [Route("DeleteAves/{id}")]
        public ActionResult DeleteAves(int id)
        {
            avesService.DeleteAves(id);
            _log4net.Info("Deleting The Assigned Stuffs Called Aves......");
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpGet()]
        [Route("GetAvesDataMethod/{id}")]
        public Aves GetAvesDataMethod(int id)
        {
            _log4net.Info("Getting Aves Data By The Id......");
            return avesService.GetAvesDataMethod(id);
        }
    }
}
