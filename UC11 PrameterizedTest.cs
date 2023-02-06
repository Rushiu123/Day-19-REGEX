using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Regex
{
    public class UC11_PrameterizedTest
    {
        //Happy Test Cases(Test Cases Pass The Entries)
        [TestMethod]
        [DataRow("Rushi")]
        [DataRow("Vishwanath")]
        [DataRow("Ubalkar")]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue(string firstName)
        {
            //Arrange
            RegistrationValidate registrationValidate = new RegistrationValidate();
            //Act
            bool result = registrationValidate.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("Sonu")]
        [DataRow("Vishwanath")]
        [DataRow("Ubalkar")]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue(string lastName)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("rushikesh.ubalkar@gmail.com")]
        [DataRow("rushi.ubalkar@gmail.com")]
        [DataRow("rushi123@gmail.com")]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue(string email)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("918605598390")]
        [DataRow("919860691396")]
        [DataRow("918999319108")]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue(string mobNumber)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateMobileNumber(mobNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("Rushi@123")]
        [DataRow("Pass@123")]
        [DataRow("Password@123")]
        public void GivenPassword_WhenValidate_ShouldReturnTrue(string password)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //(Test Cases Fail The Entry)
        [TestMethod]
        [DataRow("ru")]
        [DataRow("$onu)]
        [DataRow("@Sonu")]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse(string firstName)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("Rk")]
        [DataRow("$onu")]
        [DataRow("anjhan@")]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse(string lastName)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("Rk@gm")]
        [DataRow("Rushi@.com")]
        [DataRow("son@gmail")]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse(string email)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("8605598390")]
        [DataRow("54321 12345")]
        [DataRow("8999319108")]

        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse(string mobNumber)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateMobileNumber(mobNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("rushik123")]
        [DataRow("Pa12")]
        [DataRow("asswr")]
        public void GivenPassword_WhenValidate_ShouldReturnFalse(string password)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);

        }
    }
}
