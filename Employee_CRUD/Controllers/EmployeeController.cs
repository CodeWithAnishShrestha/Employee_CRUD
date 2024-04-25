using Employee_CRUD.Data;
using Employee_CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext Db)
        {
            _db = Db;
        }

        public IActionResult Index()
        {
            List<Employee> objCategoryList = _db.Employees.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _db.Employees.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            Employee? empobj = _db.Employees.Find(Id);

            if (empobj == null)
            {
                return NotFound();
            }

            return View(empobj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            _db.Employees.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            Employee? empobj = _db.Employees.Find(Id);

            if (empobj == null)
            {
                return NotFound();
            }

            return View(empobj);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Employee? empobj = _db.Employees.Find(id);
            if (empobj == null)
            {
                return NotFound();
            }
            _db.Employees.Remove(empobj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}