using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void Reverse_ReverseInput_ReturnString()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual("olleh", testPalindrome.Reverse("hello"));
    }
    [TestMethod]
    public void IsPalindrome_IsInputNotAPalindrome_False()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(false, testPalindrome.IsPalindrome("hello"));
    }
    [TestMethod]
    public void IsPalindrome_IsInputPalindrome_True()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(true, testPalindrome.IsPalindrome("hello olleh"));
    }
  }
}