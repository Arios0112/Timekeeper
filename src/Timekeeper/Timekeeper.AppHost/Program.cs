var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Timekeeper_ApiService>("apiservice");

builder.AddProject<Projects.Timekeeper_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
