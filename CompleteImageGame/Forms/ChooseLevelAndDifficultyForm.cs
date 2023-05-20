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
            this.AcceptButton = playButton;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            MainForm.chosenDifficulty = GameSetup.GetSelectedDifficulty(this);
            if (lastSelected.Tag == "Random")
            {
                lastSelected.Image = GameSetup.GetRandomImage(LevelsImages);
                lastSelected.Tag = lastSelected.Image.Tag;
            }
            MainForm.chosenImage = lastSelected.Image;
            if (lastSelected.Tag == "UserChoice")
            {
                MainForm.completedImage = MainForm.chosenImage;
            }
            else
            {
                int tag = Convert.ToInt32(lastSelected.Tag);
                MainForm.completedImage = CompletedImages.Images[tag];
            }
            this.Parent.Parent.MinimumSize = new Size(1340, 770);
            GameSetup.LoadGameForm(this);
            this.Close();
        }

        private void LevelsPictureBoxes_Click(object sender, EventArgs e)
        {
            GameSetup.ActivatePbButton(lastSelected, (PictureBox)sender);
            lastSelected = (PictureBox)sender;
        }

        private void uploadImagePictureBox_Click(object sender, EventArgs e)
        {
            GameSetup.ActivatePbButton(lastSelected, (PictureBox)sender);
            lastSelected = (PictureBox)sender;
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image Files Only | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lastSelected.Image = Image.FromFile(openFileDialog.FileName);
                uploadImagePictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
