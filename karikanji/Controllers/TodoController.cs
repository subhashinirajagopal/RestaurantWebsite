using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using karikanji.Models;

namespace karikanji.Controllers
{
    public class TodoController : Controller
    {
        //
        // GET: /Todo/

        public ActionResult Home()
        {
            using (UsersContext db = new UsersContext())
            {
                return View(db.Todos.ToList());
            }
        }

        //
        // GET: /Todo/Details/5

        public ActionResult Details(int id = 0)
        {
            using (UsersContext db = new UsersContext())
            {
                Todo todo = db.Todos.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
            }
            
        }

        //
        // GET: /Todo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Todo/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                // Insert a new user into the database
                using (UsersContext db = new UsersContext())
                {
                    db.Todos.Add(todo);
                    db.SaveChanges();
                    return RedirectToAction("Home");
                }
            }

            return View(todo);
        }

        //
        // GET: /Todo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            using (UsersContext db = new UsersContext())
            {
                Todo todo = db.Todos.Find(id);
                if (todo == null)
                {
                    return HttpNotFound();
                }
                return View(todo);
            }

           
        }

        //
        // POST: /Todo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Todo todo)
        {
            if (ModelState.IsValid)
            {
                using (UsersContext db = new UsersContext())
                {
                    db.Entry(todo).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Home");
                }

            }
            return View(todo);
        }

        //
        // GET: /Todo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            using (UsersContext db = new UsersContext())
            {
                Todo todo = db.Todos.Find(id);
                if (todo == null)
                {
                    return HttpNotFound();
                }
                return View(todo);
            }

        }

        //
        // POST: /Todo/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (UsersContext db = new UsersContext())
            {
                Todo todo = db.Todos.Find(id);
                db.Todos.Remove(todo);
                db.SaveChanges();
                return RedirectToAction("Home");
            }

           
        }

    }
}