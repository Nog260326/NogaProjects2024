def is_sorted_polyndrom(word) -> bool:
    stack = []
    stack2 = []
    for i in range(len(word)-2):
        if not word[i] == word[i+2]:
            stack.append(word[i])
    middle = i+1
    for i in range(int(len(word) / 2)-1):
        stack2.append(word[middle])
        middle += 1
    for i in range(len(stack)):
        if not stack[i] == stack2[i]:
            return False
    return True


if __name__ == '__main__':
    print(is_sorted_polyndrom("abcdcba"))

