
using MedicalAppoiment.Domain.Result;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MedicalAppoiment.Domain.Repositories
{
    public interface IBaseRepository <TEntity> where TEntity : class
    {
        Task <OperationResult> save (TEntity entity);
        Task <OperationResult> update (TEntity entity);
        Task <OperationResult>remove (TEntity entity);
        Task <OperationResult> GetAll();
        Task<OperationResult> GetEntityBy(int Id);
        Task <OperationResult> Exists (Expression<Func<TEntity, bool>> filter);

    }
}
