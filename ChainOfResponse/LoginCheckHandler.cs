using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponse
{
    public class LoginCheckHandler : BaseHandler
    {
        public override void HandleInternal(IRequest request)
        {
            if (request.Login != string.Empty)
            {
                Console.WriteLine("Login is OK");
            }
            else if (request.Login == string.Empty)
            {
                Console.WriteLine("Login is BAD");
            }
        }
    }
}
