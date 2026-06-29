using System.Linq;
using System.Web.Mvc;
using EmployeeManagementSystem_Reports.Models;
using System.Data.Entity;

namespace EmployeeManagementSystem_Reports.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly EmployeeDBEntities db = new EmployeeDBEntities();

        // GET: Departments
        public ActionResult Index()
        {
            return View(db.Departments.ToList());
        }

        // GET: Departments/Details/5
        public ActionResult Details(int id)
        {
            var department = db.Departments.Find(id);

            if (department == null)
                return HttpNotFound();

            return View(department);
        }

        // GET: Departments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                db.Departments.Add(department);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(department);
        }

        // GET: Departments/Edit/5
        // GET: Departments/Edit/5
        public ActionResult Edit(int id)
        {
            var department = db.Departments.Find(id);

            if (department == null)
                return HttpNotFound();

            return View(department);
        }

        // POST: Departments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                db.Entry(department).State =
                    System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(department);
        }

        // GET: Departments/Delete/5
        public ActionResult Delete(int id)
        {
            var department = db.Departments.Find(id);

            if (department == null)
                return HttpNotFound();

            return View(department);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var department = db.Departments.Find(id);

            if (department == null)
                return HttpNotFound();

            db.Departments.Remove(department);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // Dispose DB Context
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