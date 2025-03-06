var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Dapr_eShop_Orders>("dapr-eshop-orders");

builder.Build().Run();
