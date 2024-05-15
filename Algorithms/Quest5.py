import math


def reverse_n_pi_digits(number) -> int:
    reversed_pi = 0
    pi = math.pi
    for i in range(number-1):
        pi = pi * 10
    pi = int(pi)
    pi_len = int(math.log(pi, 10) + 1)
    index = 1
    for i in range(pi_len - 1):
        index = index * 10
    for i in range(pi_len):
        reversed_pi += (pi % 10) * index
        pi = int(pi / 10)
        index = index / 10
    return int(reversed_pi)


if __name__ == '__main__':
    print("enter the amount of the reversed pi numbers you want to see: ")
    number = int(input())
    print(reverse_n_pi_digits(number))