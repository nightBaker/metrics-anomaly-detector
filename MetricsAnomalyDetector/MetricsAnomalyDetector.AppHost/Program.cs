var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MetricsAnomalyDetector>("metricsanomalydetector");

builder.Build().Run();
