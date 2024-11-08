using DiAp.Middleware;
using DiApi.Data;
using DiApi.DataServices;
using DiApi.Utility;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDataRepo,NoSqlDataRepo>();
builder.Services.AddScoped<IDataService, HttpDataService>();

builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();


var app = builder.Build();

app.UseCoustomMiddleware();

app.UseHttpsRedirection();

// app.MapGet("/getdata", (IDataRepo repo) =>
// {  
//     // var repo = new SqlDataRepo();
//     // var repo = new NoSqlDataRepo();

//     // repo.ReturnData();
//     repo.ReturnData();
    
//     return Results.Ok();
// });

app.MapGet("/getdata", (IOperationTransient transient, IOperationScoped scoped, IOperationSingleton singleton) =>
{  
    Console.WriteLine($"Endpoint; TransienId: {transient.OperationId} ScopedId: {scoped.OperationId} SingletonId: {singleton.OperationId}");

    return Results.Ok();
});



app.Run();
