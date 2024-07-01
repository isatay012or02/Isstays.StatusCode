namespace Issatays.StatusCode.Models;

public class MessageByResultCode
{
    public int Code { get; set; }
    
    public string Type { get; set; }
    
    public string Description { get; set; }
    
    public string HttpStatusCode { get; set; }
    
    public string ClientMessage { get; set; }
    
    public string UserMessage { get; set; }
    
    public string Title { get; set; }
}