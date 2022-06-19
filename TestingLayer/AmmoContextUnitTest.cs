using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
    public class AmmoContextUnitTest
    {
        private GameWikiDBContext dbContext;
        private CRUDContext<Ammo, int> ammoContext;
        private DbSet<Ammo> dbSet;
        DbContextOptionsBuilder builder;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            
        }
        
        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());

            dbContext = new GameWikiDBContext(builder.Options);
            ammoContext = new CRUDContext<Ammo, int>(dbSet, dbContext);
        }

        [Test]
        public void TestCreateAmmo()
        {
            int ammosBefore = ammoContext.ReadAll().Count();

            ammoContext.Create(new Ammo("testName", "testDescription", 443.5, DamageTypes.fire));

            int ammosAfter = ammoContext.ReadAll().Count();

            Assert.IsTrue(ammosBefore != ammosAfter);
        }

        [Test]
        
        public void TestReadAmmo()
        {
            ammoContext.Create(new Ammo("testName", "testDescription", 443.5, DamageTypes.fire));

            Ammo ammo = ammoContext.Read(1);

            Assert.That(ammo != null);
        }
    }
}
