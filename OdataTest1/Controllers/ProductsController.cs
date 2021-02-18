using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OdataTest1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;

namespace OdataTest1.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController :ODataController

    {

        public string GetName([FromODataUri] int key)
        {
            return "test3";
        }
        public string GetName2([FromODataUri] int key)
        {
            return "test4";
        }
    }
}
