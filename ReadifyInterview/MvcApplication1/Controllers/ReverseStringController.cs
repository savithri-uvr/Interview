using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class ReverseStringController : ApiController
    {
        // GET api/reversestring
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/reversestring/5
        [HttpGet]
        public string GetStringReverse(string strInputString)
        {
            string strReverse = string.Empty;
            for (int i = strInputString.ToCharArray().Length - 1; i >= 0; i--)
            {
                strReverse = strReverse + strInputString[i];
            }
            return strReverse;
        }
    }
}
