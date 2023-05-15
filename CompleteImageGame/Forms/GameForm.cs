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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CompleteImageGameApp.Forms
{
    public partial class GameForm : Form
    {
        GameLogic game;
        Image helpImage, _img;
        int w, h, timeCounter;
        public GameForm(DifficultyEnum difficulty, Image image)
        {
            InitializeComponent();
            if (difficulty != DifficultyEnum.Hard)
            {
                _img = image;
                helpImage = Image.FromFile("HelpImage.png");
                helperImagePictureBox.Image = helpImage;
            }
            else
                helperImagePictureBox.Hide();
            SetWidthAndHeight(difficulty);
            game = new(this, panel1, image, difficulty, w, h);
            game.setGrid();
            game.AddPiecesOnForm();
            Timer.Start();
        }
        public void SetWidthAndHeight(DifficultyEnum difficulty)
        {
            if (difficulty == DifficultyEnum.Easy)
            {
                w = 133;
                h = 100;
            }
            else if (difficulty == DifficultyEnum.Medium)
            {
                w = 100;
                h = 100;
            }
            else
            {
                w = 100;
                h = 75;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeCounter++;
            int minutes = timeCounter / 60;
            int seconds = timeCounter - (minutes * 60);
            if (timeCounter >= 60)
                TimeLabel.Text = $"Час: {minutes}:{seconds}";
            else
                TimeLabel.Text = $"Час: {seconds}";
        }

        private void GameForm_TextChanged(object sender, EventArgs e)
        {
            Timer.Stop();
            helperImagePictureBox.Hide();
            game.ShowCompletedImage();
        }

        private void helperImagePictureBox_Click(object sender, EventArgs e)
        {
            game.ResizeHelpPictureBox(helperImagePictureBox);
        }

        private void helperImagePictureBox_SizeChanged(object sender, EventArgs e)
        {
            if (helperImagePictureBox.Size == new Size(60, 20))
                helperImagePictureBox.Image = helpImage;
            else
                helperImagePictureBox.Image = _img;
        }
    }
}
