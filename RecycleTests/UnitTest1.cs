using KPL_Recycle;
using System.Runtime;
using static KPL_Recycle.Profile;

namespace RecycleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UpdateProfile_ValidInput_ProfileUpdated()
        {
            // Arrange
            ProfileConfig profileConfig = new ProfileConfig();
            string newUsername = "NewUsername";
            string newEmail = "new@example.com";
            long newPhoneNumber = 1234567890123;

            // Act
            profileConfig.UpdateProfile(newUsername, newEmail, newPhoneNumber);

            // Assert
            Assert.AreEqual(newUsername, profileConfig.configuration.username);
            Assert.AreEqual(newEmail, profileConfig.configuration.email);
            Assert.AreEqual(newPhoneNumber, profileConfig.configuration.phoneNumber);
        }
    }
}