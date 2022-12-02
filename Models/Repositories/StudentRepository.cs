using Microsoft.EntityFrameworkCore;

namespace assignment_2.Models.Repositories
{
  public class StudentRepository : IStudentRepository
  {
    private StudentDbContext db = null;

    public StudentRepository()
    {
      this.db = new StudentDbContext();
    }

    public StudentRepository(StudentDbContext db)
    {
      this.db = db;
    }

    public IEnumerable<Student> SelectAll()
    {
      return db.Students.ToList();
    }

    public Student SelectByID(int id)
    {
      return db.Students.Find(id);
    }

    public void Insert(Student student)
    {
      db.Students.Add(student);
    }

    public void Update(Student student)
    {
      db.Entry(student).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
      Student student = db.Students.Find(id);
      db.Students.Remove(student);
    }

    public void Save()
    {
      db.SaveChanges();
    }
  }
}
