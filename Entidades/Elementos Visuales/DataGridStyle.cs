﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class DataGridStyle : DataGridView
    {
        public DataGridStyle()
        {
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold);
            this.EnableHeadersVisualStyles = false;
            this.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#76eec6");
            this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            this.MultiSelect = false;
            this.GridColor = SystemColors.ControlLight;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.RowsDefaultCellStyle.BackColor = Color.White;
            this.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF3F5"); 
        }
    }
}
