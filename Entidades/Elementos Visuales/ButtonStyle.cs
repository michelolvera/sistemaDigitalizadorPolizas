using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class ButtonStyle : Button 
  {
    public ButtonStyle()
    {
        this.BackColor = System.Drawing.ColorTranslator.FromHtml("#00968");
        this.Font = new Font("Century Gothic", 9, FontStyle.Regular);
        this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#EFF3F5");
    }
  }

