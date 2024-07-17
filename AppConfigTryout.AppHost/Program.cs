var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AppConfigTryout_ApiService>("apiservice");

builder.AddProject<Projects.AppConfigTryout_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
