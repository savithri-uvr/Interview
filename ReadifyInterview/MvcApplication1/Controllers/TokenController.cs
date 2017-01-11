using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class TokenController : ApiController
    {
        // GET api/token
        public string Get()
        {
            return "824ba76e-7f33-4af3-ab67-06ba9679fb36";
        }

        // GET api/token/5
        public string WhatIsYourToken(string strInputValue)
        {
            return strInputValue;
        }
    }
}
