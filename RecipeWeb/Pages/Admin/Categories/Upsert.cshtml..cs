using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe.DataAccess.Data;
using Recipe.Models;
namespace razor_recipes.Pages.Admin.Categories
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public Category Category { get; set; }
        
        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Category = new();
        }
        public void OnGet(int? id)
        {
            if(id != null)
            {
                Category = _unitOfWork.Category.GetFirstOrDefault((c) => c.Id == id);
            }
        }

        public IActionResult OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "The Display order cannot Exactly match the name.");
                return Page();
            }

            if (ModelState.IsValid)
            {
                if (Category.Id == 0)
                {
                    _unitOfWork.Category.Add(Category);
                    TempData["success"] = "Category Created Successfully.";
                }
                else
                {
                    _unitOfWork.Category.Update(Category);
                    TempData["success"] = "Category Edited Successfully.";
                }
                _unitOfWork.Save();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}