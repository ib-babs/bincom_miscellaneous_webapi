using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiscellaneousApi.Models
{
    public class CVItem
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = String.Empty;
        [NotMapped]
        public Dictionary<string, string>? Projects { get; set; }
        [NotMapped]
        public Dictionary<string, string>? Contacts { get; set; }
        public string Summary { get; set; } = String.Empty;
        [NotMapped]
        public List<Dictionary<string, string>>? Education { get; set; }
        [NotMapped]
        public List<Dictionary<string, string>>? Experience { get; set; }
        [NotMapped]
        public List<Dictionary<string, List<string>>>? ExperienceRole { get; set; }
        [NotMapped]
        public List<string>? Skills { get; set; }
        public List<string>? Languages { get; set; }
    }
}
