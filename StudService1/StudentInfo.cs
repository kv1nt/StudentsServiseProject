using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace StudService1
{
    public class StudentInfo : IdEntity
    {
        [MaxLength(250)]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public int NumberRecordBook { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }


        public virtual ParentsInfo ParentsInfo { get; set; }
        public virtual Phone StudentPhone { get; set; }
        public virtual Adress Adress { get; set; }
        public virtual Group Group { get; set; }
        public virtual StudentProgress StudentProgress { get; set; }
    }
}