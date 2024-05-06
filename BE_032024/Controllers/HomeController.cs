using DataAccess.NetCore.DAO;
using DataAccess.NetCore.DTO;
using DataAccess.NetCore.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_032024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        //private readonly IPostRepository _postDAO;
        //public HomeController(IConfiguration configuration, IPostRepository postDAO)//tiêm vào contructor
        //{
        //    _configuration = configuration;
        //    _postDAO = postDAO;
        //}


        private IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }

        [HttpPost("GetPost")]

        public async Task<ActionResult> GetPost(GetListPostRequestData requestData)
        {
            try
            {
                var listPost = await _unitOfWork._postRepository.GetPost(requestData);

                return Ok(listPost);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost("CreatePost")]
        public async Task<ActionResult> CreatePost(Post post)
        {
            try
            {
                _unitOfWork._postRepository.CreatePost(post);
                var p = new Product
                {
                    ProductName = "P_" + post.PostName
                };

                _unitOfWork._productGenerictRepository.Add(p);

                var rs = _unitOfWork.SaveChange();

                return Ok(rs);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
