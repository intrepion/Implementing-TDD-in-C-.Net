namespace TicketBookingCore.Tests;

public class TicketBookingRequestProcessorTests
{
    [Fact]
    public void ShouldReturnTicketBookingResultWithRequestValues()
    {
        var processor = new TicketBookingRequestProcessor();

        var request = new TicketBookingRequest
        {
            FirstName = "Abdul",
            LastName = "Rahman",
            Email = "abdulrahman@demo.com"
        };
    }
}

internal class TicketBookingRequestProcessor  
{  
    public TicketBookingRequestProcessor()  
    {  
    }  
  
    internal TicketBookingResponse Book(TicketBookingRequest request)  
    {  
      throw new NotImplementedException();  
    }  
} 
