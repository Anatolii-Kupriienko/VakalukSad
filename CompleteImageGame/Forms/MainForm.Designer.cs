namespace CompleteImageGameApp.Forms
{
    partial class MainForm
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
            startButton = new Button();
            mainPanel = new Panel();
            fullScreenButton = new Button();
            exitButton = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.None;
            startButton.BackColor = Color.Bisque;
            startButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.HotPink;
            startButton.ImeMode = ImeMode.NoControl;
            startButton.Location = new Point(209, 131);
            startButton.Name = "startButton";
            startButton.Size = new Size(174, 79);
            startButton.TabIndex = 0;
            startButton.Text = "Почати";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Controls.Add(fullScreenButton);
            mainPanel.Controls.Add(exitButton);
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(0, 261);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(616, 100);
            mainPanel.TabIndex = 1;
            mainPanel.ControlAdded += mainPanel_ControlAdded;
            mainPanel.ControlRemoved += mainPanel_ControlRemoved;
            // 
            // fullScreenButton
            // 
            fullScreenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fullScreenButton.BackColor = Color.PaleGreen;
            fullScreenButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullScreenButton.Location = new Point(0, 49);
            fullScreenButton.Name = "fullScreenButton";
            fullScreenButton.Size = new Size(134, 51);
            fullScreenButton.TabIndex = 2;
            fullScreenButton.Text = "Вийти з повного екрану";
            fullScreenButton.UseVisualStyleBackColor = false;
            fullScreenButton.Click += fullScreenButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.BackColor = Color.IndianRed;
            exitButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ImeMode = ImeMode.NoControl;
            exitButton.Location = new Point(491, 42);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 43);
            exitButton.TabIndex = 1;
            exitButton.Text = "Вийти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(616, 361);
            Controls.Add(mainPanel);
            Controls.Add(startButton);
            MinimumSize = new Size(400, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Main Menu";
            WindowState = FormWindowState.Maximized;
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Panel mainPanel;
        private Button exitButton;
        private Button fullScreenButton;
    }
}