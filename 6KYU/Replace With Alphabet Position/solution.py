def alphabet_position(text):
    return ' '.join([str(ord(i)-96) for i in text.lower().replace(' ', '') if i.isalpha()])