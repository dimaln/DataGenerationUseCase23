﻿namespace DataGenerationUseCase23.Models
{
    public class AgeCertifications
    {
        public enum AgeCertification
        {
            G,
            PG,
            PG13,
            R,
            NC17,
            U,
            UA,
            A,
            S,
            AL,
            Six,
            Nine,
            Twenty,
            TwentyA,
            Fifty,
            Eighty,
            EightyR,
            R18,
            R21,
            M,
            MA15Plus,
            R16,
            R18Plus,
            X18,
            T,
            E,
            E10Plus,
            EC,
            C,
            CA,
            GP,
            MPG,
            TVY,
            TVY7,
            TVG,
            TVPG,
            TV14,
            TVMA,
        }

        public Dictionary<AgeCertification, string> AgeCertificationDictionary = new() {
            { AgeCertification.G, "G" },
            { AgeCertification.PG, "PG" },
            { AgeCertification.PG13, "PG-13" },
            { AgeCertification.R, "R" },
            { AgeCertification.NC17, "NC-17" },
            { AgeCertification.U, "U" },
            { AgeCertification.UA, "U/A" },
            { AgeCertification.A, "A" },
            { AgeCertification.S, "S" },
            { AgeCertification.AL, "AL" },
            { AgeCertification.Six, "6" },
            { AgeCertification.Nine, "9" },
            { AgeCertification.Twenty, "12" },
            { AgeCertification.TwentyA, "12A" },
            { AgeCertification.Fifty, "15" },
            { AgeCertification.Eighty, "18" },
            { AgeCertification.EightyR, "18R" },
            { AgeCertification.R18, "R18" },
            { AgeCertification.R21, "R21" },
            { AgeCertification.M, "M" },
            { AgeCertification.MA15Plus, "MA15+" },
            { AgeCertification.R16, "R16" },
            { AgeCertification.R18Plus, "R18+" },
            { AgeCertification.X18, "X18" },
            { AgeCertification.T, "T" },
            { AgeCertification.E, "E" },
            { AgeCertification.E10Plus, "E10+" },
            { AgeCertification.EC, "EC" },
            { AgeCertification.C, "C" },
            { AgeCertification.CA, "CA" },
            { AgeCertification.GP, "GP" },
            { AgeCertification.MPG, "M/PG" },
            { AgeCertification.TVY, "TV-Y" },
            { AgeCertification.TVY7, "TV-Y7" },
            { AgeCertification.TVG, "TV-G" },
            { AgeCertification.TVPG, "TV-PG" },
            { AgeCertification.TV14, "TV-14" },
            { AgeCertification.TVMA, "TV-MA" }
        };
    }
}