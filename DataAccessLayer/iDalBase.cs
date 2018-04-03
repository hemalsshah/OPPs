using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface iDalBase<T> where T : class
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}
