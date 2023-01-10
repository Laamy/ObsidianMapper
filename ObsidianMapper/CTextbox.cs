using System.Drawing;
using System.Windows.Forms;

using ObsidianMapper.Controls;

namespace ObsidianMapper
{
    public partial class CTextbox : Form
    {
        public CTextbox(string code)
        {
            InitializeComponent();

            HighlightedTextbox textbox = new HighlightedTextbox();
            textbox.Font = new Font("Arial", 9);
            textbox.ForeColor = Color.Black;
            textbox.Dock = DockStyle.Fill;
            textbox.Text = code;
            Controls.Add(textbox);
        }
    }
}
