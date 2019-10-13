﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MvcAuthWalkthrough.ApiControllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[]
            {
                "Red",
                "Green",
                "Blue"
            };
        }
    }
}