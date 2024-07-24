namespace FrontStore.Application.Exceptions;

public class OutOfStockException(string message) : ApiException(message, 409)
{
    
}