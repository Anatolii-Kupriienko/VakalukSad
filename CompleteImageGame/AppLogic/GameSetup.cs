using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteImageGameApp.AppLogic
{
    public static class GameSetup
    {
        public static RadioButton SearchForCheckedRadioButton(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rButton = item as RadioButton;
                    if (rButton.Checked)
                        return rButton;
                }
            }
        }
    }
}
