using DataGenerationUseCase23.Services;
using DataGenerationUseCase23.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static async Task Main()
    {
        var services = new ServiceCollection();

        services.AddScoped<IDataGenerator, DataGenerator>()
                .AddScoped<ICsvCreator, CsvCreator>();

        var serviceProvider = services.BuildServiceProvider();

        await GenerateCsv(serviceProvider);
    }

    [SuppressMessage("SonarLint", "CS8602", Justification = "Ignored intentionally as a demo")]
    private static async Task GenerateCsv(ServiceProvider serviceProvider)
    {
        var titles = serviceProvider
                .GetService<IDataGenerator>()
                .GenerateMovieCollection();

        await serviceProvider
                .GetService<ICsvCreator>()
                .CreateCsvs(titles);
    }
}
