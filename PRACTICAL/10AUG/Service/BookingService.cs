using _10AUG.Data;
using _10AUG.Model;
using _10AUG.Repository;

namespace _10AUG.Service
{
    public class BookingService : IBookingService
    {
        private readonly AppDbContext context;

        public BookingService(AppDbContext context)
        {
            this.context = context;
        }
        public Booking CreateBooking(Booking booking)
        {
            if (booking.TravelDate.Date < DateTime.UtcNow.Date)
                throw new ArgumentException("Travel date cannot be in the past");

            var bus=context.Buses.FirstOrDefault(b=> b.Id == b.Id);
            if (bus == null)
                throw new ArgumentException("Invalid Bus");

            if (booking.SeatNumber > bus.TotalStates)
                throw new ArgumentException("Seat number must be between 1 to 50");

            var state= context.States.FirstOrDefault(s=> s.Id ==s.Id);
            if (state == null)
                throw new ArgumentException("Invalid destination state");

            var searAlreadyBooked= context.bookings.Any(b=> b.Id ==b.Id && b.TravelDate ==booking.TravelDate && b.SeatNumber==booking.SeatNumber);
            if (searAlreadyBooked)
                throw new ArgumentException("This seat is already booked for the selected date");

            var passenger = new Passenger();
            context.Passengers.Add(passenger);
            var bookings=new Booking();
            context.bookings.Add(booking);
            context.SaveChanges();

            return booking;
        }

        public Booking? GetBookingById(int id)
        {
            return context.bookings.Find(id);
          
        }

        public List<Booking> GetBookings()
        {
            return context.bookings.ToList();
           
        }
    }
}
