using System.ComponentModel.DataAnnotations;

namespace AVG.Models
{
    public class ProjectModel
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; }
        public string ImagePath { get; set;}
    }
}
