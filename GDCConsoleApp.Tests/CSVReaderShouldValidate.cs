using NUnit.Framework;
using System.Linq;

using GDCConsoleApp.Models;

namespace GDCConsoleApp.Tests
{
	class CSVReaderShouldValidate
	{
        [Test]
        public void Players_OnRefresh_IsPopulated()
        {
            // Arrange
            var reader = new FakeReader();
            var viewModel = new PlayerViewModel(reader);

            // Act
            viewModel.RefreshPlayers();

            // Assert
            Assert.IsNotNull(viewModel.Players);
            Assert.AreEqual(2, viewModel.Players.Count());
        }

        [Test]
        public void Players_OnClear_IsEmpty()
        {
            // Arrange
            var reader = new FakeReader();
            var viewModel = new PlayerViewModel(reader);
            viewModel.RefreshPlayers();
            Assert.AreNotEqual(0, viewModel.Players.Count(), "Invalid arrange");

            // Act
            viewModel.ClearPlayers();

            // Assert
            Assert.AreEqual(0, viewModel.Players.Count());
        }
    }
}
