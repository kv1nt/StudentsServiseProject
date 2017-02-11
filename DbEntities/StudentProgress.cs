using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class StudentProgress: IdEntity
    {
        [Required]
        public float Progress { get; set; }
    }
}