using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Skapa(T entity);
        void TaBort(int index);
        void Updatera(int index, T newEntity);
        List<T> HamtaAlla();

    }
}
