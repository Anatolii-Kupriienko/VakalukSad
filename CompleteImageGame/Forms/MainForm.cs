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
        public static Image chosenImage, completedImage;
        public Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            activeForm = this;
            this.AcceptButton = startButton;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public GameLogic GameLogic
        {
            get => default;
            set
            {
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameSetup.LoadLevelSelectionForm(mainPanel);
            this.MinimumSize = new Size(1030, 470);
            exitButton.BringToFront();
            fullScreenButton.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            mainPanel.Dock = DockStyle.Bottom;
            activeForm = this;
        }

        private void mainPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (!mainPanel.Contains(activeForm))
            {
                this.Text = "Головне меню";
                this.MinimumSize = new Size(400, 400);
            }
            exitButton.BringToFront();
            fullScreenButton.BringToFront();
        }

        private void mainPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is Form)
                activeForm = (Form)e.Control;
            this.Text = e.Control.Text;
        }

        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                fullScreenButton.Text = "Вийти з повного екрану";
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                fullScreenButton.Location = new Point(8, mainPanel.Height - fullScreenButton.Height - 9);
            }
            else
            {
                fullScreenButton.Text = "Повний екран";
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                fullScreenButton.Location = new Point(0, mainPanel.Height - fullScreenButton.Height);
            }
        }
    }
}
