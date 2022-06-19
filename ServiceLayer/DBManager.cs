using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ServiceLayer
{
    public class DBManager<T, K>
    {
        IDB<T, K> context;
        public DBManager(IDB<T, K> context)
        {
            this.context = context;
        }

        public void Create(T item)
        {
            try
            {
                context.Create(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T Read(K key, bool takeNavigationProperties = false)
        {
            try
            {
                return context.Read(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> ReadAll(bool useNavigationProperties)
        {
            try
            {
                return context.ReadAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T item)
        {
            try
            {
                context.Update(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(K key) 
        {
            try
            {
                context.Delete(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
                
        }
    }
}
