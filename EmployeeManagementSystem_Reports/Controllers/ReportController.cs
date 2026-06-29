using System.Web.Mvc;

namespace EmployeeManagementSystem_Reports.Controllers
{
    public class ReportsController : Controller
    {
        public ActionResult EmployeeReport()
        {
            return Redirect("~/EmployeeReport.aspx");
        }
    }
}