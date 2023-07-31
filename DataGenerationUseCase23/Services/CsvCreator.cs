using CsvHelper;
using CsvHelper.Configuration;
using DataGenerationUseCase23.Models;
using DataGenerationUseCase23.Services.Interfaces;
using System.Globalization;

namespace DataGenerationUseCase23.Services
{
    public class CsvCreator : ICsvCreator
    {
        private readonly string _projectRoot = Directory.GetParent(Environment.CurrentDirectory)
                ?.Parent
                ?.Parent
                ?.FullName
            ?? throw new ApplicationException("Failed to get project root path.");

        public async Task CreateCsvs(List<Titles> titles)
        {
            if (titles == null) throw new ArgumentException("Generateed data can not be Null!");

            await SaveToCsvTitles(titles);

            var credits = new List<Credits>();
            foreach (var title in titles)
            {
                credits.AddRange(title.Credits);
            }

            await SaveToCsvCredits(credits);
        }

        private async Task SaveToCsvCredits(List<Credits> credits)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture);

            try
            {
                using var fs = new StreamWriter($"{_projectRoot}\\\\Output\\\\credits.csv");
                using var csvWriter = new CsvWriter(fs, csvConfig);

                await csvWriter.WriteRecordsAsync(credits);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Saving Credits to CSV file was failed.\n" + ex.ToString());
            }
        }

        private async Task SaveToCsvTitles(List<Titles> titles)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture);
            try
            {
                using var fs = new StreamWriter($"{_projectRoot}\\\\Output\\\\titles.csv");
                using var csvWriter = new CsvWriter(fs, csvConfig);

                await csvWriter.WriteRecordsAsync(titles);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Saving Titels to CSV file was failed.\n" + ex.ToString());
            }
        }
    }
}
