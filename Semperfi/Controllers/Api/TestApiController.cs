using Semperfi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Semperfi.Controllers.Api
{
    [RoutePrefix("api/test")]
    public class TestApiController : ApiController
    {
        [Route, HttpDelete]
        public HttpResponseMessage Delete()
        {

            string Name = "Jimmy";

            TestService.Delete(Name);

            return Request.CreateResponse(HttpStatusCode.OK, "deleted");
        }
    }
}
