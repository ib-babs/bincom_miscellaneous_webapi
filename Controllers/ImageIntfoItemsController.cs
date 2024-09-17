using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MiscellaneousApi.Models;

namespace MiscellaneousApi.Controllers
{

    [Route("api/imageinfo/[controller]")]
    [ApiController]
    public class ImageIntfoItemsController(MiscellaneousDbContext context) : ControllerBase
    {
        private readonly MiscellaneousDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImageInfoItem>>> GetImageInfoItems()
        {
            return await _context.ImageInfoItems.OrderBy(item => item.Id).ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ImageInfoItem>> GetImageInfoItem(long id)
        {
            var imageInfo = await _context.ImageInfoItems.FindAsync(id);
            if (imageInfo == null)
            {
                return NotFound();
            }
            return imageInfo;
        }

        [HttpPost]
        public async Task<ActionResult<ImageInfoItem>> PostImageInfoItem(ImageInfoItem imgInfo)
        {
            _context.ImageInfoItems.Add(imgInfo);
                await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetImageInfoItem), new { id = imgInfo.Id }, imgInfo);
        }

    }
}
