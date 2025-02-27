using API.Entity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProductsController:ControllerBase
{

[HttpGet]
public  IActionResult GetProducts()
{

return Ok(new List<Product>( ){
    new Product
    {Id=1,Name="Iphone 15  ",Description="Telefon Aciklamasi",ImageUrl="1.jpg"
                ,Price=4000,IsActive=true,Stock=100


    },
 new Product
    {Id=2,Name="Iphone 1  ",Description="Telefon Aciklamasi",ImageUrl="1.jpg"
                ,Price=4000,IsActive=true,Stock=100


    }





});

}

[HttpGet("{id}")]
public  IActionResult GetProduct(int id)
{

    return Ok(new 
    
          Product {Id=1,Name="Iphone 15  ",Description="Telefon Aciklamasi",ImageUrl="1.jpg"
                ,Price=4000,IsActive=true,Stock=100}
                
                );

}



}
    








