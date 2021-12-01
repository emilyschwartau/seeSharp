using seeSharp.Models;
using seeSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace seeSharp.Controllers;

[ApiController]
//controller is the route name
[Route("[controller]")]
public class GlassesController : ControllerBase
{
    //Dane's solve
    //private List<Glasses> Glasses = new List<Glasses>();


    public GlassesController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Glasses>> GetAll() =>
        GlassesService.GetAll();

    //Dane's solve
    //[HttpGet]
    //public ActionResult<List<Glasses>> Get() {
    // return Glasses;    
    //}

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
       [HttpPost]
    public IActionResult Create(Glasses glasses)
    {            
        GlassesService.Add(glasses);
        return CreatedAtAction(nameof(Create), new { id = glasses.Id }, glasses);    
    }

    // PUT action

    // DELETE action
}