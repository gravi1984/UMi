using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Umi.API.Controllers
{
    
    
    [Route("api/manualapi")]
    // [Controller]
    public class ManualAPIController : Controller
    {
        // TODO: go through Controller doc

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]{"manual","api"};
        }
        
    }
}