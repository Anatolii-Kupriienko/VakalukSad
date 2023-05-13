using CompleteImageGameApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteImageGameApp.AppLogic
{
    public class GameLogic
    {
        public DifficultyEnum _diff;
        bool _isDown;
        int _oldX, _oldY;
        Label[] _grid;
        Bitmap _mainImage;
        List<Bitmap> _piecesList = new();
        List<PictureBox> pictureBoxes = new();
        Panel _panel1;
        GameForm _game;
        public GameLogic(GameForm game, Panel panel1, Image img, DifficultyEnum diff) 
        {
            _game = game;
            _panel1 = panel1;
            _diff = diff;
            _mainImage = new Bitmap(img, new Size(400, 300));
            foreach (var item in _piecesList)
            {
                _piecesList.Remove(item);
            }
            foreach (var item in pictureBoxes)
            {
                pictureBoxes.Remove(item);
            }
        }
        public void AddPiecesOnForm()
        {
            Point lastPos = new Point(_panel1.Right + 50, _panel1.Top);
            CreatePictureBoxes();
            AddPieces();
            for (int i = 0; i < 12; i++)
            {
                if (i == 4 || i == 8)
                {
                    lastPos.X = _panel1.Right + 50;
                    lastPos.Y += 115;
                }
                pictureBoxes[i].Location = lastPos;
                lastPos.X += 115;
                pictureBoxes[i].BorderStyle = BorderStyle.FixedSingle;

            }
            var shuffleImages = pictureBoxes.OrderBy(a => Guid.NewGuid()).ToList();
            pictureBoxes = shuffleImages;
            for (int i = 0; i < 12; i++)
            {
                pictureBoxes[i].Image = _piecesList[i];
                _game.Controls.Add(pictureBoxes[i]);
            }

        }
        public void pb_MouseUp(object sender, MouseEventArgs e)
        {
            _isDown = false;
            closeToBorder(sender, _grid);
            if (DoesAllMatch())
            {
                foreach (var pictureBox in pictureBoxes)
                {
                    pictureBox.Enabled = false;
                }
                MessageBox.Show($"{_game.Size.Width}, {_game.Size.Height}");
            }
        }
        public void pb_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            if (_isDown)
            {
                btn.Left += e.X - _oldX;
                btn.Top += e.Y - _oldY;
                btn.BringToFront();
            }
        }
        public void pb_MouseDown(object sender, MouseEventArgs e)
        {
            _isDown = true;
            _oldX = e.X;
            _oldY = e.Y;
        }
        public void setTable()
        {
            if (_diff == DifficultyEnum.Easy)
            {
                _grid = new Label[9];
            }
            else if (_diff == DifficultyEnum.Medium)
            {
                _grid = new Label[12];
            }
            else
            {
                _grid = new Label[15];
            }
            for (int i = 0; i < 12; i++)
            {
                _grid[i] = new Label();
                _grid[i].Size = new Size(100, 100);
                if (i < 4)
                {
                    _grid[i].Location = new System.Drawing.Point(i * 100, i / 4 * 100);
                }
                else if (i < 8)
                {
                    _grid[i].Location = new System.Drawing.Point((i - 4) * 100, i / 4 * 100);
                }
                else
                {
                    _grid[i].Location = new System.Drawing.Point((i - 8) * 100, i / 4 * 100);
                }
                _grid[i].BorderStyle = BorderStyle.FixedSingle;
                _panel1.Controls.Add(_grid[i]);
                _grid[i].BringToFront();
            }
        }
        public void closeToBorder(object sender, Label[] lbl)
        {
            PictureBox p = (PictureBox)sender;
            for (int i = 0; i < 12; i++)
            {
                if (Math.Abs(p.Left - (lbl[i].Left + _panel1.Left)) < 30 && Math.Abs(p.Top - (lbl[i].Top + _panel1.Top)) < 30)
                {
                    p.Left = lbl[i].Left + _panel1.Left;
                    p.Top = lbl[i].Top + _panel1.Top;
                    break;
                }
            }
        }
        public void CreatePictureBoxes()
        {
            for (int i = 0; i < 12; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 100);
                pictureBox.Tag = i;
                pictureBox.MouseUp += pb_MouseUp;
                pictureBox.MouseMove += pb_MouseMove;
                pictureBox.MouseDown += pb_MouseDown;
                pictureBoxes.Add(pictureBox);
            }
        }
        public void AddPieces()
        {
            int x, y;
            x = 0;
            y = 0;
            for (int blocks = 0; blocks < 12; blocks++)
            {
                Bitmap cropped_image = new Bitmap(100, 100);
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        cropped_image.SetPixel(i, j, _mainImage.GetPixel((i + x), (j + y)));
                    }
                }
                _piecesList.Add(cropped_image);
                x += 100;
                if (x == 400)
                {
                    x = 0;
                    y += 100;
                }
            }
        }
        public bool DoesAllMatch()
        {
            Point point = new Point();

            for (int i = 0; i < 12; i++)
            {
                point.X = pictureBoxes[i].Left - _panel1.Left;
                point.Y = pictureBoxes[i].Top - _panel1.Top;
                if (point != _grid[i].Location)
                    return false;
            }
            return true;
        }
    }
}
