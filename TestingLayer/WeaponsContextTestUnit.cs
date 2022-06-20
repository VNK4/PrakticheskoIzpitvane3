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
    public class WeaponsContextTestUnit
    {
        private GameWikiDBContext dbContext;
        private CRUDContext<Weapon, int> weaponContext;
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
            weaponContext = new CRUDContext<Weapon, int>(dbContext.Weapons, dbContext);
        }

        [Test]
        public void TestCreateWeapon()
        {
            int weaponsBefore = weaponContext.ReadAll().Count();

            weaponContext.Create(new Weapon("testName", "testDescription", 324));
            
            int weaponsAfter = weaponContext.ReadAll().Count();

            Assert.That(weaponsAfter != weaponsBefore);
        }

        [Test]
        public void TestReadWeapon()
        {
            weaponContext.Create(new Weapon("testName", "testDescription", 324));

            Weapon weapon = weaponContext.Read(1);

            Assert.That(weapon != null);
        }

        [Test]
        public void TestUpdateWeapon()
        {
            weaponContext.Create(new Weapon("testName", "testDescription", 324));

            Weapon weapon = weaponContext.Read(1);

            weapon.Name = "testName2";

            weaponContext.Update(weapon);

            Weapon weapon2 = weaponContext.Read(1);

            Assert.That(weapon2.Name == "testName2");
        }

        [Test]

        public void TestDeleteWeapon()
        {
            weaponContext.Create(new Weapon("testName", "testDescription", 324));

            int weaponsBefore = weaponContext.ReadAll().Count();

            weaponContext.Delete(1);

            int weaponsAfter = weaponContext.ReadAll().Count();

            Assert.That(weaponsBefore != weaponsAfter);
        }
    }
}
