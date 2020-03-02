using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponse
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle(IRequest request);
    }
}
