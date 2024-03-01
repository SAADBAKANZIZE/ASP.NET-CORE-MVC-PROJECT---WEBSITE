using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BulkyWebRazor.Data;
using BulkyWebRazor.Models;
namespace BulkyWebRazor.Pages.Categories
{
    [BindProperties]
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }
        public DetailsModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            if (id != null && id != 0)
            {
                Category = _db.categories.Find(id);
            }
        }
       
    }
}
