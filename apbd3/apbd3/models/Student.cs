using System.ComponentModel.DataAnnotations;

namespace apbd3.NewFolder
{
    public class Student
    {

        [Display(Name =" FirstName"),Required]
        public string FirstName { get; set; }
        [Display(Name = " LastName"), Required]
        public string LastName { get; set; }
        [Display(Name = " Id "), Required]
        public string Id { get; set; }
        [Display(Name = " BirthDate "), Required]
        public DateTime BirthDate { get; set; }
        [Display(Name = " study "), Required]
        public string study { get; set; }
        [Display(Name = " course "), Required]
        public string course { get; set; }
        [Display(Name = " email "), Required]
        public string email { get; set; }
        [Display(Name = " fathersName "), Required]
        public string FathersName { get; set; }
        [Display(Name = " Mothers Name "), Required]
        public string MothersName { get; set; }

        public String BackToformat()
        {
            return FirstName + "," + LastName + "," + Id + "," + BirthDate + "," + study + "," + course + "," + email + "," + FathersName + "," + MothersName;
    }

    }
   
}
