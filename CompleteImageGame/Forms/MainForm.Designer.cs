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
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(344, 171);
            startButton.Name = "startButton";
            startButton.Size = new Size(92, 46);
            startButton.TabIndex = 0;
            startButton.Text = "Почати";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 243);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(308, 207);
            mainPanel.TabIndex = 1;
            mainPanel.ControlRemoved += mainPanel_ControlRemoved;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(702, 399);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(86, 39);
            exitButton.TabIndex = 2;
            exitButton.Text = "Вийти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(mainPanel);
            Controls.Add(startButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Panel mainPanel;
        private Button exitButton;
    }
}