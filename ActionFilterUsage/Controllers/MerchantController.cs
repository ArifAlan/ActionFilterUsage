using ActionFilterUsage.ActionFilters;
using ActionFilterUsage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilterUsage.Controllers
{
    [Route("api/{merchantCode}/[controller]")]
    [ApiController]
    
    public class MerchantController : BaseController
    {
        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers(string merchantCode)
        {
            return Ok($"Users returned for Merchant {merchantCode}. Page:{Page}.PageSize:{PageSize}");
        }

        [HttpPost]
      
        public IActionResult UpdateMerchant(UpdateMerchantRequestModel reqModel)
        {
            return Ok($"Merchant updated.Name:{reqModel.Name}, MerchantCode:{reqModel.MerchantCode}");
        }
    }
}
