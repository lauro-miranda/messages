using System;

namespace LM.Messages
{
    public abstract class ResponseMessage
    {
        public ResponseMessage() { ResponseCode = Guid.NewGuid(); }
        public ResponseMessage(Guid responseCode)
        {
            ResponseCode = responseCode;
        }

        public Guid ResponseCode { get; }
    }
}