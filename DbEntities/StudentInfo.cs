using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DbEntities
{
    public class StudentInfo : IdEntity
    {
        public StudentInfo()
        {
            StudentPhones = new List<Phone>();
            ParentsInfo = new List<ParentsInfo>();
        }
        [MaxLength(250)]
        [Required]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [MaxLength(250)]
        [Required]
        public string Surname { get; set; }
        [Required]
        public int NumberRecordBook { get; set; }
        [Required]
        public int Age { get; set; }
        [MaxLength(250)]
        [Required]
        public string Sex { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Phone> StudentPhones { get; set; }
        public virtual ICollection<ParentsInfo> ParentsInfo { get; set; }
        public virtual Adress Adress { get; set; }
        public virtual Group Group { get; set; }
        public virtual StudentProgress StudentProgress { get; set; }

        public StudentInfo Copy()
        {
            var newStudent = new StudentInfo
            {
                Age = this.Age,
                Birthdate = this.Birthdate,
                FirstName = this.FirstName,
                LastName = this.LastName,
                //Adress = this.Adress?.Copy(), // Same
                Group = this.Group?.Copy(),
                NumberRecordBook = this.NumberRecordBook,
                Sex = this.Sex,
                Surname = this.Surname,
                Id = this.Id,
                StudentProgress = this.StudentProgress?.Copy(),
                StudentPhones = this.StudentPhones?.Select(x => x.Copy()).ToList(),
                ParentsInfo = this.ParentsInfo?.Select(x => x.Copy()).ToList()
            };

            if (this.Adress != null)   //Same
                newStudent.Adress = this.Adress.Copy(); 

            return newStudent;
        }
    }
}