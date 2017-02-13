using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class Phone : IdEntity
    {
        
        [Required]
        public int PhoneNumber { get; set; }
    }
}