namespace CompleteImageGameApp.Forms
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            panel1 = new Panel();
            Timer = new System.Windows.Forms.Timer(components);
            TimeLabel = new Label();
            helperImagePictureBox = new PictureBox();
            pauseButton = new Button();
            pauseButtonImages = new ImageList(components);
            pausedLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)helperImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(33, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 0;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.BackColor = Color.Transparent;
            TimeLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TimeLabel.ForeColor = Color.MintCream;
            TimeLabel.Location = new Point(12, 9);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(62, 18);
            TimeLabel.TabIndex = 1;
            TimeLabel.Text = "Час: 0";
            // 
            // helperImagePictureBox
            // 
            helperImagePictureBox.Location = new Point(637, 9);
            helperImagePictureBox.Name = "helperImagePictureBox";
            helperImagePictureBox.Size = new Size(60, 20);
            helperImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            helperImagePictureBox.TabIndex = 2;
            helperImagePictureBox.TabStop = false;
            helperImagePictureBox.SizeChanged += helperImagePictureBox_SizeChanged;
            helperImagePictureBox.Click += helperImagePictureBox_Click;
            // 
            // pauseButton
            // 
            pauseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pauseButton.BackgroundImageLayout = ImageLayout.Stretch;
            pauseButton.Location = new Point(1270, 9);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(40, 40);
            pauseButton.TabIndex = 3;
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // pauseButtonImages
            // 
            pauseButtonImages.ColorDepth = ColorDepth.Depth8Bit;
            pauseButtonImages.ImageStream = (ImageListStreamer)resources.GetObject("pauseButtonImages.ImageStream");
            pauseButtonImages.TransparentColor = Color.Transparent;
            pauseButtonImages.Images.SetKeyName(0, "pause.png");
            pauseButtonImages.Images.SetKeyName(1, "play.png");
            // 
            // pausedLabel
            // 
            pausedLabel.AutoSize = true;
            pausedLabel.BackColor = Color.Transparent;
            pausedLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            pausedLabel.ForeColor = Color.LightGray;
            pausedLabel.Location = new Point(593, 324);
            pausedLabel.Name = "pausedLabel";
            pausedLabel.Size = new Size(210, 65);
            pausedLabel.TabIndex = 4;
            pausedLabel.Text = "PAUSED";
            pausedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1324, 702);
            Controls.Add(pausedLabel);
            Controls.Add(pauseButton);
            Controls.Add(helperImagePictureBox);
            Controls.Add(TimeLabel);
            Controls.Add(panel1);
            MinimumSize = new Size(1340, 740);
            Name = "GameForm";
            Text = "Complete The Image";
            TextChanged += GameForm_TextChanged;
            ((System.ComponentModel.ISupportInitialize)helperImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer Timer;
        private Label TimeLabel;
        private PictureBox helperImagePictureBox;
        private Button pauseButton;
        private ImageList pauseButtonImages;
        private Label pausedLabel;
    }
}