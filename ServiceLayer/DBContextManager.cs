using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer
{
    public static class DBContextManager
    {
        private static GameWikiDBContext _context;
        private static CRUDContext<Enemy, int> _enemyContext;
        private static CRUDContext<Weapon, int> _weaponContext;
        private static CRUDContext<Ammo, int> _ammoContext;
        //public DbSet<Enemy> Enemies = _context.Enemies;


        #region DB Context
        public static GameWikiDBContext CreateContext()
        {
            _context = new GameWikiDBContext();
            return _context;
        }

        public static GameWikiDBContext GetContext()
        {
            return _context;
        }
        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }

        #endregion
        
        #region TContext

        #region EnemyContext
        public static CRUDContext<Enemy, int> CreateEnemyContext(GameWikiDBContext context)
        {
            _enemyContext = new CRUDContext<Enemy, int>(context.Enemies, context);
            return _enemyContext;
        }

        public static CRUDContext<Enemy, int> GetEnemyContext() 
        {
            return _enemyContext;
        }
        #endregion

        #region WeaponContext
        public static CRUDContext<Weapon, int> CreateWeaponContext(GameWikiDBContext context) 
        {
            _weaponContext = new CRUDContext<Weapon, int>(context.Weapons, context);
            return _weaponContext;
        }
        
        public static CRUDContext<Weapon, int> GetWeaponContext()
        {
            return _weaponContext;
        }

        #endregion

        #region AmmoContext
        public static CRUDContext<Ammo, int> CreateAmmoContext(GameWikiDBContext context) 
        {
            _ammoContext = new CRUDContext<Ammo, int>(context.Ammo, context);
            return _ammoContext;
        }
        
        public static CRUDContext<Ammo, int> GetAmmoContext()
        {
            return _ammoContext;
        }
        #endregion

        #endregion


    }
}
