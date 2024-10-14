#include <iostream>
#include <fstream>
#include <vector>

using namespace std;

class Album
{
public:
    string artist;
    string album;
    int songsNumber;
    int year;
    int downloadNumber;

    Album(string artist, string album, int songsNumber, int year, int downloadNumber) : artist(artist), album(album), songsNumber(songsNumber), year(year), downloadNumber(downloadNumber)
    {
    }

    /*
        * nazwa funkcji: display
        * opis funkcji: wyświetla dane albumu
        * parametry: brak
        * zwracany typ i opis: brak
        * autor: 00000000000
    */
    void display() const
    {
        cout << artist << endl
             << album << endl
             << songsNumber << endl
             << year << endl
             << downloadNumber << "\n\n";
    }
};

vector<Album> readAlbums() {
    ifstream albumsFile("Data.txt");

    string artist, album;
    int songsNumber, year, downloadNumber;

    int lineIndex = 0;
    string line;

    vector<Album> albums;
    while (getline(albumsFile, line))
    {
        lineIndex++;
        switch (lineIndex)
        {
        case 1:
            artist = line;
            break;
        case 2:
            album = line;
            break;
        case 3:
            songsNumber = stoi(line);
            break;
        case 4:
            year = stoi(line);
            break;
        case 5:
            downloadNumber = stoi(line);
            break;
        case 6:
            albums.emplace_back(artist, album, songsNumber, year, downloadNumber);
            lineIndex = 0;
            break;
        
        default:
            break;
        }
    }
    albumsFile.close();

    return albums;
    
}

int main()
{
    vector<Album> albums = readAlbums();

    for (const Album& album : albums) {
        album.display();
    }

    return 0;
}