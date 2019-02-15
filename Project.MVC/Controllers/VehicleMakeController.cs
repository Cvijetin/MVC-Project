using Model.DTO;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace Project.MVC.Controllers
{
    [RoutePrefix("api/vehicleMakes")]
    public class VehicleMakeController : ApiController
    {
        private VehicleMakeService vehicleMakeService = new VehicleMakeService();
        // GET: VehicleMake
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetStocktakings()
        {
            try
            {
                var result = vehicleMakeService.GetVehicleMakeInfo();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("vehicleMakeItem")]
        [HttpPost]
        public IHttpActionResult AddNewVehicleMake(VehicleMakeDTO createItemModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vehicleMakeService.CreateNewVehicleMake(createItemModel);
                    return Ok();
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}