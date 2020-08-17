using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

[Route("obras")]
public class ProductController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Product>>> Get()
    {
        return new List<Product>();
    }

    [HttpGet]
    [Route("{genero}")]
    public async Task<ActionResult<Product>> GetByGenero(string genero)
    {
        return new Product();
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<List<Product>>> Post([FromBody]Product model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        return Ok(model);
    }

    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Product>>> Put(int id, [FromBody]Product model)
    {
        if(id != model.Id)
            return NotFound(new { message = "Categoria nçao encontrada" });

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok();
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Product>>> Delete()
    {
        return Ok("Livro deletado com sucesso");
    }
}