using System;
using System.Collections.Generic;
using System.Linq;
using SIGamePacks.Data.Interfaces;
using SIGamePacks.Data.Models;
using SIGamePacks.Data.Models.Pack;

namespace SIGamePacks.Data.Mocks
{
    public class MockPacks : IPacksService
    {
        private readonly ITagsService tagsService = new MockTags();

        public IEnumerable<Pack> GetAllPacks =>
            new List<Pack>
            {
                new Pack("first pack",
                    "first author",
                    DateTime.Now,
                    5,
                    5,
                    new List<Tag> {tagsService.GetAllTags.First()},
                    "link1",
                    new List<Round>
                    {
                        new Round("RoundName", new List<Theme>()
                        {
                            new Theme("ThemeName", new List<Question>()
                            {
                                new Question("question", "answer")
                            })
                        })
                    },
                    new List<Comment>
                    {
                        new Comment("comment", "author")
                    }),
                new Pack("second pack",
                    "second author",
                    DateTime.Now,
                    1,
                    8,
                    new List<Tag> {tagsService.GetAllTags.Last()},
                    "link2",
                    new List<Round>
                    {
                        new Round("RoundName", new List<Theme>()
                        {
                            new Theme("ThemeName", new List<Question>()
                            {
                                new Question("question", "answer")
                            })
                        })
                    },
                    new List<Comment>
                    {
                        new Comment("comment", "author")
                    }),
            };
    }
}