﻿using LoggingSample;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;
using System.Runtime.InteropServices;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging((hostingContext, logging) =>
    {
        logging.ClearProviders();
        bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        if (isWindows)
        {
            logging.AddFilter<EventLogLoggerProvider>(level => level >= LogLevel.Warning);
        }

        logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
        logging.AddConsole();
        logging.AddSimpleConsole(configure =>
        {
            configure.IncludeScopes = true;
        });
        logging.AddDebug();
        logging.AddEventSourceLogger();

        if (isWindows)
        {
            logging.AddEventLog(); // EventLogLoggerProvider
        }

        logging.Configure(options =>
        {
            options.ActivityTrackingOptions = ActivityTrackingOptions.SpanId
                                            | ActivityTrackingOptions.TraceId
                                            | ActivityTrackingOptions.ParentId;
        });
    })
    .ConfigureServices(services =>
    {
        services.AddHttpClient<NetworkService>(client =>
        {
        }).AddTypedClient<NetworkService>();
        services.AddScoped<Runner>();
    }).Build();

var runner = host.Services.GetRequiredService<Runner>();
await runner.RunAsync();

Console.WriteLine("Bye... Press return to exit");
Console.ReadLine();
