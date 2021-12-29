using BL;
using DTO;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/user/v1")]
    public class UserController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<UserDTO> Get()
        {
            return UserBL.GetUsers();
        }

        // GET api/<controller>/5
        public UserDTO Get(int id)
        {
            return UserBL.GetUser(id);
        }

        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login([FromBody]JObject loginDetails)
        {
            var email = loginDetails["email"].ToObject<string>();
            var password = loginDetails["password"].ToObject<string>();
            var user = UserBL.Login(email, password);
            return Ok(user);
        }


        [HttpPost]
        [Route("register")]
        public IHttpActionResult Register([FromBody]UserDTO user)
        {
            var registeredUser = UserBL.AddUser(user);
            return Ok(registeredUser);
        }

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}