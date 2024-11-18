using System.ComponentModel.DataAnnotations;

namespace AVG.Models
{
    public class ProjectModel
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Technologies { get; set; } = string.Empty;
        public string ImagePath { get; set;} = string.Empty;
    }
}
