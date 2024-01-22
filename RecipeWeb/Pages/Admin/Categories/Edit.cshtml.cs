using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe.DataAccess.Data;
using Recipe.Models;

namespace razor_recipes.Pages.Admin.Categories;
public class EditModel : PageModel
{
    private IUnitOfWork _unitOfWork;
    [BindProperty]
    public Category Category { get; set; }
    public EditModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void OnGet(int id)
    {
        Category = _unitOfWork.Category.GetFirstOrDefault((c) => c.Id == id);
    }

    public async Task<IActionResult> OnPost()
    {
        if (Category.Name == Category.DisplayOrder.ToString())
        {
            ModelState.AddModelError(string.Empty, "The Displayorder cannot Exactly match the name.");
        }
        if (ModelState.IsValid)
        {
            _unitOfWork.Category.Update(Category);
            _unitOfWork.Save();
            TempData["success"] = "Category Edited Succesfully.";
            return RedirectToPage("Index");
        }
        return Page();
    }
}