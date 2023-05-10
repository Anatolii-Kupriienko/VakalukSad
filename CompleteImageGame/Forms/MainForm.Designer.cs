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
            exitButton = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.None;
            startButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(381, 197);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 43);
            startButton.TabIndex = 0;
            startButton.Text = "Почати";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mainPanel.Controls.Add(exitButton);
            mainPanel.Location = new Point(692, 373);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(200, 100);
            mainPanel.TabIndex = 1;
            mainPanel.ControlRemoved += mainPanel_ControlRemoved;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(75, 42);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 43);
            exitButton.TabIndex = 1;
            exitButton.Text = "Вийти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 470);
            Controls.Add(mainPanel);
            Controls.Add(startButton);
            MinimumSize = new Size(400, 400);
            Name = "MainForm";
            Text = "MainForm";
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Panel mainPanel;
        private Button exitButton;
    }
}