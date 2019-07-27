using System.Collections.Generic;
using SIGamePacks.Data.Models;

namespace SIGamePacks.Data.Interfaces
{
    public interface ITagsService
    {
        IEnumerable<Tag> GetAllTags { get; }
    }
}