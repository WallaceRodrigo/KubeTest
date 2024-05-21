using System.Text.Json;
using KubeTest.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KubeTest.Controllers;

[ApiController]
public class KubeTestController : ControllerBase
{
    private readonly KubeTestContext _dbContext;

    public KubeTestController(KubeTestContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("/")]
    public async Task<IActionResult> Run()
    {
        _dbContext.MyEntities.Add(new MyEntity{Name = "hello World"});
        await _dbContext.SaveChangesAsync();

        var response = JsonSerializer.Serialize(_dbContext.MyEntities.ToListAsync());
        
        return new OkObjectResult(response);
    }   
}