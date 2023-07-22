namespace DataGenerationUseCase23.Models
{
    internal class Titles
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public string RealName { get; set; }
        public string CharacterName { get; set; }
        public Roles.Role Role { get; set; }

        public ICollection<Credits> Credits { get; set; }
    }
}
