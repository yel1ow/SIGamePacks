using System.Collections.Generic;
using SIGamePacks.Data.Models;
using SIGamePacks.Data.Models.Pack;

namespace SIGamePacks.ViewModels
{
    public class PacksIndexViewModel
    {
        public IEnumerable<Pack> Packs;
        public IEnumerable<Tag> Tags;
    }
}