﻿using Microsoft.AspNetCore.Http;
namespace SportsStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue
                ? $"{request.Path}{request.QueryString}"
                : request.Path.ToString();
        //The PathAndQuery extension method
        //operates on the HttpRequest class,
        //which ASP.NET Core uses to describe an HTTP request
        //The extension method generates a URL that the browser will
        //be returned to after the cart has been updated,
        //taking into account the query string, if there is one
    }
}
