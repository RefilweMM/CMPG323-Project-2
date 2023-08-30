using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace JWTAuthentication.Authentication
{
    public class Response
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
    }
}

