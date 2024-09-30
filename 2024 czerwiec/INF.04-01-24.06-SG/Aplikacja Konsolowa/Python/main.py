import random

class DiceThrow:
    def __init__(self):
        self.randomNumbers = {}
    
    def displayRandomNumbers(self, numberOfDice):
        for i in range(numberOfDice):
            print("Kostka", i + 1, ":", self.randomNumbers[i])
    
    def generateRandomNumbers(self, numberOfDice):
        for i in range(numberOfDice):
            self.randomNumbers[i] = random.randint(1, 6)
            
    def calculatePoints(self, numberOfDice):
        points = 0
        isRepeating = False
        
        for i in range(numberOfDice):
            for j in range(numberOfDice):
                if self.randomNumbers[i] == self.randomNumbers[j] and i != j:
                    points += self.randomNumbers[j]
                    isRepeating = True
                    self.randomNumbers[j] = 0
            if isRepeating == True:
                points += self.randomNumbers[i]
                isRepeating = False
        
        return points
    
while True:
    numberOfDices = int(input("Ile kostek chcesz rzucić? (3-10)\n"))
    if numberOfDices >= 3 or numberOfDices <= 10:
        break

newDiceThrow = DiceThrow()

newDiceThrow.generateRandomNumbers(numberOfDices)
newDiceThrow.displayRandomNumbers(numberOfDices)
print("Liczba uzyskanych punktów:", newDiceThrow.calculatePoints(numberOfDices))
    
userInput = "t"

while userInput != "t" or userInput != "n":
    userInput = input("Jeszcze raz (t/n)\n")
    
    if userInput == "t":
        newDiceThrow.generateRandomNumbers(numberOfDices)
        newDiceThrow.displayRandomNumbers(numberOfDices)
        print("Liczba uzyskanych punktów:", newDiceThrow.calculatePoints(numberOfDices))
    else:
        exit()