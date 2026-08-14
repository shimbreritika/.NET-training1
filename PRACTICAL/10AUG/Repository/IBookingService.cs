using _10AUG.Model;

namespace _10AUG.Repository
{
    public interface IBookingService
    {
        Booking CreateBooking(Booking booking);

        List<Booking> GetBookings();

        Booking? GetBookingById(int id);
    }
}
