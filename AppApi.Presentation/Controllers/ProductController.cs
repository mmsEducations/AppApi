using AppApi.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppApi.Presentation.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        /*
            //Kökdizin/api/Product
            //https://localhost:7243/api/v1/Product
            [HttpGet]
            public string Get()
            {
            return "Merhaba Oz Akademi nasılsınız";
            }         
       */

        //Kökdizin/api/Product
        //https://localhost:7243/api/v1/Product
        [HttpGet]
        public List<ProductDto> Products()
        {
            var products = new List<ProductDto>
            {
                new ProductDto { Id=1, Name = "Mause" , Price=300 },
                new ProductDto { Id=2, Name = "Klavye" , Price=500 },
                new ProductDto { Id=3, Name = "iphoe 15" , Price=90000 },
                new ProductDto { Id=4, Name = "iphoe 12" , Price=60000 },
                new ProductDto { Id=5, Name = "Msi Bilgisayar" , Price=45.500m },
            };

            return products;
        }



    }
}
