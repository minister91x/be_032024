using DataAccess.NetCore.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_032024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        private readonly IPostDAO _postDAO;
        public HomeController(IConfiguration configuration, IPostDAO postDAO)//tiêm vào contructor
        {
            _configuration = configuration;
            _postDAO = postDAO;
        }


        [HttpPost("GetPost")]

        public async Task<ActionResult> GetPost()
        {
            try
            {
                var listPost = await _postDAO.GetPost();

                return Ok(listPost);
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
