﻿using CompleteImageGameApp.AppLogic;
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
        bool isPaused = false;
        public GameForm(DifficultyEnum difficulty, Image image)
        {
            InitializeComponent();
            pauseButton.BackgroundImage = pauseButtonImages.Images[0];
            pauseButton.BackgroundImageLayout = ImageLayout.Stretch;
            pausedLabel.Hide();
            if (difficulty != DifficultyEnum.Hard)
            {
                _img = image;
                helpImage = Image.FromFile("peekImage.png");
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

        public MainForm MainForm
        {
            get => default;
            set
            {
            }
        }

        public void SetWidthAndHeight(DifficultyEnum difficulty)
        {
            if (difficulty == DifficultyEnum.Easy)
            {
                w = 200;
                h = 200;
            }
            else if (difficulty == DifficultyEnum.Medium)
            {
                w = 150;
                h = 200;
            }
            else
            {
                w = 150;
                h = 150;
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
            pauseButton.Hide();
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

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (isPaused == false)
            {
                Timer.Stop();
                game.DisableAllTiles();
                isPaused = true;
                pauseButton.BackgroundImage = pauseButtonImages.Images[1];
                pausedLabel.BringToFront();
                pausedLabel.Show();
            }
            else
            {
                Timer.Start();
                game.EnableAllTiles();
                isPaused = false;
                pauseButton.BackgroundImage = pauseButtonImages.Images[0];
                pausedLabel.Hide();
            }

        }
    }
}
