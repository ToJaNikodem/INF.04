def findGCM(a, b):
    while a != b:
        if a > b:
            a = a - b
        else:
            b = b - a
    return a

a = int(input("Wprowadz pierwszą liczbę: "))
b = int(input("Wprowadz drugą liczbę: "))

if not a % 1 == 0 and b % 1 == 0 and a > 0 and b > 0:
    print("Niepoprawne liczby!")
    
print("Największy wspóly dzielnik: ", findGCM(a, b))