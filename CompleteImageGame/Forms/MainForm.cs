using CompleteImageGame;
using CompleteImageGameApp.AppLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteImageGameApp.Forms
{
    public partial class MainForm : Form
    {
        public DifficultyEnum _chosenDifficulty;
        public Bitmap _chosenImage;
        public ChooseDifficultyForm _difficultyForm;
        public ChooseLevelForm _levelForm;
        public MainForm()
        {
            InitializeComponent();
            mainPanel.Hide();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _difficultyForm = GameSetup.StartGame(mainPanel, _difficultyForm);
            this.Text = _difficultyForm.Text;
            exitButton.Hide();
            mainPanel.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            mainPanel.Hide();
            exitButton.Show();
            this.Text = "Main menu";
        }
    }
}
