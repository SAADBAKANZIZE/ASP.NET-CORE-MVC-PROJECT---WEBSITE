using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BulkyWebRazor.Data;
using BulkyWebRazor.Models;

namespace BulkyWebRazor.Pages.Categories
{
    [BindProperties]

    public class CreateModel : PageModel
    {
        
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {

        }
        public IActionResult OnPost()
        {
           
            /*
                if (obj.Name == obj.DisplayOrder.ToString())
                {
                    ModelState.AddModelError("Name", "The displayOrder cannot match exactly the name");
                }

                if (ModelState.IsValid)
                {
            */
                    _db.categories.Add(Category);
                    _db.SaveChanges();
                     TempData["success"] = "Category created successfully";
                     return RedirectToPage("Index");
         }

               
            
    }
}
