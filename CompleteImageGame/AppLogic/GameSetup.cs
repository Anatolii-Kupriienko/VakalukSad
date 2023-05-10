using CompleteImageGame;
using CompleteImageGameApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteImageGameApp.AppLogic
{
    public static class GameSetup
    {
        public static DifficultyEnum GetSelectedDifficulty(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rButton = item as RadioButton;
                    if (rButton.Checked)
                        return (DifficultyEnum)rButton.Tag;
                }
            }
            return DifficultyEnum.Medium;
        }
        public static ChooseLevelAndDifficultyForm StartGame(Panel panel, ChooseLevelAndDifficultyForm form)
        {
            form = new ChooseLevelAndDifficultyForm();
            form.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.BringToFront();
            form.Show();
            return form;
        }
        public static void ActivatePbButton(PictureBox lastSelected, PictureBox sender)
        {
            var selectedPB = sender;
            lastSelected.Size = new Size(120, 120);
            lastSelected.BorderStyle = BorderStyle.None;
            lastSelected.Location = new Point(lastSelected.Location.X + 10, lastSelected.Location.Y + 5);
            selectedPB.Size = new Size(140, 140);
            selectedPB.BorderStyle = BorderStyle.FixedSingle;
            selectedPB.Location = new Point(selectedPB.Location.X - 10, selectedPB.Location.Y - 5);
        }
    }
}
