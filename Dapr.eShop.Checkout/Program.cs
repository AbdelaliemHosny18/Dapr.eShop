using Dapr.Client;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddDaprClient();

var app = builder.Build();

app.MapDefaultEndpoints();
app.UseHttpsRedirection();

app.MapPost("create-order", async (OrderRequest request ,DaprClient client) =>
{
 var result=  await  client.InvokeMethodAsync<OrderRequest, string>("orders-api", "process-order",request);

    return Results.Ok(result);

});
app.Run();

public record OrderRequest(string orderId, string customerId, List<string> items);

