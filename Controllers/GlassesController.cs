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

    //Dane's solve
    //[HttpPost]
    //public IActionResult Post(Glasses newGlasses) {
    //GlassesList.Add(newGlasses);

    //return CreateAtAction(nameof(Post), new {Id = newGlasses.Id}, newGlasses);
    //}
    

    // PUT action
        [HttpPut("{id}")]
    public IActionResult Update(int id, Glasses glasses)
    {
    if (id != glasses.Id)
        return BadRequest();

    var existingGlasses = GlassesService.Get(id);
    if(existingGlasses is null)
        return NotFound();

    GlassesService.Update(glasses);           

    return NoContent();    }

    // DELETE action
}