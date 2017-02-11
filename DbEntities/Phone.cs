using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class Phone : IdEntity
    {
        
        [Required]
        public string PhoneNumber { get; set; }
    }
}