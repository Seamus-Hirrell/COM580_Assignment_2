using assignment_2.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace assignment_2.Controllers
{
  public class StudentController : Controller
  {
    private IStudentRepository repository;

    public StudentController()
    {
      this.repository = new StudentRepository();
    }

    // public StudentController(IStudentRepository repository)
    // {
    //   this.repository = repository;
    // }

    [HttpGet]
    public ActionResult Index()
    {
      var students = repository.SelectAll();
      return View(students);
    }

    [HttpGet]
    public ActionResult Details(int id)
    {
      var student = repository.SelectByID(id);
      return View(student);
    }

    [HttpGet]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      if (ModelState.IsValid)
      {
        repository.Insert(student);
        repository.Save();
        return RedirectToAction("Index");
      }
      return View(student);
    }

    [HttpGet, ActionName("Edit")]
    public ActionResult ConfirmEdit(int id)
    {
      var student = repository.SelectByID(id);
      return View(student);
    }

    [HttpPost]
    public ActionResult Edit(Student student)
    {
      if (ModelState.IsValid)
      {
        repository.Update(student);
        repository.Save();
        return RedirectToAction("Index");
      }
      return View(student);
    }

    [HttpGet, ActionName("Delete")]
    public ActionResult ConfirmDelete(int id)
    {
      Student student = repository.SelectByID(id);
      return View(student);
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
      repository.Delete(id);
      repository.Save();
      return RedirectToAction("Index");
    }
  }
}
