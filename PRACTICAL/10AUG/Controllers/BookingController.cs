using _10AUG.Model;
using _10AUG.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _10AUG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService service;

        public BookingController(IBookingService service)
        {
            this.service =service;
        }

        [HttpPost]
        public IActionResult CreateBooking(Booking booking)
        {
            try
            {
                var result = service.CreateBooking(booking);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetBookings()
        {
            var bookings = service.GetBookings();
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            var booking = service.GetBookingById(id);

            if (booking == null)
            {
                return NotFound("Booking not found");
            }

            return Ok(booking);
        }
    }
}

