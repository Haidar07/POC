using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            Console.WriteLine(st);
            
            return st;
        }

        [HttpPost]
        public JsonResult Post(Student student)
        {
            Console.WriteLine(student);
            _db.Add(student);
            _db.SaveChanges();

            return new JsonResult("Added Successfully");
        }

        [HttpPut(Name = "EditStudent")]
        public JsonResult Put(Student st)
        {
            _db.Students.Update(st);
            _db.SaveChanges();

            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id:int}")] 
        public JsonResult Delete(int id)
        {
            Student s = _db.Students.Find(id);
            _db.Students.Remove(s);
            _db.SaveChanges();

            return new JsonResult("Deleted Successfully");
        }

        [Route("GetAllStudentNames")]
        [HttpGet]
        public JsonResult GetAllStudentNames()
        {
            IEnumerable<String> names = _db.Students.Select(u => u.FirstName);

            var JsonStudent = JsonConvert.SerializeObject(names);
            return new JsonResult(JsonStudent);
        }
    }
}
