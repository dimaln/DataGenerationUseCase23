using DataGenerationUseCase23.Models;

namespace DataGenerationUseCase23.Services.Interfaces
{
    public interface IDataGenerator
    {
        List<Titles> GenerateMovieCollection();
    }
}
