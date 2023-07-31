namespace DataGenerationUseCase23.Models
{
    public class Roles
    {
        private static readonly Dictionary<Role, string> _dictionary = new()
        {
            { Role.Director, "Director" },
            { Role.Producer, "Producer" },
            { Role.Screenwriter, "Screenwriter" },
            { Role.Actor, "Actor" },
            { Role.Actress, "Actress" } ,
            { Role.Cinematographer, "Cinematographer" },
            { Role.FilmEditor, "Film Editor" },
            { Role.ProductionDesigner, "Production Designer" },
            { Role.CostumeDesigner, "Costume Designer" },
            { Role.MusicCompose, "Music Composer" }
        };

        public enum Role
        {
            Director,
            Producer,
            Screenwriter,
            Actor,
            Actress,
            Cinematographer,
            FilmEditor,
            ProductionDesigner,
            CostumeDesigner,
            MusicCompose
        };

        public Dictionary<Role, string> RolesDictionary = _dictionary;
    }
}
