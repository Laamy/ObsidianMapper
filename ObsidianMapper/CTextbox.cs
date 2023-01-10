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
            textbox.Font = new Font("Arial", 12);
            textbox.Dock = DockStyle.Fill;

            textbox.AddKeyword("public", Color.CadetBlue);
            textbox.AddKeyword("class", Color.CadetBlue);

            textbox.Text = code;
            Controls.Add(textbox);
        }
    }
}
