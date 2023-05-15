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
            panel1 = new Panel();
            Timer = new System.Windows.Forms.Timer(components);
            TimeLabel = new Label();
            helperImagePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)helperImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(33, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 300);
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
            TimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.Location = new Point(12, 9);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(52, 21);
            TimeLabel.TabIndex = 1;
            TimeLabel.Text = "Час: 0";
            // 
            // helperImagePictureBox
            // 
            helperImagePictureBox.Location = new Point(435, 10);
            helperImagePictureBox.Name = "helperImagePictureBox";
            helperImagePictureBox.Size = new Size(60, 20);
            helperImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            helperImagePictureBox.TabIndex = 2;
            helperImagePictureBox.TabStop = false;
            helperImagePictureBox.SizeChanged += helperImagePictureBox_SizeChanged;
            helperImagePictureBox.Click += helperImagePictureBox_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 384);
            Controls.Add(helperImagePictureBox);
            Controls.Add(TimeLabel);
            Controls.Add(panel1);
            Name = "GameForm";
            Text = "GameForm";
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
    }
}