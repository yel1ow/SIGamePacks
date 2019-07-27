using System.Collections.Generic;

namespace SIGamePacks.Data.Models.Pack
{
    public class Round
    {
        public Round(string name, List<Theme> themes)
        {
            Name = name;
            Themes = themes;
        }

        public string Name { get; }
        public List<Theme> Themes { get; }
    }
}