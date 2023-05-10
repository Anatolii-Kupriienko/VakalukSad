using CompleteImageGameApp.AppLogic;
using CompleteImageGameApp.Forms;

namespace CompleteImageGame
{
    public partial class ChooseDifficultyForm : Form
    {
        public DifficultyEnum _chosenDifficulty;
        public ChooseDifficultyForm()
        {
            InitializeComponent();
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            _chosenDifficulty = GameSetup.GetSelectedDifficulty(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}