class Note:
    __COUNT = 0
    
    def __init__(self, newNoteTitle, newNoteText):
        self._title = newNoteTitle
        self._text = newNoteText
        
        Note.__COUNT += 1
        self.__identifier = Note.__COUNT
        
    def displayNote(self):
        print("Tytuł:", self._title, "\nTreść notatki:", self._text)
    
    def debug(self):
        print("Licznik:", self.__COUNT, "; Identifikator:", self.__identifier, "; Tytuł:", self._title, "; Treść:", self._text, ";")
        
newNoteTitle = input("Podaj tytuł notatki: ")
newNoteText = input("Podaj treść notatki: ")

newNote1 = Note(newNoteTitle, newNoteText)

newNote1.displayNote()
newNote1.debug()

newNoteTitle = input("Podaj tytuł notatki: ")
newNoteText = input("Podaj treść notatki: ")

newNote2 = Note(newNoteTitle, newNoteText)

newNote2.displayNote()
newNote2.debug()