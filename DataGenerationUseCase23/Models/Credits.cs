namespace DataGenerationUseCase23.Models
{
    internal class Credits
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseYear { get; set; }
        public AgeCertification.AgeCertificationEnum AgeCertification { get; set; }
        public int Runtime { get; set; }
        public string Genres { get; set; }
        public string ProductionСountry { get; set; }
        public int? Seasons { get; set; }

        public Titles Titles { get; set; }
    }
}
