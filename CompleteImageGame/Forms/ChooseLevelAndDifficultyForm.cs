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
using System.Windows.Forms.VisualStyles;

namespace CompleteImageGameApp.Forms
{
    public partial class ChooseLevelAndDifficultyForm : Form
    {
        public PictureBox lastSelected;
        public ChooseLevelAndDifficultyForm()
        {
            InitializeComponent();
            lastSelected = firstLevelPB;
            GameSetup.ActivatePbButton(lastSelected);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            MainForm.chosenDifficulty = GameSetup.GetSelectedDifficulty(this);
            if (lastSelected.Tag == "Random")
            {
                Random random = new();
                lastSelected.Image = LevelsImages.Images[random.Next(5)];
            }
            MainForm.chosenImage = lastSelected.Image;
            GameSetup.LoadGameForm(this);
            this.Parent.Parent.MinimumSize = new Size(935, 400);
            this.Close();
        }

        private void LevelsPictureBoxes_Click(object sender, EventArgs e)
        {
            GameSetup.ActivatePbButton(lastSelected, (PictureBox)sender);
            lastSelected = (PictureBox)sender;
        }
    }
}
