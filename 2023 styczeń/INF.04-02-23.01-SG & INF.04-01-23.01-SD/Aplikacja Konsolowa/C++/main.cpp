#include <iostream>

using namespace std;

class Note
{
private:
    static int count;
    int identifier;

protected:
    string title, text;

public:
    Note(string newNoteTitle, string newNoteText)
    {
        title = newNoteTitle;
        text = newNoteText;
        count++;
        identifier = count;
    }
    void displayNote()
    {
        cout << "Tytuł: " << title << endl;
        cout << "Treść notatki: " << text << endl;
    }
    void debug()
    {
        cout << "Licznik: " << count << "; Identifikator: " << identifier << "; Tytuł: ";
        cout << title << "; Treść: " << text << "; " << endl;
    }
};

int Note::count = 0;

int main()
{
    string newNoteTitle;
    string newNoteText;

    cout << "Podaj tytuł notatki: ";
    cin >> newNoteTitle;

    cout << "Podaj treść notatki: ";
    cin >> newNoteText;

    Note note1(newNoteText, newNoteTitle);

    note1.displayNote();
    note1.debug();

    cout << "\nPodaj tytuł notatki: ";
    cin >> newNoteTitle;

    cout << "Podaj treść notatki: ";
    cin >> newNoteText;

    Note note2(newNoteText, newNoteTitle);

    note2.displayNote();
    note2.debug();
}