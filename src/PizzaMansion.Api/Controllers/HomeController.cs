﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaMansion.Api.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("hello world api");
        }
    }
}
