using System.Collections.Generic;
using System.Linq;
using SIGamePacks.Data.Interfaces;
using SIGamePacks.Data.Models;
using SIGamePacks.Data.Models.Pack;

namespace SIGamePacks.Data.Mocks
{
    public class MockTags : ITagsService
    {
        public IEnumerable<Tag> GetAllTags =>
            new List<Tag>
            {
                new Tag("tag1"),
                new Tag("tag2")
            };
    }
}