class Album:
    def __init__(self, artist, album, songsNumber, year, downloadNumber):
        self.artist = artist
        self.album = album
        self.songsNumber = songsNumber
        self.year = year
        self.downloadNumber = downloadNumber
        
    """
        nazwa funkcji: display
        opis funkcji: wyświetla dane albumu
        parametry: brak
        zwracany typ i opis: brak
        autor: 00000000000
    """
    def display(self):
        print(self.artist, self.album, self.songsNumber, self.year, self.downloadNumber, sep="\n", end="\n\n")

def readAlbums():
    albums = []

    with open("Data.txt", "r", encoding="utf-8") as albumsFile:
        lineIndex = 0
        artist = ""
        album = ""
        songs_number = 0 
        year = 0
        download_number = 0
        
        for line in albumsFile:
            line = line.strip()

            lineIndex += 1

            if lineIndex == 1:
                artist = line
            elif lineIndex == 2:
                album = line
            elif lineIndex == 3:
                songs_number = int(line)
            elif lineIndex == 4:
                year = int(line)
            elif lineIndex == 5:
                download_number = int(line)
            elif lineIndex == 6:
                albums.append(Album(artist, album, songs_number, year, download_number))
                lineIndex = 0
    
    return albums

albums = readAlbums()

for album in albums:
    album.display()