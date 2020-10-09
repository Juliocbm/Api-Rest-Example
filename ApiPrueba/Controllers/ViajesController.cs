using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPrueba.Controllers
{
        /// <summary>
        /// customer controller class for testing security token
        /// </summary>
        [Authorize]
        [RoutePrefix("api/viajes")]
        public class ViajesController : ApiController
        {
            [HttpGet]
            public IHttpActionResult GetId(int id)
            {
                var viajeFake = "viaje-fake";
                return Ok(viajeFake);
            }

            [HttpGet]
            public HttpResponseMessage GetAll()
            {
                var viajesFake = new string[] { "viaje-1", "viaje-2", "viaje-3" };
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, viajesFake);


                return response;
            }
        }
    

}
