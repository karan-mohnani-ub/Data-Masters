using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.ML;
using Microsoft.ML.Data;
using System.Collections.Generic;
using System;

using Microsoft.AspNetCore.Builder;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.ML;

using Microsoft.OpenApi.Models;

using System.Drawing;

using System.IO;

using System.Threading.Tasks;

using DataMastersMLWebApi;

using Microsoft.ML.Data;

using Microsoft.ML;

using System.Collections.Generic;

using System;

using System.Linq;

public partial class Program

{

  public static void Main(string[] args)

  {

    // Configure app

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddPredictionEnginePool<DataMastersML.ModelInput, DataMastersML.ModelOutput>()

        .FromFile("DataMastersML.zip");
    builder.Services.AddCors(options =>
    {
      options.AddPolicy("AllowAllOrigins",
        builder =>
        {
          builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        }
        );
    });
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
    app.UseCors("AllowAllOrigins");
    app.MapPost("/predict",

        async (PredictionEnginePool<DataMastersML.ModelInput, DataMastersML.ModelOutput> predictionEnginePool, DataMastersML.ModelInput input) =>

            await Task.FromResult(GetScoresWithLabelsSorted(predictionEnginePool, input)));

    // Run app

    app.Run();


  }

  static Dictionary<string, float> GetScoresWithLabelsSorted(PredictionEnginePool<DataMastersML.ModelInput, DataMastersML.ModelOutput> predictionEnginePool, DataMastersML.ModelInput input)
  {
    var engine = predictionEnginePool.GetPredictionEngine();
    var predictData = predictionEnginePool.Predict(input);
    float[] score = predictData.Score;

    string name = "CatalogueItemName";
    Dictionary<string, float> result = new Dictionary<string, float>();


    var column = engine.OutputSchema.GetColumnOrNull(name);

    var slotNames = new VBuffer<ReadOnlyMemory<char>>();

    column.Value.GetKeyValues(ref slotNames);
    var names = new string[slotNames.Length];

    var num = 0;

    foreach (var denseValue in slotNames.DenseValues())

    {

      result.Add(denseValue.ToString(), score[num++]);

    }

    return result.OrderByDescending(c => c.Value).ToDictionary(i => i.Key, i => i.Value);

  }

}
