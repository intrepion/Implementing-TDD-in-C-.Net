namespace TicketBookingCore;

public class TicketBookingRequestProcessor
{
    public TicketBookingRequestProcessor(ITicketBookingRepository ticketBookingRepository)  
    {  
    }  

    public TicketBookingResponse Book(TicketBookingRequest? request)
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
