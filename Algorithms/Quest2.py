def pythagorean_triplet_by_sum(sum) -> []:
    pythagoreans = []
    numbers = []
    if sum <= 5:
        return 0
    j = 2
    k = 3
    for i in range(sum-3):
        if i >sum-3:
            return pythagoreans
        j = i + 1
        k = j + 1
        for a in range(sum-4):
            j += 1
            k = j+1
            for b in range(sum-5):
                k += 1
                if i + j + k == sum:
                    numbers.append(i)
                    numbers.append(j)
                    numbers.append(k)
                    pythagoreans.append(numbers)
                numbers = []
    return pythagoreans


if __name__ == '__main__':
    print(pythagorean_triplet_by_sum(8))