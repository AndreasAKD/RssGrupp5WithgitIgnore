using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer.Repositories
{
    public interface IPodcastRepository<T> : IRepository<T> where T : Pod
    {

    }
}
