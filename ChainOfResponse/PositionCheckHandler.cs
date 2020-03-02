using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponse
{
    public class PositionCheckHandler : BaseHandler
    {
        public override void HandleInternal(IRequest request)
        {
            if (request.Position != string.Empty)
            {
                Console.WriteLine("Position is OK");
            }
            else if (request.Position == string.Empty)
            {
                Console.WriteLine("Position is BAD");
            }
        }
    }
}
