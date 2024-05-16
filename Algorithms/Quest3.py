def is_sorted_polyndrom(word) -> bool:
    word_chars = []
    for i in range(len(word)):
        word_chars.append(word[i])
    first_part = []
    last_part = []
    middle = ""
    is_sorted = 0
    is_short_sorted = 0
    beginning_len = len(word_chars)
    while not len(word_chars) < beginning_len / 2 + 1:
        if not word_chars[0] == word_chars[2] and middle == "":
            if word_chars[0] < word_chars[1]:
                is_sorted += 1
            first_part.append(word_chars[0])
            del word_chars[0]
        elif middle == "":
            if word_chars[0] < word_chars[1]:
                is_sorted += 1
            first_part.append(word_chars[0])
            middle = word_chars[1]
            del word_chars[0]
            del word_chars[0]
    while not len(word_chars) == 0 and not middle == "":
        last_part.append(word_chars[len(word_chars) - 1])
        del word_chars[len(word_chars) - 1]
    if not len(last_part) == len(first_part):
        return False
    is_polyndrom = 0
    for i in range(len(first_part)):
        if first_part[i] == last_part[i]:
            is_polyndrom += 1
    if is_sorted == 1 and len(word) == 3:
        is_short_sorted = 1
        is_sorted = 1
    if is_polyndrom == len(first_part) and is_sorted == int(len(word) / 2):
        if is_sorted == 0 and is_short_sorted == 1:
            return True
        if is_sorted > 0:
            return True
    return False


if __name__ == '__main__':
    word = "abcdcba"
    print(is_sorted_polyndrom(word))

