using cascadind_dropdown.EmployeeContext;
using cascadind_dropdown.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace cascadind_dropdown.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EContext _context;

        public HomeController(ILogger<HomeController> logger, EContext context)
        {
            _logger = logger;
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUpEmp()
        {
            ViewBag.designation = _context.designation.ToList();
            return View();
        }
        public JsonResult SignUpEmployee(int Desigid,string EmployeeName,int GradeId)
        {
            var emp = new Employee()
            {
                EmpName = EmployeeName,
                DesigId = Desigid,
                GradeId = GradeId
            };
            /*var res=*/_context.employees.Add(emp);
            _context.SaveChanges();
            return Json("Form has been submitted");
        }
        public IActionResult RegisterEmployee()
        {
            ViewBag.desig=_context.designation.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult RegisterEmployee(Employee data)
        {
            _context.employees.Add(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Calculate()
        {

            return View();
        }
        public int sum(int x, int y)
        {
            return x + y;
        }

        public IActionResult Create()
        {
            ViewBag.designation = _context.designation.ToList();
            return View();
        }
        public JsonResult getgrade(int x)
        {
            var res = _context.grades.Where(item => item.Desig_Id == x).ToList();
            return Json(res);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
