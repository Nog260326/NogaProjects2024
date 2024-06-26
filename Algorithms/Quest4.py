import matplotlib.pyplot as plt
import numpy as np
from scipy.stats import pearsonr


def numbers() -> None:
    number = 0
    sum = 0
    counter = 0
    sorted_list = []
    list = []
    send_to_pearson = []
    while(not number == -1):
        print("enter a number")
        number = int(input())
        if not number == -1:
            list.append(number)
    for i in list:
        send_to_pearson.append(i)
    for i in list:
        sum += i
    avg = sum / len(list)
    print("the average of the numbers is: ", avg)
    for i in list:
        if i > 0:
            counter += 1
    print("the amount of positives numbers is: ", counter)
    while(not len(list) == 0):
        min_number = list[0]
        min_number_index = 0
        for i in range(len(list)):
            if min_number > list[i]:
                min_number = list[i]
                min_number_index = i
        sorted_list.append(list[min_number_index])
        del list[min_number_index]
    print(sorted_list)
    row_array = []
    col_array = []
    for i in range(len(sorted_list)):
        row_array.append(i)
        col_array.append(sorted_list[i])
    xpoints = np.array(row_array)
    ypoints = np.array(col_array)
    plt.plot(xpoints, ypoints, 'o')
    plt.show()
    print(pearson_correlation(send_to_pearson))


def pearson_correlation(numbers_list: []):
    numbers_index = []
    for i in range(1, len(numbers_list) + 1):
        numbers_index.append(i)
    pearson, _ = pearsonr(numbers_index, numbers_list)
    return pearson


if __name__ == '__main__':
    numbers()
