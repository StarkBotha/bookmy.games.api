namespace bookmy.games.api.Exceptions;

public class ResponseEnvelope<T>
{
    public bool IsError { get; set; }
    public string? ErrorMessage { get; set; }
    public T? Payload { get; set; }
}
