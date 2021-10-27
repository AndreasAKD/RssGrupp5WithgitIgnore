using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Skapa(T entity);
        void TaBort(int index);
        void UppdateraPodd(int index, T newEntity);
        List<T> HamtaAlla();

        int hamtaIndexAvNamn(string name);

    }
}
