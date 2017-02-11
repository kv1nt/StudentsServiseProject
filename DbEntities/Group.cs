using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class Group : IdEntity
    {
        [MaxLength(100)]
        [Required]
        public string Speciality { get; set; }
    }
}