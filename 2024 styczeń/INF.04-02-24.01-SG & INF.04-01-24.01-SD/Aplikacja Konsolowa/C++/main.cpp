#include <iostream>
#include <algorithm>

using namespace std;

class StringTools
{
public:
    static int vowelCounter(string text)
    {
        const string vowels = "aąeęiouóyAĄEĘIOUÓY";

        int vowelCount = 0;

        for (char ch : text)
        {
            if (vowels.find(ch) != string::npos)
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }

    static string repetitionDeleter(string text)
    {
        string result;

        for (int i = 0; i < text.size(); i++)
        {
            if (i == 0 || text[i] != text[i - 1])
            {
                result += text[i];
            }
        }

        return result;
    }
};

int main()
{
    string text;

    cout << "Podaj napis: ";
    getline(cin, text);


    StringTools newStringTools;

    int vowelCount = newStringTools.vowelCounter(text);
    string newText = newStringTools.repetitionDeleter(text);

    cout << "Liczba samogłosek: " << vowelCount << endl;
    cout << "Napis po usunięciu powtórzeń: " << newText << endl;

    return 0;
}