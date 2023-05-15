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
using System.Media;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic;

namespace CompleteImageGameApp.Forms
{
    public partial class MainForm : Form
    {
        public static DifficultyEnum chosenDifficulty;
        public static Image chosenImage;
        public ChooseLevelAndDifficultyForm chooseLevelAndDifficultyForm;
        public Form activeForm;
        public SoundPlayer player = new SoundPlayer(@"C:\Users\Пакет\Downloads\bgMusic_track1_new.wav");
        public MainForm()
        {
            InitializeComponent();
            activeForm = this;
            player.Play();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            chooseLevelAndDifficultyForm = GameSetup.LoadLevelSelectionForm(mainPanel, chooseLevelAndDifficultyForm);
            activeForm = chooseLevelAndDifficultyForm;
            this.MinimumSize = new Size(880, 400);
            exitButton.BringToFront();
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
            if(!mainPanel.Contains(activeForm))
                this.Text = "Main menu";
            exitButton.BringToFront();

        }

        private void mainPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is Form)
                activeForm = (Form)e.Control;
            this.Text = e.Control.Text;
        }
    }
}
