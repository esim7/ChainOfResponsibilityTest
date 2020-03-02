using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponse
{
    public class Request : IRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
    }
}
