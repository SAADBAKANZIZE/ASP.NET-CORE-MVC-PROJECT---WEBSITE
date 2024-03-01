using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BulkyWebRazor.Data;
using BulkyWebRazor.Models;


namespace BulkyWebRazor.Pages.Categories
{
    [BindProperties]

    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            if (id != null && id!= 0)
            {
                Category = _db.categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {

            /*
                if (obj.Name == obj.DisplayOrder.ToString())
                {
                    ModelState.AddModelError("Name", "The displayOrder cannot match exactly the name");
                }
            */
            if (ModelState.IsValid)
            {

                _db.categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }

    }
}
