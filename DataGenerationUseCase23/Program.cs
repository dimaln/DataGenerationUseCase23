﻿using DataGenerationUseCase23.Services;
using DataGenerationUseCase23.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddScoped<IDataGenerator, DataGenerator>()
        .AddScoped<ICsvCreator, CsvCreator>();

var serviceProvider = services.BuildServiceProvider();

var titles = serviceProvider
    .GetService<IDataGenerator>()
    .GenerateMovieCollection();

await serviceProvider
    .GetService<ICsvCreator>()
    .CreateCsvs(titles);