using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe.DataAccess.Data;
using Recipe.Models;

namespace razor_recipes.Pages.Admin.Categories;

public class DeleteModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;
    [BindProperty]
    public Category Category { get; set; }
    public DeleteModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public void OnGet(int id)
    {
        Category = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);
    }

    public async Task<IActionResult> OnPost()
    {
        var CategoryFromDb = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == Category.Id);
        if (CategoryFromDb != null)
        {
            _unitOfWork.Category.Remove(CategoryFromDb);
            _unitOfWork.Save();
            TempData["success"] = "Category Delete Succesfully.";
            return RedirectToPage("Index");
        }
        return Page();
    }

}