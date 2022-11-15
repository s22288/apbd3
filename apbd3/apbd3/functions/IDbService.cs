using apbd3.NewFolder;

namespace apbd3.functions
{
    public interface IDbService
    {
        public List<Student> GetStudents();
        public Student GetStudent(string id);
        public List<Student> DeleteStudent(String identificator);
        public  Task<List<Student>> AddStudent(Student student);

        public bool checkIfNumberIsUnique(string id);


        public Student updateStudent(String id, Student updatedStudent);

        
        
        
    }
}
