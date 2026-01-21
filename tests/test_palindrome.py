def is_palindrome(value):
    return value == value[::-1]


def test_empty_string_is_palindrome():
    assert is_palindrome("") is True


def test_single_character_palindrome():
    assert is_palindrome("a") is True


def test_two_different_characters():
    assert is_palindrome("ab") is False
