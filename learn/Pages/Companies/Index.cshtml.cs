using learn.Data;
using learn.Model;
using learn.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learn.Pages.Companies
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly IUnitofwork _unitofwork;

        public IndexModel(IUnitofwork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public IEnumerable<Company> Companies { get; set; }
        public void OnGet()
        {
            Companies = _unitofwork.Company.GetAll();
        }
    }
}
