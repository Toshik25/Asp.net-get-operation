using Crud_operation.DataAccess;
using Crud_operation.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Crud_operation.Controllers
{
    public class CrudApiController : ApiController
    {

        [HttpGet]
        [Route("api/v1/Crud/GetCrud")]
        public IHttpActionResult Get()
        {
            try
            {
                CrudLookup getdata = new CrudLookup();
                var result = getdata.GetCrud();
                return Ok(result);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
