using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ActionResultBug
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public object Index()
        {
            return new JsonResult(new {test = 123});
        }
    }
}
