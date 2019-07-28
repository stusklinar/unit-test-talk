using NUnit.Framework;
using Valiation.Email;

namespace Tests
{
    public class EmailValidatorTest
    {
        private EmailValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new EmailValidator();
        }

        [Test]
        public void VaidateEmail()
        {
            _validator.Validate("");
            Assert.Fail();
        }
    }
}