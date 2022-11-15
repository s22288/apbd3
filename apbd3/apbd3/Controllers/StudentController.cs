using apbd3.functions;
using apbd3.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apbd3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IDbService _dbService ;

        public StudentController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
           List<Student> studenci =  _dbService.GetStudents();
            if(studenci == null)
            {
                return NotFound();
            }
            return Ok(_dbService.GetStudents());
           
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(String id)
        {
            Student s1 = _dbService.GetStudent(id);
           if(s1 == null)
            {
                return BadRequest(" 400 nie ma studenta o tym id");
            }
            return Ok(s1);

        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(String id)
        {
            Student s1 = _dbService.GetStudent(id);
           if (s1 == null)
            {
                return BadRequest(" 400 nie ma studenta o tym id");
            }

         List<Student> students =   _dbService.DeleteStudent(id);

            // lista pozostałych studentów

            return Ok(students);

        }
        [HttpPut("{id}")]
        public IActionResult PutStudent(String id, Student updateStudent)
        {
            if (!_dbService.checkIfNumberIsUnique(id))
            {
                return BadRequest(" 400 Nie ma studenta o takim id");
            }

            Student updated =_dbService.updateStudent(id, updateStudent);



            return Ok("student o id " + id + " został zaktualizowany " + " jego nowe dane to " + updated.FirstName + " , " + updated.LastName);
        }
        [HttpPost]
        public IActionResult PostStudent(Student student)
        {
           
            if (_dbService.checkIfNumberIsUnique(student.Id))
            {
                return BadRequest(" 400 Student o tym id już istnieje");
            }
            if (!ValidateId.validateId(student.Id))
            { 
                    return BadRequest(" 400 niepoprawne id");
               
            }
            _dbService.AddStudent(student);

            return Ok(" 200 Student ma kompletne dane");
        }

    }
    
}
