namespace cwiczenia3
{
    public class ReadFile
    {
        public HashSet<Student> students = new HashSet<Student>();
        public void readFile()
        {
            {
                
                var lines = System.IO.File.ReadAllLines("data.csv");
                foreach (var line in lines)
                {
                    var split = line.Split(",");
                    var student = new Student();
                    student.FirstName = split[0];
                    student.LastName = split[1];
                    student.IndexNumber = split[4];
                    student.BirthDate = split[5];
                    student.Email = split[6];
                    student.MothersName = split[7];
                    student.FathersName = split[8];
                    student.Studies = split[2];
                    students.Add(student);
                    Console.WriteLine(student.info());
                }
                


            }
        }
        private static void Main(string[] args)
        {
            ReadFile readFile = new ReadFile();
            readFile.readFile();
        }
    }



}
