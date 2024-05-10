using Kernel.Results;

namespace Kernel.Data;

public interface IRepository<T> where T : EntityBase
{
    // This interface ensures that we can only carry out database actions on classes with the EntityBase marker that identifies them as database entities.
    // It specifies all the command database command actions, but purposely only defines one query method for GetById. Queries will have requirements that are very entity-specific, so I'm envisioning that each implementation of this interface will define its own custom GetBy{Parameter} and GetMultipleBy{Parameter} methods.

    #region Query Methods
    Task<Result<T?>> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);
    #endregion

    #region Command Methods
    Task<Result<Guid?>> AddAsync(T entity);
    Task<Result<IEnumerable<Guid?>>> AddRangeAsync(IEnumerable<T> entities);
    Task<Result> UpdateAsync(T entity);
    Task<Result> UpdateRangeAsync(IEnumerable<T> entities);
    Task<Result> RemoveAsync(Guid Id);
    Task<Result> RemoveRangeAsync(IEnumerable<T> entities);
    #endregion
}
