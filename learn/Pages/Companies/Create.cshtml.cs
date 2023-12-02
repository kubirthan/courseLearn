using learn.Data;
using learn.Model;
using learn.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn.Pages.Companies
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitofwork _unitofwork;

        public CreateModel(IUnitofwork unitofwork)
        {
            _unitofwork=unitofwork;
        }

        public Company Company { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _unitofwork.Company.Add(Company);
                _unitofwork.Save();

                return RedirectToPage("index");
            }

            return Page();
        }
    }
}
