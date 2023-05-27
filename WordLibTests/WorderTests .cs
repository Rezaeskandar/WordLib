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
            Assert.IsTrue(result, $"{word} should be a palindrome.");
        }

        [TestMethod]
        public void CountLetters_ReturnsCorrectCount_ForWordWithLetters()
        {
            // Arrange
            string word = "Hello";

            // Act
            int count = Worder.CountLetters(word);

            // Assert
            Assert.AreEqual(5, count, $"The word '{word}' should have 5 letters.");
        }

        [TestMethod]
        public void CountLetters_ReturnsZero_ForWordWithoutLetters()
        {
            // Arrange
            string word = "12345";

            // Act
            int count = Worder.CountLetters(word);

            // Assert
            Assert.AreEqual(0, count, $"The word '{word}' should have 0 letters.");
        }
    }
}

