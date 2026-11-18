using System.Text.Json;

namespace CdAndVinyl
{
    public partial class Form1 : Form
    {
        Logic Logic = new Logic();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btInput_Click(object sender, EventArgs e)
        {
            string user_choice_title = txtInputTitle.Text;
            string user_choice_artist = txtInputArtist.Text;
            string user_choice_mediumtype = txtInputType.Text;
            
            if (Logic.check_space(user_choice_mediumtype, user_choice_artist, user_choice_title) == true)
            {
                update_ui_invalid();
                clear_uilable();
            }

            if (Logic.check_mediumtype(user_choice_mediumtype) == false)
            {
                update_ui_false_type();
                clear_uilable();
            }


            if (Logic.check_space(user_choice_mediumtype, user_choice_artist, user_choice_title) == false && Logic.check_mediumtype(user_choice_mediumtype) == true)
            {
                Medium UserNewAlbum = new Medium(user_choice_title, user_choice_artist, user_choice_mediumtype);
                Logic.new_medium(UserNewAlbum);
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
            DataGridCvUi.DataSource = Logic.collection;
        }

        private void clear_uilable()
        {
            txtInputTitle.Clear();
            txtInputArtist.Clear();
            txtInputType.Clear();
        }
    }
}
