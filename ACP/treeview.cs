using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACP
{
    class treeview
    {
        private SolidBrush _highlightBrush;
        private SolidBrush _originalBackColorBrush;
        private Color originalBackColor = Color.FromArgb(192, 255, 255);
        private Color originalTextColor = Color.Black;
        public void _treeview(DrawTreeNodeEventArgs e)
        {
            if (_highlightBrush == null)
            {
                //Color.FromArgb(192, 255, 255)
                _highlightBrush = new SolidBrush(Color.FromArgb(192, 255, 255));
            }
            if (_originalBackColorBrush == null)
            {
                _originalBackColorBrush = new SolidBrush(e.Node.BackColor);
            }
            //e.Graphics.SetClip(e.Bounds);
            if (e.Node.IsSelected)
            {
                e.Node.ForeColor = Color.White;
                e.Graphics.FillRectangle(_highlightBrush, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(_originalBackColorBrush, e.Bounds);
            }

            TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.NodeFont, e.Bounds, originalTextColor, TextFormatFlags.GlyphOverhangPadding);
        }
    }
}
