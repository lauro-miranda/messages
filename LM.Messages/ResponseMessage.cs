using System;

namespace LM.Messages
{
    public abstract class ResponseMessage
    {
        protected ResponseMessage(Guid responseCode)
        {
            ResponseCode = responseCode;
        }

        public Guid ResponseCode { get; }
    }
}