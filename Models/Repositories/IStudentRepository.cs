namespace assignment_2.Models.Repositories
{
  public interface IStudentRepository
  {
    IEnumerable<Student> SelectAll();
    Student SelectByID(int id);
    void Insert(Student student);
    void Update(Student student);
    void Delete(int id);
    void Save();
  }
}
