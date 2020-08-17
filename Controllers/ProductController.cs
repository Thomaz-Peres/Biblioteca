using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("obras")]
public class ProductController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Product>>> Get([FromServices]DataContext context)
    {
        var produtos = await context.Products.AsNoTracking().ToListAsync();
        return Ok(produtos);
    }

    [HttpGet]
    [Route("{genero}")]
    public async Task<ActionResult<Product>> GetByGenero(
        string genero,
        [FromServices]DataContext context)
    {
        var products = await context.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Genero == genero);
        return Ok(products); 
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<List<Product>>> Post(
        [FromBody]Product model,
        [FromServices]DataContext context)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        try
        {
            context.Products.Add(model);
            await context.SaveChangesAsync();
            return Ok(model);
        }
        catch (Exception)
        {
            return BadRequest (new { message = "Não foi possivel criar o livro" });
        }
    }

    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Product>>> Put(int id, 
        [FromBody]Product model,
        [FromServices]DataContext context)
    {
        if (id != model.Id)
            return NotFound(new { message = "Livro não encontrada" });

        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        try{
            context.Entry<Product>(model).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(model);
        }
        catch (Exception)
        {
            return BadRequest(new { message = "Não foi possivel atualizar o livro" });
        }
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Product>>> Delete(
        int id,
        [FromServices]DataContext context)
    {
        var product = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
                return NotFound(new { message = "Livro não encontrado" });
                
        try
        {
            context.Products.Remove(product);
            await context.SaveChangesAsync();
            return Ok(new { message = "Livro removido com sucesso" });
        }
        catch (Exception)
        {
            return BadRequest(new { message = "Não foi possivel remover o livro" });
        }
    }
}