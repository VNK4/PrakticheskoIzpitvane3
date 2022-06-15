using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CRUDContext<T, K> : IDB<T, K> where T : class
    {
        private DbSet<T> dbSet;
        private GameWikiDBContext context;

        public CRUDContext(DbSet<T> dbSet, GameWikiDBContext context)
        {
            this.dbSet = dbSet;
            this.context = context;
        }

        public void Create(T item)
        {
            switch (dbSet.EntityType.ShortName())
            {
                case "Customer":
                    break;
                case "Product":
                    break;
                case "Order":
                    break;
                case "OrdersProductsQuantities":
                    break;
                default:
                    throw new ArgumentException("Type not suported!");
            }

            dbSet.Add(item);
            context.SaveChanges();
        }

        public void Delete(K key)
        {
            dbSet.Remove(Read(key));
            context.SaveChanges();
        }

        public T Read(K key)
        {
            switch (dbSet.EntityType.ShortName())
            {
                case "Ammo":
                    return context.Ammo.Find(key) as T;
                case "Enemy":
                    return context.Enemies.Find(key) as T;
                case "Weapon":
                    return context.Weapons.Find(key) as T;
                default:
                    throw new ArgumentException("Type not suported!");
            }
        }

        public IEnumerable<T> ReadAll()
        {
            switch (dbSet.EntityType.ShortName())
            {
                case "Ammo":
                    return context.Ammo.ToList() as IEnumerable<T>;
                case "Enemy":
                    return context.Enemies.ToList() as IEnumerable<T>;
                case "Weapon":
                    return context.Weapons.ToList() as IEnumerable<T>;
                default:
                    throw new ArgumentException("Type not suported!");
            }
        }

        public void Update(T item)
        {
            dbSet.Update(item);
            context.SaveChanges();
        }
    }
}
