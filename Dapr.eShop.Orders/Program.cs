var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();


var app = builder.Build();

app.MapDefaultEndpoints();


app.UseHttpsRedirection();


app.MapPost("/process-order",async (OrderRequest request)=>{

    await ProcessOrderAsync(request);
    return Results.Ok($"Order {request.orderId} confirmation: #{new Guid().ToString()[..8]}");

});


app.Run();

async Task ProcessOrderAsync(OrderRequest request)
{
    //process order 
    await Task.Delay(100);
}

public record OrderRequest (string orderId,string customerId,List<string> items);