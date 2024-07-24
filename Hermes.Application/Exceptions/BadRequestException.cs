namespace FrontStore.Application.Exceptions;

public class BadRequestException(string message) : ApiException(message, 400);