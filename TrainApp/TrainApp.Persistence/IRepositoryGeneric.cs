using System;
using System.Collections.Generic;
using System.Text;


namespace TrainApp.Persistence
{
    public interface IRepositoryGeneric<T>
    {
        IEnumerable<T> GetAll();

        T GetSingle(int id);

        int Create(T t);

        int Delete(int id);

        bool Update(T entity);
    }
}
