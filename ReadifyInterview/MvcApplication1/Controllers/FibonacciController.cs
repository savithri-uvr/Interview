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
            return "HEllo";
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
    }
}
