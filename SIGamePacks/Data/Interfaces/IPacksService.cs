using System.Collections.Generic;
using SIGamePacks.Data.Models.Pack;

namespace SIGamePacks.Data.Interfaces
{
    public interface IPacksService
    {
        IEnumerable<Pack> GetAllPacks { get; }
    }
}