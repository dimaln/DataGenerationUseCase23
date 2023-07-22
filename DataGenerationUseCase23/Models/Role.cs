namespace DataGenerationUseCase23.Models
{
    public class Role
    {
        public enum RoleEnum
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

        public Dictionary<RoleEnum, string> RolesDictionary = new()
        {
            { RoleEnum.Director, "Director" },
            { RoleEnum.Producer, "Producer" },
            { RoleEnum.Screenwriter, "Screenwriter" },
            { RoleEnum.Actor, "Actor" },
            { RoleEnum.Actress, "Actress" } ,
            { RoleEnum.Cinematographer, "Cinematographer" },
            { RoleEnum.FilmEditor, "Film Editor" },
            { RoleEnum.ProductionDesigner, "Production Designer" },
            { RoleEnum.CostumeDesigner, "Costume Designer" },
            { RoleEnum.MusicCompose, "Music Composer" }
        };
    }
}
