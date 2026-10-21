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
            Medium UserNewAlbum = new Medium(user_choice_title, user_choice_artist, user_choice_mediumtype);
            collection.Add(UserNewAlbum);
            update_datasource_datagrid();
            clear_uilable();

        }

        private void check_userchoice(string user_choice_title, string user_choice_artist, string user_choice_mediumtype)
        {
            
            Logic logic = new Logic();

            bool get_bool_ta = logic.userinput_bool(user_choice_title, user_choice_artist);
            
            if (get_bool_ta == true)
            {

            }

            

        }

        private void update_datasource_datagrid()
        {
            DataGridCvUi.DataSource = null;
            DataGridCvUi.DataSource = collection;
        }

        private void clear_uilable()
        {
            txtInputTitle.Clear();
            txtInputArtist.Clear();
            txtInputType.Clear();
        }
    }
}
