using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalBase<T>  where T : class
    {
        public List<T> GetAll()
        {
            return null;
        }

        public void Add(T DTO)
        {

        }

        public void Delete(int id)
        {

        }

        public void Update(T DTO)
        {

        }
    }
}
