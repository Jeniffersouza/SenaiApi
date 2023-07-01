using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository.Interface
{
    public interface IGenericrepository<T>  where T : class
    {
        IQueryable<T> GetAll();

    }
}
