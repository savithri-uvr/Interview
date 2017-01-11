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
        public void Get()
        {
            
        }

        // GET api/reversestring/5
        public string GetStringReverse(string strInputString)
        {
            string strReverse = string.Empty;
            for (int i = strInputString.ToCharArray().Length - 1; i >= 0; i--)
            {
                strReverse = strReverse + strInputString[i];
            }
            return strReverse;
        }

        // POST api/reversestring
        public void Post([FromBody]string value)
        {
        }

        // PUT api/reversestring/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/reversestring/5
        public void Delete(int id)
        {
        }
    }
}
