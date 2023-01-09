using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObsidianMapper.Controls
{
    public class HexListBox : Control
    {
        #region DESIGNER

        VScrollBar vScrollBar1;

        #endregion

        public void AddColor(char c, Brush color) => _colorMap[c] = color;
        public void RemoveColor(char c) => _colorMap.Remove(c);

        private List<string> _items;
        private int _selectedIndex;
        private int _itemHeight;
        private int _scrollIndex;

        private Dictionary<char, Brush> _colorMap = new Dictionary<char, Brush>()
        { { 'r', Brushes.White } };

        public event EventHandler<int> ItemDoubleClicked;

        public HexListBox()
        {
            _items = new List<string>();
            _selectedIndex = -1;
            _itemHeight = 20;
            _scrollIndex = 0;

            DoubleBuffered = true;

            MouseDoubleClick += HexListBox_MouseDoubleClick;
            MouseDown += HexListBox_MouseDown;

            vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;

            Controls.Add(vScrollBar1);

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = _items.Count;
            vScrollBar1.ValueChanged += HexListBox_Scroll;
        }

        private void HexListBox_Scroll(object sender, EventArgs e)
        {
            _scrollIndex = vScrollBar1.Value;
            Invalidate();
        }

        private void HexListBox_MouseDown(object sender, MouseEventArgs e)
        {
            int itemIndex = HitTest(e.Location);

            _selectedIndex = itemIndex;

            Invalidate();
        }

        private void HexListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int itemIndex = HitTest(e.Location);
            if (itemIndex >= 0)
            {
                ItemDoubleClicked?.Invoke(this, itemIndex);
            }
        }

        private int HitTest(Point location)
        {
            int itemIndex = _scrollIndex + (location.Y / _itemHeight);
            if (itemIndex >= 0 && itemIndex < _items.Count)
            {
                return itemIndex;
            }
            return -1;
        }

        public IList<string> Items
        {
            get => _items;
            set
            {
                _items = (List<string>)value;

                vScrollBar1.Maximum = Math.Max(0, _items.Count - VisibleItemCount);
                vScrollBar1.Visible = _items.Count > VisibleItemCount;
                Invalidate();
            }
        }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (value >= 0 && value < _items.Count)
                {
                    _selectedIndex = value;
                    Invalidate();
                }
            }
        }
        public int ItemHeight
        {
            get => _itemHeight;
            set
            {
                if (value > 0)
                {
                    _itemHeight = value;
                    Invalidate();
                }
            }
        }
        private int VisibleItemCount
        {
            get => ClientSize.Height / _itemHeight;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

            int itemIndex = 0;
            int y = 0;

            foreach (string item in _items)
            {
                if (itemIndex >= _scrollIndex)
                {
                    Rectangle itemRect = new Rectangle(0, y, ClientSize.Width, _itemHeight);

                    if (itemIndex == _selectedIndex)
                    {
                        e.Graphics.FillRectangle(Brushes.LightBlue, itemRect);
                    }

                    OnDrawItem(new DrawItemEventArgs(e.Graphics, Font, itemRect, itemIndex, DrawItemState.None));

                    y += _itemHeight;
                }

                itemIndex++;
            }
        }

        public void OnDrawItem(DrawItemEventArgs e)
        {
            string item = _items[e.Index];

            float x = e.Bounds.X;
            Brush brush = Brushes.White;
            string section = "";
            bool code = false;

            foreach (char c in item)
            {
                if (c == '&')
                {
                    code = true;

                    SizeF size = e.Graphics.MeasureString(section, e.Font);

                    e.Graphics.DrawString(section, e.Font, brush, x, e.Bounds.Y);

                    x += size.Width;

                    section = "";
                }
                else if (code)
                {
                    if (_colorMap.ContainsKey(c))
                        brush = _colorMap[c];
                    else throw new Exception("Invalid ColorMap code");

                    code = false;
                }
                else
                {

                    section += c;
                }
            }

            e.Graphics.DrawString(section, e.Font, brush, x, e.Bounds.Y);
        }
    }
}
