using System.Collections.Generic;

namespace SIGamePacks.Data.Models.Pack
{
    public class Theme
    {
        public Theme(string name, List<Question> questions)
        {
            Name = name;
            Questions = questions;
        }

        public string Name { get; }
        public List<Question> Questions { get; }
    }
}