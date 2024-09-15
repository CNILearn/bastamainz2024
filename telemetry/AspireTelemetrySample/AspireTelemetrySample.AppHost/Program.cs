var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireTelemetrySample_ApiService>("apiservice");

builder.AddProject<Projects.AspireTelemetrySample_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
