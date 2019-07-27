using System;
using System.Collections.Generic;

namespace SIGamePacks.Data.Models.Pack
{
    public class Pack
    {
        public Pack(string name, string author, DateTime publicationDate, int difficulty, int evaluation,
            List<Tag> tags, string linkToDownload, List<Round> rounds, List<Comment> comments)
        {
            Name = name;
            Author = author;
            PublicationDate = publicationDate;
            Difficulty = difficulty;
            Evaluation = evaluation;
            Tags = tags;
            LinkToDownload = linkToDownload;
            Rounds = rounds;
            Comments = comments;
            LikesCount = 0;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is Pack pack)
            {
                return Id == pack.Id;
            }

            return false;
        }

        public int Id { get; set; }
        public string Name { get; }
        public string Author { get; }
        public DateTime PublicationDate { get; }
        public int Difficulty { get; }
        public int Evaluation { get; }
        public List<Tag> Tags { get; set; }
        public string LinkToDownload { get; }
        public List<Round> Rounds { get; }
        public List<Comment> Comments { get; }
        public int LikesCount { get; }
    }
}