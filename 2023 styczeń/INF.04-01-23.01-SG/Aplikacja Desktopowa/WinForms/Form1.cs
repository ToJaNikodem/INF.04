using System.Text;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Digits = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()_+-=";

        private string password = "";

        private void generatePasswordBtn_Click(object sender, EventArgs e)
        {
            generatePassword(int.Parse(passwordLength.Text), capitalLetters.Checked, specialCharacters.Checked, digits.Checked);
            MessageBox.Show(password);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dane pracownika: " + name.Text + " " + surname.Text + " " + position.Text + " Has³o: " + password);
        }

        private void generatePassword(int length, bool includeCapital, bool includeSpecialCharacters, bool includeDigits)
        {
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                if (i == 0 && includeCapital)
                {
                    password += CapitalLetters[random.Next(CapitalLetters.Length)];
                    continue;
                }
                if (i == 1 && includeSpecialCharacters)
                {
                    password += SpecialCharacters[random.Next(SpecialCharacters.Length)];
                    continue;
                }
                if (i == 2 && includeDigits)
                {
                    password += Digits[random.Next(Digits.Length)];
                    continue;
                }
                password += SmallLetters[random.Next(SmallLetters.Length)];
            }
        }
    }
}
