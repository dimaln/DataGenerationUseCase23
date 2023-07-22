using DataGenerationUseCase23.Models;

namespace DataGenerationUseCase23.Services.Interfaces
{
    public interface ICsvCreator
    {
        Task CreateCsvs(List<Titles> titles);
    }
}
