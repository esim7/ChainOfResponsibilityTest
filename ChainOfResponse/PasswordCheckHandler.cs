using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponse
{
    public class PasswordCheckHandler : BaseHandler
    {
        public override void HandleInternal(IRequest request)
        {
            if (request.Password != string.Empty)
            {
                Console.WriteLine("Password is OK");
            }
            else if (request.Password == string.Empty)
            {
                Console.WriteLine("Password is BAD");
            }
        }
    }
}
