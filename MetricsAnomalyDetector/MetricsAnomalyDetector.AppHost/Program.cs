var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres").WithPgAdmin();
var postgresdb = postgres.AddDatabase("postgresdb");

builder.AddProject<Projects.MetricsAnomalyDetector>("metricsanomalydetector").WithReference(postgresdb);

builder.Build().Run();
