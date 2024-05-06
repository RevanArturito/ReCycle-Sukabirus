using Library;

namespace TestingLogReg
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            CheckingFunc checkingFunc = new CheckingFunc();

            // Arrange
            string username  = "a" ;
            string password  = "a" ;
            bool expected = true;

            // Act
            bool check = checkingFunc.LoginCheck(username, password); // login as admin expected

            // Assert
            Assert.AreEqual(expected, check);

        }

        [TestMethod]
        public void TestAdmin()
        {
            CheckingFunc checkingFunc = new CheckingFunc();

            // Arrange
            string username = "a";
            string password = "a";
            bool expected = true;

            // Act
            bool check = checkingFunc.AdminCheck(username, password); // login as admin expected

            // Assert
            Assert.AreEqual(expected, check);
        }


        [TestMethod]
        public void TestUser()
        {
            CheckingFunc checkingFunc = new CheckingFunc();

            // Arrange
            string username = "b";
            string password = "b";
            bool expected = false;

            // Act
            bool check = checkingFunc.AdminCheck(username, password); // login as user expected

            // Assert
            Assert.AreEqual(expected, check);
        }

        [TestMethod]    
        public void TestRegister()
        {
            CheckingFunc checkingFunc = new CheckingFunc();

            // Arrange
            string username = "a";
            string password = "a";
            bool expected = true;

            // Act
            bool check = checkingFunc.isAccount(username, password); // Account is exist expected

            // Assert
            Assert.AreEqual(expected,check);
        }
    }
}