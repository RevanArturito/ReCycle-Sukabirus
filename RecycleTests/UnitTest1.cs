using KPL_Recycle;
using System.Runtime;
using static KPL_Recycle.Profile;

namespace RecycleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testProfileUpdate()
        {
            // Arrange
            ProfileConfig profileConfig = new ProfileConfig();

            string Username = "Rivabaru";
            string Email = "rivaNew@example.com";
            long PhoneNumber = 1234567890123;

            // Act
            profileConfig.UpdateProfile(Username, Email, PhoneNumber);

            // Assert
            Assert.AreEqual(Username, profileConfig.configuration.username);
            Assert.AreEqual(Email, profileConfig.configuration.email);
            Assert.AreEqual(PhoneNumber, profileConfig.configuration.phoneNumber);
        }
    }
}
