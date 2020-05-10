using System;

namespace LM.Messages
{
    public abstract class RequestMessage
    {
        public RequestMessage() { RequestCode = Guid.NewGuid(); }
        public RequestMessage(Guid requestCode)
        {
            RequestCode = requestCode;
        }

        public Guid RequestCode { get; }
    }
}