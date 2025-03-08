
var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Dapr_eShop_Orders>("dapr-eshop-orders")
    .WithDaprSidecar("orders-api");

builder.AddProject<Projects.Dapr_eShop_Checkout>("dapr-eshop-checkout")
    .WithDaprSidecar("checkout-api");

builder.Build().Run();
