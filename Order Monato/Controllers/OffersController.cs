using Order_Monato.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Order_Monato.Controllers
{
    [RoutePrefix("api/Offers")]
    public class OffersController : ApiController
    {
            
        [HttpGet]
        [Route("GetUser")]
        public IHttpActionResult GetOffers()
        {
            try
            {
                var offerManagementBo = new OfferManagementBo();
                return Ok(offerManagementBo.GetOffers());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
