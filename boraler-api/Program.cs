using System;
using boraler_api.config;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();


var builder = Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<Startup>();
    webBuilder.UseUrls(config["BaseAddress"] ?? "http://localhost:8080");
});

DataConnection connection = new DataConnection();
connection.Connection();


var app = builder.Build();

app.Run();
