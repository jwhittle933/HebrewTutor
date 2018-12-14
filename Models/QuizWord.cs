using System;
namespace HebrewTutor2.Models
{
    public class QuizWord
    {
        public int Id { get; set; }
        public string Lemma { get; set; }
        public string Parsing { get; set; }
        public string Explanation { get; set; }
    }
}
