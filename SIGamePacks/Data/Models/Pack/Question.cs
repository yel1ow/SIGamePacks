namespace SIGamePacks.Data.Models.Pack
{
    public class Question
    {
        public Question(string text, string rightAnswer)
        {
            Text = text;
            RightAnswer = rightAnswer;
        }

        public string Text { get; }
        public string RightAnswer { get; }
    }
}