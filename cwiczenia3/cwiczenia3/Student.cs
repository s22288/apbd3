namespace cwiczenia3
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public string Studies { get; set; }

        public string info()
        {
            return "Student: " + FirstName + " " + LastName + " " + IndexNumber + " " + BirthDate + " " + Email + " " + MothersName + " " + FathersName + " " + Studies;
        }
    }
}
