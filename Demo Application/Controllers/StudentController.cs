using Demo_Application.Data;
using Demo_Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Application.Controllers
{
    [ApiController]
    //[Route("student")]
    [Route("[Controller]")]
    public class StudentController : ControllerBase
    {
        public readonly ApplicationDbContext context;
        public StudentController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "GetStudents")]
        public ActionResult<IEnumerable<Student>> getStudents() {
            var objectList = context.Students.ToList();
            return Ok(objectList);
        }
        [HttpGet("{id:int}")]
        public ActionResult<Student> getStudent(int id)
        {
            Student student = context.Students.Find(id);
            if(student == null) return NotFound("No Student Found");
            return Ok(student);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Student>> addStudent(Student student)
        { 
            context.Students.Add(student);
            context.SaveChanges();
            return Ok(student);
        }

        [HttpDelete]
        public ActionResult<Student> deleteStudent(int id)
        {
            Student student = context.Students.Find(id);
            if(student == null) return NotFound("No Student Found");
            context.Students.Remove(student);
            context.SaveChanges();
            return Ok(student);
        }

    }
}
