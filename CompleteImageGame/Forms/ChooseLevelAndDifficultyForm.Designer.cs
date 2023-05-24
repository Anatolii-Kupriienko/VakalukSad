namespace CompleteImageGameApp.Forms
{
    partial class ChooseLevelAndDifficultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevelAndDifficultyForm));
            chooseDifficultyLabel = new Label();
            HardDifficultyRadioButton = new RadioButton();
            MediumDifficultyRadioButton = new RadioButton();
            EasyDifficultyRadioButton = new RadioButton();
            playButton = new Button();
            firstLevelPB = new PictureBox();
            LevelsImages = new ImageList(components);
            secondLevelPB = new PictureBox();
            fourthLevelPB = new PictureBox();
            thirdLevelPB = new PictureBox();
            fifthLevelPB = new PictureBox();
            randomLevelPB = new PictureBox();
            CompletedImages = new ImageList(components);
            uploadImagePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)firstLevelPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondLevelPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fourthLevelPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thirdLevelPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fifthLevelPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)randomLevelPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uploadImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // chooseDifficultyLabel
            // 
            chooseDifficultyLabel.Anchor = AnchorStyles.Bottom;
            chooseDifficultyLabel.AutoSize = true;
            chooseDifficultyLabel.BackColor = Color.Transparent;
            chooseDifficultyLabel.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            chooseDifficultyLabel.ForeColor = Color.Crimson;
            chooseDifficultyLabel.Location = new Point(225, 335);
            chooseDifficultyLabel.Name = "chooseDifficultyLabel";
            chooseDifficultyLabel.Size = new Size(236, 23);
            chooseDifficultyLabel.TabIndex = 2;
            chooseDifficultyLabel.Text = "Оберіть складність гри:";
            // 
            // HardDifficultyRadioButton
            // 
            HardDifficultyRadioButton.Anchor = AnchorStyles.Bottom;
            HardDifficultyRadioButton.AutoSize = true;
            HardDifficultyRadioButton.BackColor = Color.Transparent;
            HardDifficultyRadioButton.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            HardDifficultyRadioButton.ForeColor = Color.Crimson;
            HardDifficultyRadioButton.Location = new Point(689, 335);
            HardDifficultyRadioButton.Name = "HardDifficultyRadioButton";
            HardDifficultyRadioButton.Size = new Size(92, 27);
            HardDifficultyRadioButton.TabIndex = 7;
            HardDifficultyRadioButton.Tag = AppLogic.DifficultyEnum.Hard;
            HardDifficultyRadioButton.Text = "Важко";
            HardDifficultyRadioButton.UseVisualStyleBackColor = false;
            // 
            // MediumDifficultyRadioButton
            // 
            MediumDifficultyRadioButton.Anchor = AnchorStyles.Bottom;
            MediumDifficultyRadioButton.AutoSize = true;
            MediumDifficultyRadioButton.BackColor = Color.Transparent;
            MediumDifficultyRadioButton.Checked = true;
            MediumDifficultyRadioButton.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            MediumDifficultyRadioButton.ForeColor = Color.Crimson;
            MediumDifficultyRadioButton.Location = new Point(553, 335);
            MediumDifficultyRadioButton.Name = "MediumDifficultyRadioButton";
            MediumDifficultyRadioButton.Size = new Size(134, 27);
            MediumDifficultyRadioButton.TabIndex = 6;
            MediumDifficultyRadioButton.TabStop = true;
            MediumDifficultyRadioButton.Tag = AppLogic.DifficultyEnum.Medium;
            MediumDifficultyRadioButton.Text = "Нормально";
            MediumDifficultyRadioButton.UseVisualStyleBackColor = false;
            // 
            // EasyDifficultyRadioButton
            // 
            EasyDifficultyRadioButton.Anchor = AnchorStyles.Bottom;
            EasyDifficultyRadioButton.AutoSize = true;
            EasyDifficultyRadioButton.BackColor = Color.Transparent;
            EasyDifficultyRadioButton.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            EasyDifficultyRadioButton.ForeColor = Color.Crimson;
            EasyDifficultyRadioButton.Location = new Point(467, 335);
            EasyDifficultyRadioButton.Name = "EasyDifficultyRadioButton";
            EasyDifficultyRadioButton.Size = new Size(81, 27);
            EasyDifficultyRadioButton.TabIndex = 5;
            EasyDifficultyRadioButton.Tag = AppLogic.DifficultyEnum.Easy;
            EasyDifficultyRadioButton.Text = "Легко";
            EasyDifficultyRadioButton.UseVisualStyleBackColor = false;
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Bottom;
            playButton.BackColor = Color.Turquoise;
            playButton.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            playButton.ForeColor = Color.Indigo;
            playButton.Location = new Point(439, 368);
            playButton.Name = "playButton";
            playButton.Size = new Size(178, 57);
            playButton.TabIndex = 8;
            playButton.Text = "ГРАТИ";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // firstLevelPB
            // 
            firstLevelPB.Anchor = AnchorStyles.Top;
            firstLevelPB.Image = (Image)resources.GetObject("firstLevelPB.Image");
            firstLevelPB.Location = new Point(12, 10);
            firstLevelPB.Name = "firstLevelPB";
            firstLevelPB.Size = new Size(150, 150);
            firstLevelPB.SizeMode = PictureBoxSizeMode.StretchImage;
            firstLevelPB.TabIndex = 9;
            firstLevelPB.TabStop = false;
            firstLevelPB.Tag = "1";
            firstLevelPB.Click += LevelsPictureBoxes_Click;
            // 
            // LevelsImages
            // 
            LevelsImages.ColorDepth = ColorDepth.Depth16Bit;
            LevelsImages.ImageStream = (ImageListStreamer)resources.GetObject("LevelsImages.ImageStream");
            LevelsImages.TransparentColor = Color.Transparent;
            LevelsImages.Images.SetKeyName(0, "image3.jpg");
            LevelsImages.Images.SetKeyName(1, "image5.jpg");
            LevelsImages.Images.SetKeyName(2, "image1.jpg");
            LevelsImages.Images.SetKeyName(3, "image2.jpg");
            LevelsImages.Images.SetKeyName(4, "image4.jpg");
            // 
            // secondLevelPB
            // 
            secondLevelPB.Anchor = AnchorStyles.Top;
            secondLevelPB.Image = (Image)resources.GetObject("secondLevelPB.Image");
            secondLevelPB.Location = new Point(183, 10);
            secondLevelPB.Name = "secondLevelPB";
            secondLevelPB.Size = new Size(150, 150);
            secondLevelPB.SizeMode = PictureBoxSizeMode.StretchImage;
            secondLevelPB.TabIndex = 10;
            secondLevelPB.TabStop = false;
            secondLevelPB.Tag = "0";
            secondLevelPB.Click += LevelsPictureBoxes_Click;
            // 
            // fourthLevelPB
            // 
            fourthLevelPB.Anchor = AnchorStyles.Top;
            fourthLevelPB.Image = (Image)resources.GetObject("fourthLevelPB.Image");
            fourthLevelPB.Location = new Point(689, 10);
            fourthLevelPB.Name = "fourthLevelPB";
            fourthLevelPB.Size = new Size(150, 150);
            fourthLevelPB.SizeMode = PictureBoxSizeMode.StretchImage;
            fourthLevelPB.TabIndex = 12;
            fourthLevelPB.TabStop = false;
            fourthLevelPB.Tag = "3";
            fourthLevelPB.Click += LevelsPictureBoxes_Click;
            // 
            // thirdLevelPB
            // 
            thirdLevelPB.Anchor = AnchorStyles.Top;
            thirdLevelPB.Image = (Image)resources.GetObject("thirdLevelPB.Image");
            thirdLevelPB.Location = new Point(348, 10);
            thirdLevelPB.Name = "thirdLevelPB";
            thirdLevelPB.Size = new Size(150, 150);
            thirdLevelPB.SizeMode = PictureBoxSizeMode.Zoom;
            thirdLevelPB.TabIndex = 11;
            thirdLevelPB.TabStop = false;
            thirdLevelPB.Tag = "2";
            thirdLevelPB.Click += LevelsPictureBoxes_Click;
            // 
            // fifthLevelPB
            // 
            fifthLevelPB.Anchor = AnchorStyles.Top;
            fifthLevelPB.Image = (Image)resources.GetObject("fifthLevelPB.Image");
            fifthLevelPB.Location = new Point(518, 12);
            fifthLevelPB.Name = "fifthLevelPB";
            fifthLevelPB.Size = new Size(150, 150);
            fifthLevelPB.SizeMode = PictureBoxSizeMode.StretchImage;
            fifthLevelPB.TabIndex = 13;
            fifthLevelPB.TabStop = false;
            fifthLevelPB.Tag = "4";
            fifthLevelPB.Click += LevelsPictureBoxes_Click;
            // 
            // randomLevelPB
            // 
            randomLevelPB.Anchor = AnchorStyles.Top;
            randomLevelPB.Image = (Image)resources.GetObject("randomLevelPB.Image");
            randomLevelPB.Location = new Point(852, 12);
            randomLevelPB.Name = "randomLevelPB";
            randomLevelPB.Size = new Size(150, 150);
            randomLevelPB.SizeMode = PictureBoxSizeMode.StretchImage;
            randomLevelPB.TabIndex = 14;
            randomLevelPB.TabStop = false;
            randomLevelPB.Tag = "Random";
            randomLevelPB.Click += LevelsPictureBoxes_Click;
            // 
            // CompletedImages
            // 
            CompletedImages.ColorDepth = ColorDepth.Depth16Bit;
            CompletedImages.ImageStream = (ImageListStreamer)resources.GetObject("CompletedImages.ImageStream");
            CompletedImages.TransparentColor = Color.Transparent;
            CompletedImages.Images.SetKeyName(0, "image3_completed.jpg");
            CompletedImages.Images.SetKeyName(1, "image5_completed.jpg");
            CompletedImages.Images.SetKeyName(2, "image1_completed.jpg");
            CompletedImages.Images.SetKeyName(3, "image2_completed.jpg");
            CompletedImages.Images.SetKeyName(4, "image4_completed.jpg");
            // 
            // uploadImagePictureBox
            // 
            uploadImagePictureBox.Anchor = AnchorStyles.Top;
            uploadImagePictureBox.Image = (Image)resources.GetObject("uploadImagePictureBox.Image");
            uploadImagePictureBox.Location = new Point(450, 179);
            uploadImagePictureBox.Name = "uploadImagePictureBox";
            uploadImagePictureBox.Size = new Size(150, 150);
            uploadImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            uploadImagePictureBox.TabIndex = 15;
            uploadImagePictureBox.TabStop = false;
            uploadImagePictureBox.Tag = "UserChoice";
            uploadImagePictureBox.Click += uploadImagePictureBox_Click;
            // 
            // ChooseLevelAndDifficultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1014, 437);
            Controls.Add(uploadImagePictureBox);
            Controls.Add(randomLevelPB);
            Controls.Add(fifthLevelPB);
            Controls.Add(fourthLevelPB);
            Controls.Add(thirdLevelPB);
            Controls.Add(secondLevelPB);
            Controls.Add(firstLevelPB);
            Controls.Add(playButton);
            Controls.Add(HardDifficultyRadioButton);
            Controls.Add(MediumDifficultyRadioButton);
            Controls.Add(EasyDifficultyRadioButton);
            Controls.Add(chooseDifficultyLabel);
            MinimumSize = new Size(1030, 420);
            Name = "ChooseLevelAndDifficultyForm";
            Tag = "UserChoice";
            Text = "Оберіть зображення";
            ((System.ComponentModel.ISupportInitialize)firstLevelPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondLevelPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)fourthLevelPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)thirdLevelPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)fifthLevelPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)randomLevelPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)uploadImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label chooseDifficultyLabel;
        private RadioButton HardDifficultyRadioButton;
        private RadioButton MediumDifficultyRadioButton;
        private RadioButton EasyDifficultyRadioButton;
        private Button playButton;
        private PictureBox firstLevelPB;
        private ImageList LevelsImages;
        private PictureBox secondLevelPB;
        private PictureBox fourthLevelPB;
        private PictureBox thirdLevelPB;
        private PictureBox fifthLevelPB;
        private PictureBox randomLevelPB;
        private ImageList CompletedImages;
        private PictureBox uploadImagePictureBox;
    }
}