import random

def addNumbers(numbers):
    for i in range(50):
        numbers[i] = random.randrange(1, 100)

def lookFor(number, numbers):
    i = 0
    while numbers[i] != 0:
        if numbers[i] == int(number):
            return i + 1
        i += 1

    return 100

n = 50
numbers = {}

numbers[n] = 0

addNumbers(numbers)

number = input("Podaj szukaną liczbę: ")

result = lookFor(number, numbers)

if result == 100:
    print("Liczba nieznaleziona!")
else:
    print("Liczba znaleziona na pozycji: ", result)

print("Tablica: ")

for i in range(50):
    print(numbers[i], ", ", sep="", end="")