using NUnit.Framework;
using UnityEngine;
using TestDrivenDev;

namespace Tests
{
    public class PlayerTests
    {
        GameObject _playerObject;
        Player _player;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            _playerObject = new GameObject("Player");
            _player = _playerObject.AddComponent<Player>();
        }

        [TearDown]
        public void TearDown()
        {
            Object.Destroy(_playerObject);
        }

        // A Test behaves as an ordinary method
        [Test(Description = "Newly created player objects should always have 100 health.")]
        public void Is_NewPlayer_Health_Equals_100()
        {
            //Act
            int playerHealth = _player.Health;
            int expectedHealth = 100;

            //Assert
            Assert.AreEqual(expectedHealth, playerHealth);
        }

        // A Test behaves as an ordinary method
        [Test(Description = "Newly created player objects should always have 0 armor.")]
        public void Is_NewPlayer_Armor_Equals_0()
        {
            //Act
            int playerArmor = _player.Armor;
            int expectedArmor = 0;

            //Assert
            Assert.AreEqual(expectedArmor, playerArmor);
        }
    }
}
