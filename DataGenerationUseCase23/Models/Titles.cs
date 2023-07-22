namespace DataGenerationUseCase23.Models
{
    public class Titles
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        public AgeCertification.AgeCertificationEnum AgeCertification { get; set; }

        public int Runtime { get; set; }

        public string Genres { get; set; }

        public string ProductionCountry { get; set; }

        public int? Seasons { get; set; }


        public ICollection<Credits> Credits { get; set; }
    }
}
