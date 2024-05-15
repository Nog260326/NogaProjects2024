import math


def num_len(number) -> int:
    return int(math.log(number, 10)+1)


if __name__ == '__main__':
    print(num_len(12345))



