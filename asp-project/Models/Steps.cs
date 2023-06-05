using System.ComponentModel.DataAnnotations;

namespace asp_project.Models
{
    public class Steps
    {
        public int StepsNumber { get; set; }
        [Key]
        public DateTime StepsDate { get; set; }
    }
}
