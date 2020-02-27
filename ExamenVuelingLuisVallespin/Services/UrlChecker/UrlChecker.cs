﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Polly;

namespace ExamenVuelingLuisVallespin.Services.UrlChecker
{
    public class UrlChecker : IUrlChecker
    {
        public async Task<bool> Check(string url)
        {
            var httpClient = new HttpClient();
            var request = await Policy
                .HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                .WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(2), (result, timeSpan, retryCount, context) =>
                {
                    Console.WriteLine("Escribir en Log");
                    
                })
                .ExecuteAsync(() => httpClient.GetAsync(url));
            return request.IsSuccessStatusCode;
        }
    }
}