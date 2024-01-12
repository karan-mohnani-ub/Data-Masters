using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.ML;
using Microsoft.OpenApi.Models;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using DataMastersMLWebApi;

// Configure app
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPredictionEnginePool<DataMastersML.ModelInput, DataMastersML.ModelOutput>()
    .FromFile("DataMastersML.zip");
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
  c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Description = "Docs for my API", Version = "v1" });
});
var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
  c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

// Define prediction route & handler
app.MapPost("/predict",
    async (PredictionEnginePool<DataMastersML.ModelInput, DataMastersML.ModelOutput> predictionEnginePool, DataMastersML.ModelInput input) =>
        await Task.FromResult(predictionEnginePool.Predict(input)));

// Run app
app.Run();
