using Xunit;
using PalindromeApp;

namespace PalindromeApp.Tests
{
    public class PalindromeTests
    {
        [Fact(DisplayName = "PAL-TC-11: Empty string is palindrome")]
        public void Empty_String_Is_Palindrome()
        {
            var result = PalindromeChecker.IsPalindrome("");
            Assert.True(result);
        }

        [Fact(DisplayName = "PAL-TC-12: Single character palindrome")]
        public void Single_Character_Is_Palindrome()
        {
            var result = PalindromeChecker.IsPalindrome("a");
            Assert.True(result);
        }

        [Fact(DisplayName = "PAL-TC-13: Two different characters")]
        public void Two_Different_Characters_Not_Palindrome()
        {
            var result = PalindromeChecker.IsPalindrome("ab");
            Assert.False(result);
        }
    }
}
