using AppApi.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppApi.Presentation.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        //https://localhost:7243/api/v1/Category
        [HttpGet]
        public List<CategoryDto> Products()
        {
            var categories = new List<CategoryDto>
            {
                new CategoryDto { Id=1, Name = "Elektronik" },
                new CategoryDto { Id=2, Name = "Giyim"},
                new CategoryDto { Id=3, Name = "Beyaz Eşya"},
                new CategoryDto { Id=4, Name = "Kozmetik"},
            };

            return categories;
        }


    }
}