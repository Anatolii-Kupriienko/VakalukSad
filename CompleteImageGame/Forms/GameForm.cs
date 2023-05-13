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
    public partial class GameForm : Form
    {
        GameLogic game;
        public GameForm(DifficultyEnum difficulty, Image image)
        {
            InitializeComponent();
            game = new(this, panel1, image, difficulty);
            game.setTable();
            game.AddPiecesOnForm();
        }
       
        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            game.pb_MouseUp(sender, e);
        }
        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            game.pb_MouseMove(sender, e);
        }
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            game.pb_MouseDown(sender, e);
        }    }
}
