using learn.Repository.IRepository;

namespace learn.UnitOfWork
{
    public interface IUnitofwork : IDisposable
    {
        ICompanyRepository Company { get; }

        void Save();
    }
}
