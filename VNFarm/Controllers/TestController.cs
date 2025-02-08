using Microsoft.AspNetCore.Mvc;
using VNFarm.Core.DTOs.Filters;

namespace VNFarm.Web.VNFarm.Controllers
{
    public class A
    {
        public int a { get; set; }
        public string b { get; set; }
        public List<int> c { get; set; }
    }
    [Route("api")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Test([FromQuery]A test)
        {
            return Ok(test);
        }
    }
}
