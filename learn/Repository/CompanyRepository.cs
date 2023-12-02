using learn.Data;
using learn.Model;
using learn.Repository.IRepository;

namespace learn.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CompanyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public void Update(Company company)
        {
            var objFromdb = _dbContext.Companies.FirstOrDefault(x=>x.Id == company.Id);
            if (objFromdb != null)
            {
                objFromdb.Name = company.Name;
                objFromdb.Location = company.Location;
            }
        }
    }
}
