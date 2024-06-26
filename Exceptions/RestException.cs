﻿using System;
using System.Net;

namespace CQRSMediatR.Exceptions
{
    public class RestException : Exception
    {
        public HttpStatusCode Code { get; set; }
        public object Errors { get; set; }

        public RestException(HttpStatusCode code, object errors = null)
        {
            Code = code;
            Errors = errors;
        }
    }
}
