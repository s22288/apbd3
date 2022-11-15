using apbd3.NewFolder;

namespace apbd3.functions
{
    public class ReadFile
    {
        public IEnumerable<Student> parseFileToCollection()
        {

            var path = "datatrue.csv";
            var lines = File.ReadAllLines(path);
                var list = new List<Student>();
                foreach (var line in lines)
                {
                    var split = line.Split(",");
                var student = new Student
                {
                    FirstName = split[0],
                    LastName = split[1],
                    Id = split[2],
                    BirthDate = DateTime.Parse(split[3]),
                    study = split[4],
                    course = split[5],
                    email = split[6],
                    FathersName = split[7],
                    MothersName = split[8]
                   
                   
                };
                list.Add(student);
                
            }

                return list;
            }
        


    }
  

}
