using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace MvcApplication1.Controllers
{
    public class FibonacciController : ApiController
    {
        // GET api/fibonacci
        public string Get()
        {
            return "Hello";
        }

        
        // GET api/fibonacci/5
        public long GetValueAtN(int n)
        {
            int iReturnValue = 0;
            int i = 0;
            int j = 1;

            for (int iStartIndex = 0; iStartIndex <= n; iStartIndex++)
            {
                iReturnValue = i;
                i = j;
                j = iReturnValue + j;

            }
            return iReturnValue;
        
        }
    }
}
