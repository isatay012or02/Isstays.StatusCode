using System.ComponentModel.DataAnnotations;

namespace Issatays.StatusCode.Models;

public class ResultCode
{
    [Key]
    public int Code { get; set; }
    
    public string Type { get; set; }
    
    public string Description { get; set; }
    
    public string HttpStatusCode { get; set; }
}