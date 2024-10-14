"""
    klasa: StringTools
    opis: klasa representuje zestaw narzędzi do napisów
    metody: vowelCounter - zwraca ilość samogłosek w napisie
            repetitionDeleter - zwraca napis z usuniętymi powtórzeniami znaków obok siebie
    autor: 00000000000
"""
class StringTools:
    @staticmethod
    def vowelCounter(text):
        VOWELS = "aąeęiouóyAĄEĘIOUÓY"
        vowelCount = 0
    
        for ch in text:
            if ch in VOWELS:
                vowelCount += 1
        
        return vowelCount
    
    @staticmethod
    def repetitionDeleter(text):
        result = ""
        
        for i in range(len(text)):
            if i == 0 or text[i] != text[i - 1]:
                result += text[i]
                
        return result

text = input("Podaj napis: ")

vowelCount = StringTools.vowelCounter(text)
newText = StringTools.repetitionDeleter(text)

print("Liczba samogłosek: ", vowelCount)
print("Napis po usunięciu powtórzeń: ", newText)