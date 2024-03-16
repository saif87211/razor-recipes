using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Recipe.DataAccess.Data;
using Recipe.Models;
namespace razor_recipes.Pages.Admin.Recipes
{
    [BindProperties]
    public class Upsert : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public Recipe.Models.Recipe Recipe { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public Upsert(IUnitOfWork unitOfWork, IWebHostEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }
        public void OnGet()
        {
            CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public IActionResult OnPost()
        {
            var webRootPath = _hostingEnvironment.ContentRootPath;
            var files = HttpContext.Request.Form.Files;
            if(Recipe.RecipeId == 0)
            {
                //Create Request
                var fileName = Guid.NewGuid().ToString();
                var folderPath = Path.Combine(webRootPath,@"image\Food");
                var extension = Path.GetExtension(files[0].Name);

                using var fileStream = new FileStream(Path.Combine(folderPath,fileName + extension),FileMode.Create);

                files[0].CopyTo(fileStream);
                
                Recipe.Image = @"\images\Food" +fileName + extension;

                _unitOfWork.Recipe.Add(Recipe);
            }
            else
            {
                //Update Request
            }
            return Page();
        }
    }
}