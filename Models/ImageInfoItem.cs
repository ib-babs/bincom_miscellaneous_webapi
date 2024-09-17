using System.ComponentModel.DataAnnotations;

namespace MiscellaneousApi.Models
{
    public class ImageInfoItem
    {
        [Key]
        public long Id { get; set; }
        public string FileName { get; set; } = String.Empty;
        public string FilePath { get; set; } = String.Empty;
        public int FileSize { get; set; }

    }
}
