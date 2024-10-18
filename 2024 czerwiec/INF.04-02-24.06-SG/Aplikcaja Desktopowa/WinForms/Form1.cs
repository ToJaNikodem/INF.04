namespace WinForms
{
    public partial class Form1 : Form
    {
        private List<Album> albums = new List<Album>();
        private int currentAlbum = 0;

        public Form1()
        {
            InitializeComponent();

            readData();
            displayAlbum();
        }

        private void displayAlbum()
        {
            artistName.Text = albums[currentAlbum].Artist;
            albumName.Text = albums[currentAlbum].AlbumName;
            songsNumber.Text = albums[currentAlbum].SongsNumber.ToString() + " utworów";
            yearOfRelease.Text = albums[currentAlbum].Year.ToString();
            downloadNumber.Text = albums[currentAlbum].DownloadNumber.ToString();
        }

        private void readData()
        {
            string data = Properties.Resources.Data;
            string[] lines = data.Split('\n');

            for (int i = 0; i < lines.Length; i += 6)
            {
                string artist = lines[i].Trim();
                string albumName = lines[i + 1].Trim();
                int songsNumber = int.Parse(lines[i + 2]);
                int year = int.Parse(lines[i + 3]);
                int downloadNumber = int.Parse(lines[i + 4]);

                albums.Add(new Album(artist, albumName, songsNumber, year, downloadNumber));


            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (currentAlbum > 0)
                currentAlbum--;
            else currentAlbum = albums.Count - 1;
            displayAlbum();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentAlbum < albums.Count - 1)
                currentAlbum++;
            else currentAlbum = 0;
            displayAlbum();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            albums[currentAlbum].DownloadNumber++;
            downloadNumber.Text = albums[currentAlbum].DownloadNumber.ToString();
        }
    }

    public class Album
    {
        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public int SongsNumber { get; set; }
        public int Year { get; set; }
        public int DownloadNumber { get; set; }

        public Album(string artist, string albumName, int songsNumber, int year, int downloadNumber)
        {
            Artist = artist;
            AlbumName = albumName;
            SongsNumber = songsNumber;
            Year = year;
            DownloadNumber = downloadNumber;
        }

    }
}
