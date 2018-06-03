using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace EasyBeer.Controllers
{
    [Route("api/[controller]")]
    public class BuscapeSearchController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get(string name) 
        {
            return new string[] { "Hello", "World", "?", name};
        }
    }
}