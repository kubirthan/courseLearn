using learn.Data;
using learn.Model;
using learn.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn.Pages.Companies
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitofwork _unitofwork;

        public DeleteModel(IUnitofwork unitofwork)
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
            var ObjFromDb = _unitofwork.Company.Get(x => x.Id == Company.Id);

            if(ObjFromDb != null)
            {
                _unitofwork.Company.Remove(ObjFromDb);
                _unitofwork.Save();

                return RedirectToPage("index");
            }

            return Page();
        }
    }
}
