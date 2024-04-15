using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_032024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        [HttpGet("GetConfig")]
        public async Task<ActionResult> GetConfig()
        {
            try
            {
                var values = _configuration["ConnectionStrings:MyConnection"] ?? "";
                return Ok(values);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
