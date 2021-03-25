using System;
using NUnit.Framework;


namespace Ninjas
{
    [TestFixture]
    class UnitTests
    {
        [Test, Description("Player can defeat an enemy")]
        public void TestPlayerDefeatEnemy()
        {
            Player player = new Player();
            Enemy enemy = new Enemy();

            bool success = player.Attack(null);
            Assert.That(success, Is.EqualTo(false));

            Assert.That(enemy.health.health, Is.EqualTo(40));
            Assert.That(enemy.health.IsAlive(), Is.EqualTo(true));
            success = player.Attack(enemy);
            Assert.That(success, Is.EqualTo(true));
            Assert.That(enemy.health.health, Is.EqualTo(10));
            Assert.That(enemy.health.IsAlive(), Is.EqualTo(true));
            success = player.Attack(enemy);
            Assert.That(success, Is.EqualTo(true));
            Assert.That(enemy.health.health, Is.EqualTo(0));
            Assert.That(enemy.health.IsAlive(), Is.EqualTo(false));

            success = player.Attack(enemy);
            Assert.That(success, Is.EqualTo(false));


        }
    }
}