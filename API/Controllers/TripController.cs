using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;

namespace API.Controllers
{
    public class TripController : ApiController
    {

        // GET api/<controller>
        public IEnumerable<TripDTO> Get()
        {
            return TripBL.GetTrips();
        }

        // GET api/<controller>/5
        public IEnumerable<TripDTO> Get(int userId)
        {
            return TripBL.GetTripsForUser(userId);
        }


        // POST api/<controller>
        public void Post([FromBody] TripDTO trip)
        {
            TripBL.AddTrip(trip);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] TripDTO trip)
        {
            TripBL.UpdateTrip(trip, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            TripBL.DeleteTrip(id);
        }

    }
}
