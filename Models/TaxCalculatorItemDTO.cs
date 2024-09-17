using System.ComponentModel.DataAnnotations;

namespace MiscellaneousApi.Models
{
    public class TaxCalculatorItemDTO
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "Enter your income")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Must be an integer or double")]
        public double AnnualIncome { get; set; }
    }
}
