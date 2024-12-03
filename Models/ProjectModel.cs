using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AVG.Models
{
    public class ProjectModel
    {
        //[Required] не пустое
        //[Key]первичный ключ
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //автоинкремент
        [Required][Key] public int Id { get; set; }
        [Required] public string Title { get; set; } = string.Empty;
        [Required] public string Description { get; set; } = string.Empty;
        [Required] public string BriefDescription {  get; set; } = string.Empty;    
        public string Technologies { get; set; } = string.Empty;
        public string ExampleScript { get; set; } = string.Empty;
        [Required] public string ImagePath { get; set;} = string.Empty;
        public string Link {  get; set;} = string.Empty;
        public string Slug { get; set; } = string.Empty;
    }
}
