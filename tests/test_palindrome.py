import unittest


def is_palindrome(value):
    return value == value[::-1]


class TestPalindrome(unittest.TestCase):

    def test_empty_string(self):
        self.assertTrue(is_palindrome(""))

    def test_single_character(self):
        self.assertFalse(is_palindrome("a"))

    def test_two_different_characters(self):
        self.assertFalse(is_palindrome("ab"))


if __name__ == "__main__":
    unittest.main()
