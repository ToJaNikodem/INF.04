namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            if (postcard.Checked)
            {
                price.Text = "Cena: 1 z³";
                pictureBox.Image = Properties.Resources.pocztowka;
            }
            if (letter.Checked)
            {
                price.Text = "Cena: 1,5 z³";
                pictureBox.Image = Properties.Resources.list;
            }
            if (parcel.Checked)
            {
                price.Text = "Cena: 10 z³";
                pictureBox.Image = Properties.Resources.paczka;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (postcode.Text.Length != 5)
            {
                MessageBox.Show("Nieprawid³owa liczba cyfr w kodzie pocztowym");
                return;
            }

            foreach (char c in postcode.Text)
            {
                if (char.IsDigit(c))
                    continue;
                MessageBox.Show("Kod pocztowy powinien siê sk³adaæ z samych cyfr");
                return;
            }
            MessageBox.Show("Dane przesy³ki zosta³y wprowadzone");
        }
    }
}
