using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Entidades
{
    public class ButtonStyle : Button
    {
        public ButtonStyle()
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#EFF3F5");
        }
    }
}

