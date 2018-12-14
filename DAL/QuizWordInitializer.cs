using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HebrewTutor2.Models; 

namespace HebrewTutor2.DAL
{
    public class QuizWordInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<QuizContext>
    {
        protected override void Seed(QuizContext context)
        {
            var words = new List<QuizWord>
            {
                new QuizWord { Lemma="Qatalti", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." },
                new QuizWord { Lemma="Qatalta", Parsing="Qal perfect 1cs", Explanation="The ti on the end of the word and lack of preformative indicate that this verb is a perfect form, 1cs." }
            };
            words.ForEach(s => context.QuizWords.Add(s));
            context.SaveChanges(); 
        }
    }
}