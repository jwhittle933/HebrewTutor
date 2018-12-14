using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HebrewTutor2.Models; 
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HebrewTutor2.DAL
{
    public class QuizContext : DbContext 
    {
        public DbSet<QuizWord> QuizWords { get; set; }


        public QuizContext() : base("QuizContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}