using DataAccess.NetCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Security.Claims;

namespace BE_032024.Author
{
    public class EShopAuthorizeAttribute : TypeFilterAttribute
    {
        public EShopAuthorizeAttribute(string functionCode, string permission) : base(typeof(EShopAuthorizeActionFilter))
        {
            Arguments = new object[] { functionCode, permission };
        }
    }

    public class EShopAuthorizeActionFilter : IAsyncAuthorizationFilter
    {
        private readonly string _functionCode;
        private readonly string _permission;
        private IUnitOfWork _unitOfWork;
        public EShopAuthorizeActionFilter(string functionCode, string permission, IUnitOfWork unitOfWork)
        {
            _functionCode = functionCode;
            _permission = permission;
            _unitOfWork = unitOfWork;
        }
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var identity = context.HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;
                if (userClaims.Count() <= 0)
                {
                    context.HttpContext.Response.ContentType = "application/json";
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    context.Result = new JsonResult(new
                    {
                        Code = HttpStatusCode.Unauthorized,
                        Message = "Vui lòng đăng nhập để thực hiện chức năng này "
                    });

                    return;
                }


                var UserId = Convert.ToInt32(userClaims.FirstOrDefault(x => x.Type == ClaimTypes.PrimarySid)?.Value);

                // lấy FunctionId theo FunctionCODE truyền vào 

                var function = await _unitOfWork._userRepository.GetFunctionByCode(_functionCode);
                if (function == null || function.FunctionID <= 0)
                {
                    context.HttpContext.Response.ContentType = "application/json";
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    context.Result = new JsonResult(new
                    {
                        Code = HttpStatusCode.Unauthorized,
                        Message = "Chức năng này không hợp lệ"
                    });

                    return;
                }


                var userFunction = await _unitOfWork._userRepository.UserFunctionGet(UserId, function.FunctionID);


                if (userFunction == null || userFunction.UserFunctionID <= 0)
                {
                    context.HttpContext.Response.ContentType = "application/json";
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    context.Result = new JsonResult(new
                    {
                        Code = HttpStatusCode.Unauthorized,
                        Message = "Chức năng này không hợp lệ"
                    });

                    return;
                }

                switch (_permission)
                {
                    case "VIEW":
                        if (userFunction.IsView == 0)
                        {
                            context.HttpContext.Response.ContentType = "application/json";
                            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                            context.Result = new JsonResult(new
                            {
                                Code = HttpStatusCode.Unauthorized,
                                Message = "Bạn không có quyền thực hiện chức năng này"
                            });

                            return;
                        }
                        break;
                    case "INSERT":
                        if (userFunction.IsInsert == 0)
                        {
                            context.HttpContext.Response.ContentType = "application/json";
                            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                            context.Result = new JsonResult(new
                            {
                                Code = HttpStatusCode.Unauthorized,
                                Message = "Bạn không có quyền thực hiện chức năng này"
                            });

                            return;
                        }
                        break;
                    case "UPDATE":
                        if (userFunction.Isupdate == 0)
                        {
                            context.HttpContext.Response.ContentType = "application/json";
                            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                            context.Result = new JsonResult(new
                            {
                                Code = HttpStatusCode.Unauthorized,
                                Message = "Bạn không có quyền thực hiện chức năng này"
                            });

                            return;
                        }
                        break;

                    case "DELETE":
                        if (userFunction.IsDelete == 0)
                        {
                            context.HttpContext.Response.ContentType = "application/json";
                            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                            context.Result = new JsonResult(new
                            {
                                Code = HttpStatusCode.Unauthorized,
                                Message = "Bạn không có quyền thực hiện chức năng này"
                            });

                            return;
                        }
                        break;
                }


            }
        }
    }
}
