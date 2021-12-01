using seeSharp.Models;
using seeSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace seeSharp.Controllers;

[ApiController]
[Route("[controller]")]
public class GlassesController : ControllerBase
{
    public GlassesController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Glasses>> GetAll() =>
        GlassesService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Glasses> Get(int id)
    {
    var glasses = GlassesService.Get(id);

    if(glasses == null)
        return NotFound();

    return glasses;
    }

    // POST action

    // PUT action

    // DELETE action
}