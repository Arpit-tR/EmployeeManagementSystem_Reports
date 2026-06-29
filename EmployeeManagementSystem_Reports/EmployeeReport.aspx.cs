using Microsoft.Reporting.WebForms;
using System;
using System.Linq;
using EmployeeManagementSystem_Reports.Models;

namespace EmployeeManagementSystem_Reports.Views
{
    public partial class EmployeeReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EmployeeDBEntities db = new EmployeeDBEntities();

                var employees = db.Employees.Select(emp => new
                {
                    emp.EmployeeId,
                    emp.Name,
                    emp.Email,
                    emp.Mobile,
                    emp.Address,
                    emp.Gender,
                    emp.JoiningDate,
                    DepartmentName = emp.Department.DepartmentName
                }).ToList();

                ReportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds =
                    new ReportDataSource("DataSet1", employees);

                ReportViewer1.LocalReport.DataSources.Add(rds);

                ReportViewer1.LocalReport.ReportPath =
                    Server.MapPath("~/Reports/EmployeeReport.rdlc");

                ReportViewer1.LocalReport.Refresh();
            }
        }
    }
}