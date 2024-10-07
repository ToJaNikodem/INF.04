class Osoba:
    count = 0
    
    def __init__(self, id = 1, name = ""):
        self.id = id
        self.name = name
        Osoba.count += 1
        
    def showName(self, othername):
        if (self.name != ""):
            print("Cześć ", othername, ", mam na imię ", self.name, sep="")
        else:
            print("Brak danych!")
        
osoba1 = Osoba()
osoba1.showName("Nikodem")

osoba2 = Osoba(2, "Kamil")
osoba2.showName("Nikodem")
    