using TestMVC.Data.Infrastructure;
using TestMVC.Data.Repositories;
using TestMVC.Model;

namespace TestMVC.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void SaveChanges();
    }

    public class ErrorService : IErrorService
    {
        public IErrorRepository _errorRepository;
        public IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}