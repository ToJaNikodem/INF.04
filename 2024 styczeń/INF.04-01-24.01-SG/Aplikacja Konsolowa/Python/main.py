def sexFinder(PESEL):
    sexNumberPosition = int(PESEL[9])
    if sexNumberPosition % 2 == 0:
        return "k"
    else:
        return "m"


def controlSum(PESEL):
    sum = 0
    j = 1
    for i in range(10):
        if j == 1:
            sum += int(PESEL[i]) * 1
        elif j == 2:
            sum += int(PESEL[i]) * 3
        elif j == 3:
            sum += int(PESEL[i]) * 7
        elif j == 4:
            sum += int(PESEL[i]) * 9
            j = 0
        j = j + 1

    m = sum % 10
    r = 0
    if m != 0:
        r = 10 - m
    print(sum)
    print(r)
    print(m)
    if r == int(PESEL[10]):
        return True
    else:
        return False
    
pesel = input("Podaj pesel: ")
peselArray = []

sex = sexFinder(pesel)
print("Płeć: ", sex)

sum = controlSum(pesel)
print("Suma kontrolna: ", sum)