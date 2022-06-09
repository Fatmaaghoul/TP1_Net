using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP1MVC.Models;
using TP1MVC.Models.Repositories;

namespace TP1MVC.Controllers
{
    public class EmployeController : Controller
    {
        // GET: EmployeController
        readonly IRepository<Employe> employeRepository;

        //injection de dépendance
        public EmployeController(IRepository<Employe> empRepository)
        {
            employeRepository = empRepository;
        }

        public ActionResult Index()
        {
            return View(employeRepository.GetAll());
        }

        // GET: EmployeController/Details/5
        public ActionResult Details(int id)
        {
            return View(employeRepository.FindByID(id));
        }

        // GET: EmployeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employe e)
        {
            try
            {
                employeRepository.Add(e);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(employeRepository.FindByID(id));
        }

        // POST: EmployeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employe newemploye)
        {
            try
            {
                employeRepository.Update(id, newemploye);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(employeRepository.FindByID(id));
        }

        // POST: EmployeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employe e)
        {
            try
            {
                employeRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
