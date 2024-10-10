"""
    nazwa klasy: Film
    pola: title - przechowuje tytuł filmu
    loanCount - ilość wypożyczonych filmów
    metody: titleSetter, brak zwracanej wartości – ustawia tytuł filmu na podany
            titleGetter, zwraca nazwę filmu - zwraca nazwę filmu
            loanCountGetter, zwraca ilość wypożyczonych filmów - zwraca ilość wypożyczonych filmów
            loanCountIncrementer, brak zwracanej wartości - inkrementuje ilośc wypożyczonych filmów 
    informacje: klasa opisująca film
    autor: 00000000000
"""
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