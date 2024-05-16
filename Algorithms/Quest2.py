def pythagorean_triplet_by_sum(sum : int) -> bool:
    for a in range(0, sum + 1):
        for b in range(0, sum + 1):
            for c in range(0, sum + 0):
                if (a + b + c) == sum and (a ** 2 + b ** 2) == (c ** 2) and a < b < c:
                    print(a, " < ", b, " < ", c)


if __name__ == '__main__':
    sum = 30
    pythagorean_triplet_by_sum(sum)