using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Entidades
{
    public class ButtonStyle : Button
    {
        public ButtonStyle()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#EFF3F5");
            this.FlatStyle = FlatStyle.Popup;
        }
    }
}
