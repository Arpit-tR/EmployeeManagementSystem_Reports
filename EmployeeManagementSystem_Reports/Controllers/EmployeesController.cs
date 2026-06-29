using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using EmployeeManagementSystem_Reports.Models;

namespace EmployeeManagementSystem_Reports.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeDBEntities db = new EmployeeDBEntities();

        // GET: Employees
        public ActionResult Index(string searchString)
        {
            var employees = db.Employees
                              .Include(e => e.Department)
                              .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(e =>
                    e.Name.Contains(searchString) ||
                    e.Email.Contains(searchString) ||
                    e.Department.DepartmentName.Contains(searchString));
            }

            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            var employee = db.Employees
                             .Include(e => e.Department)
                             .FirstOrDefault(e => e.EmployeeId == id);

            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(
                db.Departments,
                "DepartmentId",
                "DepartmentName");

            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(
                db.Departments,
                "DepartmentId",
                "DepartmentName",
                employee.DepartmentId);

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);

            if (employee == null)
                return HttpNotFound();

            ViewBag.DepartmentId = new SelectList(
                db.Departments,
                "DepartmentId",
                "DepartmentName",
                employee.DepartmentId);

            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(
                db.Departments,
                "DepartmentId",
                "DepartmentName",
                employee.DepartmentId);

            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = db.Employees
                             .Include(e => e.Department)
                             .FirstOrDefault(e => e.EmployeeId == id);

            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var employee = db.Employees.Find(id);

            if (employee == null)
                return HttpNotFound();

            db.Employees.Remove(employee);
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