using NUnit.Framework;

using GDCConsoleApp.Services;

namespace GDCConsoleApp.Tests
{
    public class EmailShouldValidate
    {
        EmailService sut;

        [SetUp]
        public void Setup()
        {
            sut = new EmailService();
        }

        [Test]
        [TestCase("hello@xyz.com")]
        [TestCase("hello.world@xyz.com")]
        [TestCase("mwd1@peoplepc.com")]
        public void ValidateEmail(string email)
        {   
            var validEmail = sut.ValidateEmail(email);

            Assert.That(validEmail, Is.True);
        }

        [Test]
        [TestCase("hello@xyz.com")]
        [TestCase("hello.world@xyz.com")]
        [TestCase("mwd1@peoplepc.com")]
        public void ValidateEmailRegex(string email)
        {
            var validEmail = RegexUtilities.IsValidEmail(email);

            Assert.That(validEmail, Is.True);
        }
    }
}
