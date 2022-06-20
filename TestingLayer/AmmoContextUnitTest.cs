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
            ammoContext = new CRUDContext<Ammo, int>(dbContext.Ammo, dbContext);
        }

        [Test]
        public void TestCreateAmmo()
        {
            int ammosBefore = ammoContext.ReadAll().Count();

            ammoContext.Create(new Ammo("testName", "testDescription", 443.5, DamageTypes.fire));

            int ammosAfter = ammoContext.ReadAll().Count();

            Assert.That(ammosAfter != ammosBefore);
        }

        [Test]
        public void TestReadAmmo()
        {
            ammoContext.Create(new Ammo("testName", "testDescription", 443.5, DamageTypes.fire));

            Ammo ammo = ammoContext.Read(1);

            Assert.That(ammo != null);
        }
        
        [Test]
        public void TestUpdateAmmo()
        {
            ammoContext.Create(new Ammo("testName", "testDescription", 443.5, DamageTypes.fire));

            Ammo ammo = ammoContext.Read(1);

            ammo.Name = "testName2";

            ammoContext.Update(ammo);

            Ammo ammo2 = ammoContext.Read(1);

            Assert.That(ammo2.Name == "testName2");
        }

        [Test]
        
        public void TestDeleteAmmo()
        {
            ammoContext.Create(new Ammo("testName", "testDescription", 443.5, DamageTypes.fire));

            int ammosBefore = ammoContext.ReadAll().Count();

            ammoContext.Delete(1);

            int ammosAfter = ammoContext.ReadAll().Count();

            Assert.That(ammosBefore != ammosAfter);
        }
    }
}
