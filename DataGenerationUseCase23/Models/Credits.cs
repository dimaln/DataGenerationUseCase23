namespace DataGenerationUseCase23.Models
{
    public class Credits
    {
        public int Id { get; set; }

        public int TitleId { get; set; }

        public string RealName { get; set; }

        public string CharacterName { get; set; }

        public Role.RoleEnum Role { get; set; }
    }
}
