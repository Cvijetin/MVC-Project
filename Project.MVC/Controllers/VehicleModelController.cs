using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Project.MVC.Controllers
{
    [RoutePrefix("api/vehicleModel")]
    public class VehicleModelController : ApiController
    {
        private VehicleModelService vehicleModelService = new VehicleModelService();
        // GET: VehicleModel
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetStocktakings()
        {
            try
            {
                var result = vehicleModelService.GetVehicleModelInfo();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}