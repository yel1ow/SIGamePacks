using System.Collections.Generic;

namespace SIGamePacks.Data.Models
{
    public class Tag
    {
        public Tag(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; }
        public List<Pack.Pack> Packs { get; set; }
    }
}