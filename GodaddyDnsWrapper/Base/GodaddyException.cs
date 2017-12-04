using System;
using System.Net;
using GodaddyDnsWrapper.Responses;

namespace GodaddyDnsWrapper.Base
{
    public class GodaddyException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }
        public ErrorResponse ErrorResponse { get; private set; }

        public GodaddyException(HttpStatusCode statusCode, ErrorResponse errorResponse, string content) : base(content)
        {
            StatusCode = statusCode;
            ErrorResponse = errorResponse;
        }

    }
}
