using System.Drawing;
using System.Windows.Forms;

using ObsidianMapper.Controls;

namespace ObsidianMapper
{
    public partial class CTextbox : Form
    {
        HighlightedTextbox textbox;

        public CTextbox(string code)
        {
            InitializeComponent();

            textbox = new HighlightedTextbox();
            textbox.Font = new Font("Arial", 12);
            textbox.Dock = DockStyle.Fill;

            textbox.AddKeywords(new[] {
                "public", "class", "unsigned", "static", "reinterpret_cast", "this",
                "bool", "int", "int16", "int8"
            }, Color.CadetBlue);

            textbox.AddKeywords(new[] {
                "return"
            }, Color.HotPink);

            textbox.AddKeywords(new[] {
                "uintptr_t"
            }, Color.ForestGreen);

            textbox.Text = code;
            Controls.Add(textbox);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(textbox.Text);
            Close();
        }
    }
}
