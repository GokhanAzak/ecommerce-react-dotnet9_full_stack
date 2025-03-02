using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProductsController:ControllerBase
{

private readonly DataContext _contex;
public ProductsController(DataContext context)
{
    _contex  =context;
}





[HttpGet]
public  async Task<IActionResult> GetProducts()
{

var products =  await _contex.Products.ToListAsync();

return Ok(products);



}
[HttpGet("{id}")]
public  async Task< IActionResult> GetProduct(int? id)
{
    if(id==null)
    {
        return NotFound();
    }
    
   var product =await _contex.Products.FirstOrDefaultAsync(i=>i.Id ==id);

    if(product ==null)
    {


    return NotFound();
    }


    return Ok(product);
 }
 

}
    








