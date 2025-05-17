namespace TicketBookingCore;

public class TicketBookingRequestProcessor
{
    public TicketBookingRequestProcessor()
    {
    }

    public static TicketBookingResponse Book(TicketBookingRequest? request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new TicketBookingResponse
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };
    }
}
