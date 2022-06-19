using BusinessLayer;
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
            dbSet.Add(item);
            context.SaveChanges();
        }

        public void Delete(K key)
        {
            dbSet.Remove(Read(key, false));
            context.SaveChanges();
        }

        public T Read(K key, bool takeNavigationProperties = false)
        {
            switch (dbSet.EntityType.ShortName())
            {
                case "Ammo":
                    return takeNavigationProperties ? context.Ammo.Include(a => a.Weapons).SingleOrDefault(a => a.ID == Convert.ToInt32(key)) as T : context.Ammo.SingleOrDefault(a => a.ID == Convert.ToInt32(key)) as T;
                case "Enemy":
                    return takeNavigationProperties ? context.Enemies.Include(e => e.Weapons).SingleOrDefault(a => a.ID == Convert.ToInt32(key)) as T : context.Enemies.SingleOrDefault(a => a.ID == Convert.ToInt32(key)) as T;
                case "Weapon":
                    return takeNavigationProperties ? context.Weapons.Include(w => w.Ammo).SingleOrDefault(a => a.ID == Convert.ToInt32(key)) as T : context.Weapons.SingleOrDefault(a => a.ID == Convert.ToInt32(key)) as T;
                default:
                    throw new ArgumentException("Type not suported!");
            }
        }

        public IEnumerable<T> ReadAll(bool takeNavigationProperties = false)
        {
            switch (dbSet.EntityType.ShortName())
            {
                case "Ammo":
                    return takeNavigationProperties ? context.Ammo.Include(a => a.Weapons).ToList() as IEnumerable<T> : context.Ammo.ToList() as IEnumerable<T>;
                case "Enemy":
                    return takeNavigationProperties ? context.Enemies.Include(e => e.Weapons).ToList() as IEnumerable<T> : context.Enemies.ToList() as IEnumerable<T>;
                case "Weapon":
                    return takeNavigationProperties ? context.Weapons.Include(w => w.Ammo).ToList() as IEnumerable<T> : context.Weapons.ToList() as IEnumerable<T>;
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
