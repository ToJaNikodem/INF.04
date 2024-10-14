import random

def sorter(numbers):
    for i in range(99):
        for j in range(99 - i):
            if numbers[j] > numbers[j + 1]:
                numbers[j], numbers[j + 1] = numbers[j + 1], numbers[j]

numbers = {}

print("Tablica przed sortowaniem: ")

for i in range(100):
    numbers[i] = random.randrange(1, 1000)
    print(numbers[i], ", ", end="", sep="")
    
sorter(numbers)

print("\nPosortowana tablica: ")

for i in range(100):
    print(numbers[i], ", ", end="", sep="")