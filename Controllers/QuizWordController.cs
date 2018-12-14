using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HebrewTutor2.DAL;
using HebrewTutor2.Models;

namespace HebrewTutor2.Controllers
{
    public class QuizWordController : Controller
    {
        private QuizContext db = new QuizContext();

        // GET: QuizWord
        public ActionResult Index()
        {
            return View(db.QuizWords.ToList());
        }

        // GET: QuizWord/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuizWord quizWord = db.QuizWords.Find(id);
            if (quizWord == null)
            {
                return HttpNotFound();
            }
            return View(quizWord);
        }

        // GET: QuizWord/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuizWord/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Lemma,Parsing,Explanation")] QuizWord quizWord)
        {
            if (ModelState.IsValid)
            {
                db.QuizWords.Add(quizWord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quizWord);
        }

        // GET: QuizWord/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuizWord quizWord = db.QuizWords.Find(id);
            if (quizWord == null)
            {
                return HttpNotFound();
            }
            return View(quizWord);
        }

        // POST: QuizWord/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Lemma,Parsing,Explanation")] QuizWord quizWord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quizWord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quizWord);
        }

        // GET: QuizWord/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuizWord quizWord = db.QuizWords.Find(id);
            if (quizWord == null)
            {
                return HttpNotFound();
            }
            return View(quizWord);
        }

        // POST: QuizWord/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuizWord quizWord = db.QuizWords.Find(id);
            db.QuizWords.Remove(quizWord);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
