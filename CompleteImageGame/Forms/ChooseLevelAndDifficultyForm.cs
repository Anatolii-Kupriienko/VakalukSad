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
            lastSelected.Size = new Size(140, 140);
            lastSelected.BorderStyle = BorderStyle.FixedSingle;
            lastSelected.Location = new Point(lastSelected.Location.X - 10, lastSelected.Location.Y - 5);
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
        }

        private void LevelsPictureBoxes_Click(object sender, EventArgs e)
        {
            
            var selectedPB = (PictureBox)sender;
            GameSetup.ActivatePbButton(lastSelected, selectedPB);
            lastSelected = selectedPB;
        }
    }
}
