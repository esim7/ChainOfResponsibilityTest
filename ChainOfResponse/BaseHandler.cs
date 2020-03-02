using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponse
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler;
        public void Handle(IRequest request)
        {
            HandleInternal(request);
            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }

        public abstract void HandleInternal(IRequest request);

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
