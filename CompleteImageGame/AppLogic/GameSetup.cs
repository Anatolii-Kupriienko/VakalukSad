﻿using CompleteImageGame;
using CompleteImageGameApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CompleteImageGameApp.AppLogic
{
    public static class GameSetup
    {
        internal static ChooseLevelAndDifficultyForm ChooseLevelAndDifficultyForm
        {
            get => default;
            set
            {
            }
        }

        public static MainForm MainForm
        {
            get => default;
            set
            {
            }
        }

        public static DifficultyEnum GetSelectedDifficulty(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rButton = item as RadioButton;
                    if (rButton.Checked)
                        return (DifficultyEnum)rButton.Tag;
                }
            }
            return DifficultyEnum.Medium;
        }
        public static void LoadLevelSelectionForm(Panel panel)
        {
            ChooseLevelAndDifficultyForm form = new();
            form.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
        public static void ActivatePbButton(PictureBox lastSelected, PictureBox sender)
        {
            lastSelected.Size = new Size(150, 150);
            lastSelected.BorderStyle = BorderStyle.None;
            lastSelected.Location = new Point(lastSelected.Location.X + 10, lastSelected.Location.Y + 5);
            sender.Size = new Size(170, 170);
            sender.BorderStyle = BorderStyle.FixedSingle;
            sender.Location = new Point(sender.Location.X - 10, sender.Location.Y - 5);
        }
        public static void ActivatePbButton(PictureBox sender)
        {
            sender.Size = new Size(170, 170);
            sender.BorderStyle = BorderStyle.FixedSingle;
            sender.Location = new Point(sender.Location.X - 10, sender.Location.Y - 5);
        }
        public static GameForm LoadGameForm(ChooseLevelAndDifficultyForm form )
        {
            GameForm game = new(MainForm.chosenDifficulty, MainForm.chosenImage);
            game.TopLevel = false;
            game.Dock = DockStyle.Fill;
            game.FormBorderStyle = FormBorderStyle.None;
            form.Parent.Controls.Add(game);
            game.BringToFront();
            game.Show();
            return game;
        }
        public static Image GetRandomImage(ImageList imageList)
        {
            Random random = new();
            int temp = random.Next(5);
            var randomImage = imageList.Images[temp];
            randomImage.Tag = temp;
            return randomImage;

        }
    }
}
