using System.Drawing;
using System.Windows.Forms;

namespace ObsidianMapper.Controls
{
    public class HighlightedTextbox : Control
    {
        private string _txt = null;

        public string Text
        {
            get => _txt;
            set
            {
                _txt = value;

                Invalidate(); // refresh control
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new PointF(0, 0));
        }
    }
}