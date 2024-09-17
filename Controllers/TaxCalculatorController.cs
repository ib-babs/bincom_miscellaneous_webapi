using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiscellaneousApi.Models;

namespace MiscellaneousApi.Controllers
{
    [Route("api/tax/[controller]")]
    [ApiController]
    public class TaxCalculatorController(MiscellaneousDbContext context) : ControllerBase
    {
        private readonly MiscellaneousDbContext _context = context;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaxCalculatorItem>>> GetTaxItems()
        {
            return await _context.TaxCalculatorItems.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TaxCalculatorItem>> GetTaxItem(long id)
        {
            var imageInfo = await _context.TaxCalculatorItems.FindAsync(id);
            if (imageInfo == null)
            {
                return NotFound();
            }
            return imageInfo;
        }

        [HttpPost]
        public async Task<ActionResult<TaxCalculatorItemDTO>> PostTaxItem(TaxCalculatorItemDTO taxCalcDTO)
        {
            TaxCalculatorItem taxCalc = new()
            {
                Id = taxCalcDTO.Id,
                AnnualIncome = taxCalcDTO.AnnualIncome,
            };
            taxCalc.TaxPaid = NigeriaTaxCalculator.Calculator(taxCalc.AnnualIncome);
            _context.TaxCalculatorItems.Add(taxCalc);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTaxItem), new { id = taxCalcDTO.Id }, taxCalcDTO);
        }

        private static TaxCalculatorItemDTO ItemDTO(TaxCalculatorItem taxCalcItem)
        {
            return new()
            {
                Id = taxCalcItem.Id,
                AnnualIncome = taxCalcItem.AnnualIncome
            };

        }
    }
}
