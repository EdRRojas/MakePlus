
namespace MakePlus.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetEntity(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
