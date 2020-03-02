using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponse
{
    public class Client
    {
        IHandler login = new LoginCheckHandler();
        IHandler password = new PasswordCheckHandler();
        IHandler position = new PositionCheckHandler();

        public Client(IRequest request)
        {
            login.SetNext(password);
            password.SetNext(position);
            login.Handle(request);
        }
    }
}
