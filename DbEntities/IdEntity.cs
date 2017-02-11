using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class IdEntity
    {
        [Key]
        public int Id { get; set; }  
    }
}