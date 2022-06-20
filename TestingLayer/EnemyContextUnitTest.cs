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
    public class EnemyContextUnitTest
    {
        private GameWikiDBContext dbContext;
        private CRUDContext<Enemy, int> enemyContext;
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
            enemyContext = new CRUDContext<Enemy, int>(dbContext.Enemies, dbContext);
        }

        [Test]
        public void TestCreateEnemy()
        {
            int enemysBefore = enemyContext.ReadAll().Count();

            enemyContext.Create(new Enemy("testName", "testDescription", 123, 321, true, Behaviours.passive, DamageTypes.lightning));

            int enemysAfter = enemyContext.ReadAll().Count();

            Assert.That(enemysAfter != enemysBefore);
        }

        [Test]
        public void TestReadEnemy()
        {
            enemyContext.Create(new Enemy("testName", "testDescription", 123, 321, true, Behaviours.passive, DamageTypes.lightning));

            Enemy enemy = enemyContext.Read(1);

            Assert.That(enemy != null);
        }

        [Test]
        public void TestUpdateEnemy()
        {
            enemyContext.Create(new Enemy("testName", "testDescription", 123, 321, true, Behaviours.passive, DamageTypes.lightning));

            Enemy enemy = enemyContext.Read(1);

            enemy.Name = "testName2";

            enemyContext.Update(enemy);

            Enemy enemy2 = enemyContext.Read(1);

            Assert.That(enemy2.Name == "testName2");
        }

        [Test]

        public void TestDeleteEnemy()
        {
            enemyContext.Create(new Enemy("testName", "testDescription", 123, 321, true, Behaviours.passive, DamageTypes.lightning));

            int enemysBefore = enemyContext.ReadAll().Count();

            enemyContext.Delete(1);

            int enemysAfter = enemyContext.ReadAll().Count();

            Assert.That(enemysBefore != enemysAfter);
        }
    }
}
