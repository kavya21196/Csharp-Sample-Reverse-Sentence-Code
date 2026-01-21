def is_palindrome(value: str) -> bool:
    cleaned = value.lower()
    return cleaned == cleaned[::-1]


def test_empty_string_palindrome():
    """
    PAL-TC-11: Empty string is considered a palindrome
    """
    assert is_palindrome("") is True


def test_single_character_palindrome():
    """
    PAL-TC-12: Single character palindrome
    """
    assert is_palindrome("a") is True


def test_two_different_characters():
    """
    PAL-TC-13: Two different characters
    """
    assert is_palindrome("ab") is False
