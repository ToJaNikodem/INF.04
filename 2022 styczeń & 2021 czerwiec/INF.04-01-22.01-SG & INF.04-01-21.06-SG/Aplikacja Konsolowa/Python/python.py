class arraySorter:
    def __init__(self):
        self.numbers = []

    def arrayInputer(self):
        print("Podaj tablicę\n")
        for i in range(10):
            print("Wprowadź element ", i+1, ": ", end="", sep="")
            self.numbers.append(int(input()))

    # tactic = 0 - metoda zwraca największy element, tactic = 1 - metoda zwraca indeks największego elementu
    def sortArrayAndFindMax(self, tactic):
        self.__sortArray()
        return self.__findMax(tactic)

    def printArray(self):
        print("Tablica:", self.numbers)

    # tactic = 0 - metoda zwraca największy element, tactic = 1 - metoda zwraca indeks największego elementu
    def __findMax(self, tactic):
        max = self.numbers[0]
        maxIndex = 0

        for i in range(10):
            if (self.numbers[i] > max):
                max = self.numbers[i]
                maxIndex = i

        if (tactic == 0):
            return max
        elif (tactic == 1):
            return maxIndex

    def __sortArray(self):
        for i in range(10):
            index = i
            for j in range(i + 1, 10):
                if (self.numbers[j] > self.numbers[index]):
                    index = j
            self.numbers[index], self.numbers[i] = self.numbers[i], self.numbers[index]


newArraySorter = arraySorter()

tactic = 0

newArraySorter.arrayInputer()

max = newArraySorter.sortArrayAndFindMax(tactic)

if (tactic == 0):
    print("Największa wartość w tablicy to:", max)
elif (tactic == 1):
    print("Index największego elementu w tablicy to:", max)

newArraySorter.printArray()
