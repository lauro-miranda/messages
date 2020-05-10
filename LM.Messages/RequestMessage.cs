using System;

namespace LM.Messages
{
    public abstract class RequestMessage
    {
        protected RequestMessage(Guid requestCode)
        {
            RequestCode = requestCode;
        }

        public Guid RequestCode { get; }
    }
}