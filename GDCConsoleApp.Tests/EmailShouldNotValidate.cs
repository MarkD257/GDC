using NUnit.Framework;

using GDCConsoleApp.Services;

namespace GDCConsoleApp.Tests
{
    public class EmailShouldNotValidate
    {
        EmailService sut;

        [SetUp]
        public void Setup()
        {
            sut = new EmailService();
        }

        [Test]
        [TestCase("hello@xyzom")]
        [TestCase("hello.world@xyz")]
        [TestCase("mwd1peoplepc.com")]
        public void ValidateEmailIsInvalid(string email)
        {
            var validEmail = sut.ValidateEmail(email);

            Assert.That(validEmail, Is.False);
        }

        [Test]
        [TestCase("hello@xyzom")]
        [TestCase("hello.world@xyz")]
        [TestCase("mwd1peoplepc.com")]
        public void ValidateEmailRegexIsInvalid(string email)
        {
            var validEmail = RegexUtilities.IsValidEmail(email);

            Assert.That(validEmail, Is.False);
        }
    }
}
