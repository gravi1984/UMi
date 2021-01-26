using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Umi.API.Controllers
{
    [Route("api/[controller]")]
    public class TestAPIController : Controller
    {
        // GET
        public IActionResult Index()
        {
            // return View();
            return null;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]{"v1", "v2"};
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        

        
    }
}