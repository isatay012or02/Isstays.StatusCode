using System.ComponentModel.DataAnnotations;

namespace Issatays.StatusCode.Models;

public class ResultCodeMessage
{
    [Key]
    public int Id { get; set; }
    
    public int Code { get; set; }
    
    public string Language { get; set; }
    
    public string ClientMessage { get; set; }
    
    public string UserMessage { get; set; }
    
    public string Title { get; set; }
}