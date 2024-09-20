class arraySorter:
    def __init__(self):
        self.numbers = []

    def inputer(self):
        print("Podaj tablicę\n")
        for i in range(10):
            print("Wprowadź element", i+1, ": ")
            self.numbers.append(input())

    # tactic = 0 - metoda zwraca największy element, tactic = 1 - metoda zwraca indeks największego elementu
    def sortAndFindMax(self, tactic):
        self.__sort()
        return self.__findMax(tactic)
        
    def display(self):
        print("Tablica:", self.numbers)
        
    def __findMax(self, tactic):
        max = self.numbers[0]
        maxIndex = 0
        
        for i in range(10):
            if (self.numbers[i] > max):
                max = self.numbers[i]
                maxIndex = i
        
        if (tactic == 0):
            return max
        elif(tactic == 1):
            return maxIndex
        
    def __sort(self):
        for i in range(len(self.numbers) - 1):
            index = i
            for j in range(i + 1, len(self.numbers)):
                if (self.numbers[j] < self.numbers[index]):
                    index = j
            
            self.numbers[index], self.numbers[i] = self.numbers[i], self.numbers[index]

newArraySorter = arraySorter()

tactic = 0

newArraySorter.inputer()

max = newArraySorter.sortAndFindMax(tactic)

if (tactic == 0):
    print("Największa wartość w tablicy to:", max)
elif (tactic == 1):
    print("Index największego elementu w tablicy to:", max)

newArraySorter.display()
