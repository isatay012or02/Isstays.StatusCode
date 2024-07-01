using Issatays.StatusCode.Models;
using Microsoft.EntityFrameworkCore;

namespace Issatays.StatusCode;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Models.ResultCode> ResultCodes { get; set; }
    
    public DbSet<ResultCodeMessage> ResultCodeMessages { get; set; }
}