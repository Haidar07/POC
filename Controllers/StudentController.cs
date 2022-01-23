using Microsoft.AspNetCore.Mvc;
using POCApp.Data;
using POCApp.Models;

namespace POCApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public readonly ApplicationDBContext _db;

        public StudentController(ApplicationDBContext db)
        {
            _db = db;
            Console.WriteLine(_db.Students);
        }

        [HttpGet(Name = "GetStudent")]
        public IEnumerable<Student> Get()
        {
            IEnumerable<Student> st = _db.Students;
            return st;
        }

        [HttpPost]
        public void Post(Student student)
        {
            _db.Add(student);
            _db.SaveChanges();
        }
    }
}
