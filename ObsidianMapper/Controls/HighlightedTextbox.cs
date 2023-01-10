using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ObsidianMapper.Controls
{
    public class HighlightedTextbox : Control
    {
        private string _txt = null;

        private Dictionary<string, Color> _keywords = new Dictionary<string, Color>();

        public string Text
        {
            get => _txt;
            set
            {
                _txt = value;

                Invalidate(); // refresh control
            }
        }

        public void AddKeyword(string keyword, Color color) => _keywords[keyword] = color;
        public void RemoveKeyword(string keyword) => _keywords.Remove(keyword);

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor); // clear buffer with backcolor

            string[] lines = Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None); // split tokens

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;
            format.FormatFlags = StringFormatFlags.NoWrap;
            format.Trimming = StringTrimming.None;

            float[] tabStops = { 18, 36, 54, 72, 90, 108, 126, 144, 162, 180 };
            format.SetTabStops(0, tabStops);

            PointF point = new PointF(0, 0);

            Brush brush;

            foreach (string line in lines)
            {
                string[] tokens = Regex.Split(line, @"( |\t|:)");

                foreach (string token in tokens)
                {
                    if (token == " ")
                        continue;

                    if (_keywords.ContainsKey(token))
                        brush = new SolidBrush(_keywords[token]);
                    else brush = new SolidBrush(ForeColor);

                    e.Graphics.DrawString(token, Font, brush, point, format);

                    SizeF size = e.Graphics.MeasureString(token, Font, point, format);
                    point.X += size.Width;
                }

                point = new PointF(0, point.Y + Font.Height);
            }
        }
    }
}