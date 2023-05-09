using CompleteImageGameApp.AppLogic;

namespace CompleteImageGame
{
    public partial class mainMenuForm : Form
    {
        public RadioButton _chosenDifficulty;
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            _chosenDifficulty = GameSetup.SearchForCheckedRadioButton(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}