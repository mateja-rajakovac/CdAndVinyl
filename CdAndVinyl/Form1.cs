namespace CdAndVinyl
{
    public partial class Form1 : Form
    {
        
        private List<Medium> collection = new List<Medium>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            Logic Logic = new Logic();
            string user_choice_title = txtInputTitle.Text;
            string user_choice_artist = txtInputArtist.Text;
            string user_choice_mediumtype = txtInputType.Text;
            
            if (Logic.check_space(user_choice_mediumtype, user_choice_artist, user_choice_title) == true)
            {
                update_ui_invalid();
            }

            if (Logic.check_mediumtype(user_choice_mediumtype) == false)
            {
                update_ui_false_type();
            }


            if (Logic.check_space(user_choice_mediumtype, user_choice_artist, user_choice_title) == false && Logic.check_mediumtype(user_choice_mediumtype) == true)
            {
                Medium UserNewAlbum = new Medium(user_choice_title, user_choice_artist, user_choice_mediumtype);
                collection.Add(UserNewAlbum);
                update_datasource_datagrid();
                clear_uilable();
            }

        }

        private async void update_ui_invalid()
        {
            txtNotice.Text = "invalid input";
            await Task.Delay(1450);
            txtNotice.Text = "";
        }

        private async void update_ui_false_type()
        {
            txtNotice.Text = "invalid medium type";
            await Task.Delay(1450);
            txtNotice.Text = "";
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
