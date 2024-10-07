import math

def addNumbers(numbers):
    for i in range(2, 101):
        numbers.append(i)

n = 100
numbers = []
addNumbers(numbers)
        
for i in range(2, int(math.sqrt(n))):
    for j in range(99):
        if numbers[j] % i == 0:
            numbers[j] = False
            
print("Liczby pierwsze:")

for i in range(99):
    if numbers[i] != 0:
        print(numbers[i])