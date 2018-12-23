using NUnit.Framework;
using UnityEngine;
using TestDrivenDev;

namespace Tests
{
    public class PlayerTests
    {
        // A Test behaves as an ordinary method
        [Test(Description = "Newly created player objects should always have 100 health.")]
        public void Is_NewPlayer_Health_Equals_100()
        {
            //Arrange
            GameObject go = new GameObject("Player");
            Player player = go.AddComponent<Player>();

            //Act
            int playerHealth = player.Health;
            int expectedHealth = 100;

            //Assert
            Assert.AreEqual(expectedHealth, playerHealth);
        }

        // A Test behaves as an ordinary method
        [Test(Description = "Newly created player objects should always have 0 armor.")]
        public void Is_NewPlayer_Armor_Equals_0()
        {
            //Arrange
            GameObject go = new GameObject("Player");
            Player player = go.AddComponent<Player>();

            //Act
            int playerArmor = player.Armor;
            int expectedArmor = 0;

            //Assert
            Assert.AreEqual(expectedArmor, playerArmor);
        }
    }
}
