using apbd3.NewFolder;
using System.Collections.Generic;

namespace apbd3.functions
{
    public class IDbServiceImplementation : IDbService
    {
        private  IEnumerable<Student> _context;

        public string path = "datatrue.csv";

        public IDbServiceImplementation()
        {
            _context = new ReadFile().parseFileToCollection(); 
        }

        public  async Task<List<Student>> AddStudent(Student student)
        {
            String dataOfStudent = student.BackToformat();
             File.AppendAllText(path,  dataOfStudent );
            _context.Append(student);
            
            return _context.ToList();
        }

        public bool checkIfNumberIsUnique(string id)
        {
           return _context.Any(s => s.Id == id);
            
        }

        public List<Student> DeleteStudent(string identificator)
        {
            _context = _context.Where(predicate => predicate.Id != identificator);


            var Data = new List<string>(System.IO.File.ReadAllLines(path));
            Data.RemoveAll(e => e .Contains( identificator));
            File.WriteAllLines(path, Data.ToArray());
            return _context.ToList();
        }

        public Student GetStudent(string id)
        {
         Student s=   _context.FirstOrDefault(e => e.Id.Equals(id));
            return s;
        }

        public List<Student> GetStudents()
        {
            return _context.ToList();
            
        }

        public Student updateStudent(string id, Student updatedStudent)
        {
            // delete student with specific id
            var Data = new List<string>(System.IO.File.ReadAllLines(path));
            Data.RemoveAll(e => e.Contains(id));
            File.WriteAllLines(path, Data.ToArray());
            // insert updated student
            String dataOfStudent = updatedStudent.BackToformat();
            File.AppendAllText(path, dataOfStudent);
            return updatedStudent;
        }
    }
    
    
}
