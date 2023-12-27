var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.DotnetAspirePlayground_ApiService>("apiservice");

builder.AddProject<Projects.DotnetAspirePlayground_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
