using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class StudentInfo : IdEntity
    {
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

        public virtual Phone StudentPhones { get; set; }
        public virtual ParentsInfo ParentsInfo { get; set; }
        public virtual Adress Adress { get; set; }
        public virtual Group Group { get; set; }
        public virtual StudentProgress StudentProgress { get; set; }
    }
}