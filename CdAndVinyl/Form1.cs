namespace CdAndVinyl
{
    public partial class Form1 : Form
    {
        
        private List<Medium> collection = new List<Medium>();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInputType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInputTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInputArtist_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            string user_choice_title = txtInputTitle.Text;
            string user_choice_artist = txtInputArtist.Text;
            string user_choice_mediumtype = txtInputType.Text;
            Medium UserNewAlbum = new Medium();
            UserNewAlbum.Title = user_choice_title;
            UserNewAlbum.Artist = user_choice_artist;
            UserNewAlbum.Type = user_choice_mediumtype;
            collection.Add(UserNewAlbum);
            DataGridCvUi.DataSource = null;
            DataGridCvUi.DataSource = collection;

        }
    }
}
