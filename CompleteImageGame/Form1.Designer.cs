namespace CompleteImageGame
{
    partial class mainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chooseImageButton = new Button();
            chooseDifficultyLabel = new Label();
            EasyDifficultyRadioButton = new RadioButton();
            MediumDifficultyRadioButton = new RadioButton();
            HardDifficultyRadioButton = new RadioButton();
            exitButton = new Button();
            SuspendLayout();
            // 
            // chooseImageButton
            // 
            chooseImageButton.Anchor = AnchorStyles.None;
            chooseImageButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chooseImageButton.Location = new Point(110, 200);
            chooseImageButton.Name = "chooseImageButton";
            chooseImageButton.Size = new Size(155, 85);
            chooseImageButton.TabIndex = 0;
            chooseImageButton.Text = "ГРАТИ";
            chooseImageButton.UseVisualStyleBackColor = true;
            chooseImageButton.Click += chooseImageButton_Click;
            // 
            // chooseDifficultyLabel
            // 
            chooseDifficultyLabel.Anchor = AnchorStyles.None;
            chooseDifficultyLabel.AutoSize = true;
            chooseDifficultyLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            chooseDifficultyLabel.Location = new Point(80, 60);
            chooseDifficultyLabel.Name = "chooseDifficultyLabel";
            chooseDifficultyLabel.Size = new Size(215, 25);
            chooseDifficultyLabel.TabIndex = 1;
            chooseDifficultyLabel.Text = "Оберіть складність гри:";
            // 
            // EasyDifficultyRadioButton
            // 
            EasyDifficultyRadioButton.Anchor = AnchorStyles.None;
            EasyDifficultyRadioButton.AutoSize = true;
            EasyDifficultyRadioButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EasyDifficultyRadioButton.Location = new Point(145, 98);
            EasyDifficultyRadioButton.Name = "EasyDifficultyRadioButton";
            EasyDifficultyRadioButton.Size = new Size(80, 29);
            EasyDifficultyRadioButton.TabIndex = 2;
            EasyDifficultyRadioButton.Text = "Легко";
            EasyDifficultyRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumDifficultyRadioButton
            // 
            MediumDifficultyRadioButton.Anchor = AnchorStyles.None;
            MediumDifficultyRadioButton.AutoSize = true;
            MediumDifficultyRadioButton.Checked = true;
            MediumDifficultyRadioButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MediumDifficultyRadioButton.Location = new Point(145, 130);
            MediumDifficultyRadioButton.Name = "MediumDifficultyRadioButton";
            MediumDifficultyRadioButton.Size = new Size(130, 29);
            MediumDifficultyRadioButton.TabIndex = 3;
            MediumDifficultyRadioButton.TabStop = true;
            MediumDifficultyRadioButton.Text = "Нормально";
            MediumDifficultyRadioButton.UseVisualStyleBackColor = true;
            // 
            // HardDifficultyRadioButton
            // 
            HardDifficultyRadioButton.Anchor = AnchorStyles.None;
            HardDifficultyRadioButton.AutoSize = true;
            HardDifficultyRadioButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            HardDifficultyRadioButton.Location = new Point(145, 160);
            HardDifficultyRadioButton.Name = "HardDifficultyRadioButton";
            HardDifficultyRadioButton.Size = new Size(85, 29);
            HardDifficultyRadioButton.TabIndex = 4;
            HardDifficultyRadioButton.Text = "Важко";
            HardDifficultyRadioButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(267, 311);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(105, 38);
            exitButton.TabIndex = 5;
            exitButton.Text = "Вийти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // mainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(exitButton);
            Controls.Add(HardDifficultyRadioButton);
            Controls.Add(MediumDifficultyRadioButton);
            Controls.Add(EasyDifficultyRadioButton);
            Controls.Add(chooseDifficultyLabel);
            Controls.Add(chooseImageButton);
            MinimumSize = new Size(400, 400);
            Name = "mainMenuForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseImageButton;
        private Label chooseDifficultyLabel;
        private RadioButton EasyDifficultyRadioButton;
        private RadioButton MediumDifficultyRadioButton;
        private RadioButton HardDifficultyRadioButton;
        private Button exitButton;
    }
}