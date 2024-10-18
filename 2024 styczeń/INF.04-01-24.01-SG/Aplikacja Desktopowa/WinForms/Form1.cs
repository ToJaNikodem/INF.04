namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(surnameBox.Text) || string.IsNullOrEmpty(number.Text))
            {
                MessageBox.Show("Wprowadü dane");
                return;
            }
            string eyeColor = "";
            if (blueEyes.Checked)
                eyeColor = blueEyes.Text;
            else if (greenEyes.Checked)
                eyeColor = greenEyes.Text;
            else
                eyeColor = hazelEyes.Text;

            MessageBox.Show(nameBox.Text + " " + surnameBox.Text + " kolor oczu " + eyeColor);
        }

        private void numberBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numberBox.Text))
                return;

            Image person = (Image)Properties.Resources.ResourceManager.GetObject($"{numberBox.Text}-zdjecie");
            personImage.Image = person;
            
            Image fingerprint = (Image)Properties.Resources.ResourceManager.GetObject($"{numberBox.Text}-odcisk");
            fingerprintImage.Image = fingerprint;
        }
    }
}
