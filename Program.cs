using System;
using Microsoft.AspNetCore.Builder;

WebApplicationBuilder webApplicationBuilder = 
    WebApplication.CreateBuilder(args);

WebApplication webApplication =
    webApplicationBuilder.Build();

webApplication.MapGet("/api/home",
    (Func<string>)(() => "Hey, Reid was here creating this API EndPoint woaaaah spoooky"));

webApplication.Run();