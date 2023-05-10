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
        public static DifficultyEnum chosenDifficulty;
        public static Image chosenImage;
        public ChooseLevelAndDifficultyForm chooseLevelAndDifficultyForm;
        public Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            activeForm = this;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            chooseLevelAndDifficultyForm = GameSetup.StartGame(mainPanel, chooseLevelAndDifficultyForm);
            activeForm = chooseLevelAndDifficultyForm;
            this.Text = chooseLevelAndDifficultyForm.Text;
            exitButton.BringToFront();
            if (this.Size.Width < 870 || this.Size.Height < 300)
            {
                this.Size = new Size(870, 300);
            }
            this.MinimumSize = new Size(870, 300);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (activeForm == this)
            {
                this.Close();
            }
            activeForm.Close();
            mainPanel.Dock = DockStyle.None;
            activeForm = this;
        }

        private void mainPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (activeForm == this)
            {
                mainPanel.Hide();
                this.Text = "Main menu";
            }
        }
    }
}
