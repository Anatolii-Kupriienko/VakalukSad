using CompleteImageGame;
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
        public static ChooseDifficultyForm StartGame(Panel panel, ChooseDifficultyForm form)
        {
            form = new ChooseDifficultyForm();
            form.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.BringToFront();
            form.Show();
            return form;
        }
    }
}
