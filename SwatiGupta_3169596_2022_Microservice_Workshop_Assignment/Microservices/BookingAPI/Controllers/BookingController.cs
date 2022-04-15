using BookingAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookingAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        /// <summary>
        /// Booking controller
        /// </summary>
        public BookingController()
        {

        }
        
        /// <summary>
        /// Recevice booking request
        /// </summary>
        /// <param name="bookServiceRequest"></param>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public ActionResult BookServiceRequest([FromBody] BookServiceRequest bookServiceRequest)
        {
            if(bookServiceRequest == null)
            {
                return BadRequest();
            }
            else
            {
                return Accepted();
            }
        }
    }
}
