class Film:
    def __init__(self):
        self._title = ""
        self._loanCount = 0
    
    def titleSetter(self, newTitle):
        self._title = newTitle
        
    def titleGetter(self):
        return self._title
    
    def loanCountGetter(self):
        return self._loanCount
    
    def loanCountIncrementer(self):
        self._loanCount += 1
        
film1  = Film()

print("Tytuł: ", film1.titleGetter())
print("Liczba wypożyczeń: ", film1.loanCountGetter())

film1.titleSetter("Harry Poter")
film1.loanCountIncrementer()

print("Tytuł: ", film1.titleGetter())
print("Liczba wypożyczeń: ", film1.loanCountGetter())