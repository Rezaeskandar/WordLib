using WordLib;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordLibTests
{
    [TestClass]
    public class WorderTests
    {
        [TestMethod]
        public void IsPalindrome_ReturnsTrue_ForPalindromeWord()
        {
            // Arrange
            string word = "radar";

            // Act
            bool result = Worder.IsPalindrome(word);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
