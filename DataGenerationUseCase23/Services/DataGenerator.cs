using Bogus;
using DataGenerationUseCase23.Models;
using DataGenerationUseCase23.Services.Interfaces;
using static DataGenerationUseCase23.Models.AgeCertifications;
using static DataGenerationUseCase23.Models.Roles;

namespace DataGenerationUseCase23.Services
{
    public class DataGenerator : IDataGenerator
    {
        private int creditId = 0;
        private int titleId = 0;
        private readonly int _repitableDataSetId = 8675309;

        public DataGenerator()
        {
            Randomizer.Seed = new Random(_repitableDataSetId);
        }

        public List<Titles> GenerateMovieCollection()
        {
            var result = new List<Titles>();

            for (int i = 0; i < Random.Shared.Next(10, 20); i++)
            {
                var faker = new Faker<Titles>()
                    .RuleFor(x => x.Id, y => UpdateTitleId())
                    .RuleFor(x => x.Title, x => x.Music.Random.Words(5).ToString())
                    .RuleFor(x => x.Description, x => x.Rant.Random.Words(20).ToString())
                    .RuleFor(x => x.ReleaseYear, x => x.Random.Int(1911, DateTime.Now.Year))
                    .RuleFor(x => x.AgeCertification, x => GetAgeCertification(x.Random.Enum<AgeCertification>()))
                    .RuleFor(x => x.Runtime, x => x.Random.Int(15, 150))
                    .RuleFor(x => x.Genres, x => x.Music.Genre())
                    .RuleFor(x => x.ProductionCountry, x => x.Address.Country())
                    .RuleFor(x => x.Seasons, x => x.Random.Int(0, 12))
                    .RuleFor(x => x.Credits, Enumerable
                                             .Range(4, 15)
                                             .Select(_ => CreateCredit().Generate()).ToList())
                    .Generate();

                result.Add(faker);
            }

            return result;
        }

        private int UpdateTitleId()
        {
            return ++titleId;
        }

        private int UpdateCreditId()
        {
            return ++creditId;
        }

        private Faker<Credits> CreateCredit()
        {
            return new Faker<Credits>()
              .RuleFor(x => x.Id, y => UpdateCreditId())
              // first created related entities, so need to update titleId manually
              .RuleFor(x => x.TitleId, y => titleId + 1)
              .RuleFor(x => x.RealName, r => r.Person.FullName)
              .RuleFor(x => x.CharacterName, new Faker().Person.FullName)
              .RuleFor(x => x.Role, x => GetRole(x.Random.Enum<Role>()));
        }

        private static string GetAgeCertification(AgeCertification x)
        {
            new AgeCertifications().AgeCertificationDictionary.TryGetValue(x, out var ageCertification);

            return ageCertification ?? string.Empty;
        }

        private static string GetRole(Role x)
        {
            new Roles().RolesDictionary.TryGetValue(x, out var role);

            return role ?? string.Empty;
        }
    }
}
