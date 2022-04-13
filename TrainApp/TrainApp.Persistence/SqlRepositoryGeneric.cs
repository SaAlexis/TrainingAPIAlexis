using Microsoft.EntityFrameworkCore;
using TrainApp.Entities;

namespace TrainApp.Persistence
{
    //TODO : gestion des exceptions 
    public class SqlRepositoryGeneric<T> : IRepositoryGeneric<T> where T : class, IBaseEntity
    {
        private DbContext SqlContext { get; }

        public SqlRepositoryGeneric(DbContext sqlContext)
        {
            SqlContext = sqlContext;
        }

        public IEnumerable<T> GetAll()
        {
            return SqlContext.Set<T>();
        }

        public T GetSingle(int id)
        {
            return GetAll().Single(entity => entity.Id == id);
        }

        public int Create(T entityToCreate)
        {
            SqlContext.Attach(entityToCreate);
            
            return SqlContext.SaveChanges();
        }

        public int Delete(int id)
        {
            var completeItemEntityToDelete = GetSingle(id);

            SqlContext.Remove(completeItemEntityToDelete);

            return SqlContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            if (entity != null)
            {
                SqlContext.Update(entity);
                SqlContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
