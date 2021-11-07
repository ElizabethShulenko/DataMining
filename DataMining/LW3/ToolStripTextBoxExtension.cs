using System;
using System.Drawing;
using System.Windows.Forms;

namespace LW3
{
    public static class ToolStripTextBoxExtensions
    {
        public static void InitHint(this ToolStripTextBox textBox, string hint)
        {
            textBox.Text = hint;

            var wma = true;

            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (source, e) =>
            {
                if (((ToolStripTextBox)source).ForeColor == Color.Black)
                {
                    return;
                }

                if (wma)
                {
                    wma = false;

                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (source, e) =>
            {
                var t = ((ToolStripTextBox)source);

                if (t.Text.Length == 0)
                {
                    t.Text = hint;
                    t.ForeColor = Color.Gray;

                    return;
                }

                if (!wma && String.IsNullOrEmpty(textBox.Text))
                {
                    wma = true;
                    textBox.Text = hint;
                    textBox.ForeColor = Color.Gray;
                }
            };

            textBox.TextChanged += (source, e) =>
            {
                if (((ToolStripTextBox)source).Text.Length > 0)
                {
                    textBox.ForeColor = Color.Black;
                }
            };
        }
    }
}