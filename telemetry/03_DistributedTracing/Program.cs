global using Microsoft.Extensions.Logging;

global using System.Diagnostics;

using DiagnosticsSample;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System.Text.Json;

var builder = Host.CreateApplicationBuilder(args);
builder.Logging.AddJsonConsole(config =>
{
    config.JsonWriterOptions = new JsonWriterOptions() { Indented = true };
});
builder.Logging.SetMinimumLevel(LogLevel.Trace);

builder.Services.AddDbContextFactory<BooksContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("BooksConnection") ?? throw new InvalidOperationException("Missing BooksConnection from configuration");

    options.UseSqlServer(connectionString);
});
builder.Services.AddTransient<Runner>();

using var app = builder.Build();

var runner = app.Services.GetRequiredService<Runner>();

for (int i = 0; i < 200; i++)
{
    runner.InfoMessage1();
    runner.InfoMessage2();
    runner.ErrorMessage();
    await Task.Delay(200);
    runner.Foo();
    runner.AddARecord();
}
