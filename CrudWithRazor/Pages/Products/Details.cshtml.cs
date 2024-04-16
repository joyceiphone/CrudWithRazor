using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrudWithRazor.Models;
using CrudWithRazor.DAL;
using Microsoft.EntityFrameworkCore;

namespace CrudWithRazor.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly MyAppDbContext _context;

        public DetailsModel(MyAppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Products { get; set; }
		public async Task<IActionResult> OnGetAsync(int? itemid)
		{
			if (itemid == null)
			{
				return NotFound();
			}
			var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == itemid);

			if (product == null)
			{
				return NotFound();
			}
			Products = product;
			return Page();
		}
	}
}
