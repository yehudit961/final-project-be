    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DTO;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/rides/v1")]
    public class RideController : ApiController
    {

        [HttpGet]
        [Route("rides")]

        public IEnumerable<RideDTO> Get()
        {
            return RideBL.GetRides();
        }

        // GET api/<controller>/5
        public IEnumerable<RideDTO> Get(int rideId)
        {
            return RideBL.GetRides();
        }


        // POST api/<controller>
        public void Post([FromBody] RideDTO ride)
        {
            RideBL.AddRide(ride);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] RideDTO ride)
        {
            RideBL.UpdateRide(ride, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            RideBL.DeleteRide(id);
        }
    }
}