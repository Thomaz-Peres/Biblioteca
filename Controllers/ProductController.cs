using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

[Route("products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public string Get()
    {
        return "GET";
    }

    [HttpGet]
    [Route("{genero}")]
    public string GetByGenero(string genero)
    {
        return genero;
    }

    [HttpPost]
    [Route("")]
    public Product Post([FromBody]Product model)
    {
        return model;
    }

    [HttpPut]
    [Route("")]
    public string Put()
    {
        return "PUT";
    }

    [HttpDelete]
    [Route("")]
    public string Delete()
    {
        return "DELETE";
    }
}