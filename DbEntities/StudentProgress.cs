using System.ComponentModel.DataAnnotations;

namespace DbEntities
{
    public class StudentProgress: IdEntity
    {
       
       [Required]
        public float Progress { get; set; }

        public StudentProgress Copy()
        {
            return new StudentProgress
            {
                Progress = this.Progress,
                Id = this.Id
            };
        }
    }
}