using learn.Data;
using learn.Model;
using learn.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn.Pages.Companies
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitofwork _unitofwork;

        public EditModel(IUnitofwork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public Company Company { get; set; }
        public void OnGet(int id)
        {
            Company = _unitofwork.Company.Get(x => x.Id == id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _unitofwork.Company.Update(Company);
                _unitofwork.Save();

                return RedirectToPage("index");
            }

            return Page();
        }
    }
}
