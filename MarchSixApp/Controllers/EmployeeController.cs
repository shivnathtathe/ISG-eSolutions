using Microsoft.AspNetCore.Mvc;

namespace MarchSixApp.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Shiv",
                Gender = "Male",
                City = "Kolhapur"
            };

            return View();
        }
    }
}
