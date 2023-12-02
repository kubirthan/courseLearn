using learn.Data;
using learn.Repository;
using learn.Repository.IRepository;

namespace learn.UnitOfWork
{
    public class Unitofwork : IUnitofwork
    {
        private readonly ApplicationDbContext _dbContext;

        public Unitofwork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Company = new CompanyRepository(_dbContext);
        }
        public ICompanyRepository Company {  get;private set; }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
