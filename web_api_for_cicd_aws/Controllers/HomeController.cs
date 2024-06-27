using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_api_for_cicd_aws.Controllers
{
    [Route("api/v1/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("name-length")]
        public IActionResult GetNameLength(string name)
        {
            return Ok($"The length of the given name {name} is {name.Length}");
        }
    }
}
