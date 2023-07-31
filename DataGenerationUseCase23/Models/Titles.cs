namespace DataGenerationUseCase23.Models
{
    public class Titles
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int ReleaseYear { get; set; }

        public string AgeCertification { get; set; } = string.Empty;

        public int Runtime { get; set; }

        public string Genres { get; set; } = string.Empty;

        public string ProductionCountry { get; set; } = string.Empty;

        public int? Seasons { get; set; }


        public ICollection<Credits> Credits { get; set; } = new List<Credits>();
    }
}
