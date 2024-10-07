class Osoba:
    count = 0
    
    def __init__(self, id = 1, name = ""):
        self.__id = id
        self.__name = name
        Osoba.count += 1
        
    def showName(self, othername):
        if (self.__name != ""):
            print("Cześć ", othername, ", mam na imię ", self.__name, sep="")
        else:
            print("Brak danych!")
        
osoba1 = Osoba()
osoba1.showName("Nikodem")

osoba2 = Osoba(2, "Kamil")
osoba2.showName("Nikodem")
    