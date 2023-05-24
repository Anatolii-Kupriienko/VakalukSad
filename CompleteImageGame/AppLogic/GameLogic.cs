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
        public bool _isDown;
        public int _oldX, _oldY, _w, _h, _numberOfTiles, _tilesPerRow;
        public Label[] _grid;
        public Bitmap _mainImage;
        public List<Bitmap> _piecesList = new();
        public List<PictureBox> pictureBoxes = new();
        public Panel _panel1;
        public GameForm _game;
        public GameLogic(GameForm game, Panel panel1, Image img, DifficultyEnum diff, int w, int h) 
        {
            _w = w;
            _h = h;
            _game = game;
            _panel1 = panel1;
            _diff = diff;
            _mainImage = new Bitmap(img, new Size(600, 600));
            foreach (var item in _piecesList)
            {
                _piecesList.Remove(item);
            }
            foreach (var item in pictureBoxes)
            {
                pictureBoxes.Remove(item);
            }
            SetOverallAndPerRowNumberOfTiles(_diff);
        }

        public GameForm GameForm
        {
            get => default;
            set
            {
            }
        }

        private string GetTime()
        {
            var timeLabel = _game.Controls.Find("TimeLabel", false);
            return timeLabel[0].Text;
        }
        private void SetOverallAndPerRowNumberOfTiles(DifficultyEnum difficulty)
        {
            if (difficulty == DifficultyEnum.Easy)
            {
                _numberOfTiles = 9;
                _tilesPerRow = 3;
            }
            else if (difficulty == DifficultyEnum.Medium)
            {
                _numberOfTiles = 12;
                _tilesPerRow = 4;
            }
            else
            {
                _numberOfTiles = 16;
                _tilesPerRow = 4;
            }
        }
        public void AddPiecesOnForm()
        {
            Point lastPos = new Point(_panel1.Right + 50, _panel1.Top);
            CreatePictureBoxes();
            AddPieces();
            for (int i = 0; i < _numberOfTiles; i++)
            {
                if (i%_tilesPerRow==0&&i!=0)
                {
                    lastPos.X = _panel1.Right + 50;
                    lastPos.Y += _h+10;
                }
                pictureBoxes[i].Location = lastPos;
                lastPos.X += _w+10;
                pictureBoxes[i].BorderStyle = BorderStyle.FixedSingle;

            }
            var shuffleImages = pictureBoxes.OrderBy(a => Guid.NewGuid()).ToList();
            pictureBoxes = shuffleImages;
            for (int i = 0; i < _numberOfTiles; i++)
            {
                pictureBoxes[i].Image = _piecesList[i];
                _game.Controls.Add(pictureBoxes[i]);
            }
        }
        
        public void closeToBorder(object sender, Label[] lbl)
        {
            PictureBox p = (PictureBox)sender;
            for (int i = 0; i < _numberOfTiles; i++)
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
            for (int i = 0; i < _numberOfTiles; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(_w, _h);
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
            for (int blocks = 0; blocks < _numberOfTiles; blocks++)
            {
                Bitmap cropped_image = new Bitmap(_w, _h);
                for (int i = 0; i < _w; i++)
                {
                    for (int j = 0; j < _h; j++)
                    {
                        cropped_image.SetPixel(i, j, _mainImage.GetPixel((i + x), (j + y)));
                    }
                }
                _piecesList.Add(cropped_image);
                x += _w;
                if (x == 600|| x==399)
                {
                    x = 0;
                    y += _h;
                }
            }
        }
        public bool DoesAllMatch()
        {
            Point point = new Point();

            for (int i = 0; i < _numberOfTiles; i++)
            {
                point.X = pictureBoxes[i].Left - _panel1.Left;
                point.Y = pictureBoxes[i].Top - _panel1.Top;
                if (point != _grid[i].Location)
                    return false;
            }
            return true;
        }
        public void setGrid()
        {
            _grid = new Label[_numberOfTiles];
            for (int i = 0; i < _numberOfTiles/_tilesPerRow; i++)
            {
                for(int j = 0; j < _tilesPerRow; j++)
                {
                    _grid[(i * _tilesPerRow) + j] = new Label();
                    _grid[(i * _tilesPerRow) + j].Size = new Size(_w, _h);
                    _grid[(i * _tilesPerRow) + j].Location = new Point(_w * j, _h*i);
                    _grid[(i * _tilesPerRow) + j].BorderStyle = BorderStyle.FixedSingle;
                    _panel1.Controls.Add(_grid[(i * _tilesPerRow) + j]);
                    _grid[(i * _tilesPerRow) + j].BringToFront();
                }
            }
        }
        public void DisableAllTiles()
        {
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Enabled = false;
            }
        }
        public void EnableAllTiles()
        {
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Enabled = true;
            }
        }
        public void ShowCompletedImage()
        {
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Hide();
            }
            foreach (var label in _grid)
            {
                label.Hide();
            }
            var completedImagePB = new PictureBox();
            completedImagePB.Image = MainForm.completedImage;
            completedImagePB.SizeMode = PictureBoxSizeMode.StretchImage;
            _panel1.Controls.Add(completedImagePB);
            completedImagePB.Size = new Size(600, 600);
            completedImagePB.Show();
            completedImagePB.BringToFront();
        }
        public void ResizeHelpPictureBox(PictureBox pb)
        {
            if (pb.Size == new Size(60, 20))
            {
                DisableAllTiles();
                pb.Size = new Size(400, 300);
                pb.BringToFront();
            }
            else
            {
                pb.Size = new Size(60, 20);
                EnableAllTiles();
                pb.BringToFront();
            }
        }
        public void pb_MouseUp(object sender, MouseEventArgs e)
        {
            _isDown = false;
            closeToBorder(sender, _grid);
            if (DoesAllMatch())
            {
                _game.Text = "Image Completed";
                DisableAllTiles();
                MessageBox.Show($"Так тримати College Boy\nВаш {GetTime()}", "Good job College Boy",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
    }
}
