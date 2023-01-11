using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using ObsidianMapper.Controls;

namespace ObsidianMapper
{
    public partial class Form1 : Form
    {
        // variables
        Process proc = null;

        public const ulong PROGRAM_BYTE_INCR = 8;
        public static ulong PROGRAM_ADDRESS = 0;
        public static int PROGRAM_BYTES_READ = 64;

        UIntPtr processHandle = UIntPtr.Zero;

        public HexListBox HexListBox = new HexListBox();

        public Dictionary<int, MemoryVarType> memoryTypes = new Dictionary<int, MemoryVarType>();
        public Dictionary<int, string> memoryNames = new Dictionary<int, string>();

        public Form1() => InitializeComponent();

        private void AppLoad(object sender, EventArgs e)
        {
            DarkMenuStrip.Renderer = new DarkStripRenderer();

            Controls.Add(HexListBox);
            HexListBox.Dock = DockStyle.Fill;

            foreach (MemoryVarType type in Enum.GetValues(typeof(MemoryVarType)))
            {
                var item = NodeContextStrip.Items.Add(type.ToString());
                item.ForeColor = Color.White;
                item.TextImageRelation = TextImageRelation.Overlay;
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
                item.BackColor = Color.FromArgb(32, 32, 32);

                item.Click += (_sender, _e) =>
                {
                    int blockIndex = HexListBox.SelectedIndex;
                    blockIndex = blockIndex - 1;

                    if (memoryTypes.ContainsKey(blockIndex))
                        memoryTypes.Remove(blockIndex);

                    memoryTypes.Add(blockIndex, type);
                };
            }

            int bytes = (int)PROGRAM_BYTE_INCR;
            for (int i = 0; i < 12; i++)
            {
                bytes *= 2; // 8, 16, 32, 64...

                var item = AddBytesDropdown.DropDownItems.Add("Add " + bytes + " bytes");
                item.ForeColor = Color.White;
                item.TextImageRelation = TextImageRelation.Overlay;
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
                item.BackColor = Color.FromArgb(32, 32, 32);

                int _bytes = bytes; // just incase
                item.Click += (_sender, _e) => PROGRAM_BYTES_READ += _bytes;
            }

            HexListBox.ItemDoubleClicked += HexListBoxAction;
            HexListBox.Font = new Font("Courier New", 12f);

            HexListBox.BringToFront();
            HexListBox.AddColor('a', Brushes.ForestGreen);
            HexListBox.AddColor('g', Brushes.Gray);
            HexListBox.AddColor('d', Brushes.HotPink);

            HexListBox.ContextMenuStrip = NodeContextStrip;

            memoryTypes.Add(0, MemoryVarType.uintptr_t_VT); // VTable
            memoryNames.Add(0, "VTable");
        }

        private void HexListBoxAction(object sender, int index)
        {
            if (index != ListBox.NoMatches)
            {
                string item = HexListBox.Items[index];

                // code for when u double click a node

                if (item.StartsWith("ADDRESS: ")) // might dump this method already
                {
                    if (proc == null)
                        return;

                    string addr = Interaction.InputBox("Enter program address (Include baseAddr)", "Enter address", PROGRAM_ADDRESS.ToString("X"));

                    IFormatProvider provider = CultureInfo.GetCultureInfo("en-US");

                    ulong result;

                    if (ulong.TryParse(addr, NumberStyles.HexNumber, provider, out result))
                    {
                        PROGRAM_ADDRESS = result;
                    }
                }
                else
                {
                    int blockIndex = index - 1;

                    if (!memoryNames.ContainsKey(blockIndex))
                        memoryNames.Add(blockIndex, ". .");

                    string input = Interaction.InputBox("Enter a unique name to be used once you generate your C/C++", "Enter name", "Unknown");

                    input = input.Replace(" ", "_");
                    memoryNames[blockIndex] = input;
                }
            }
        }
        private void AttachToGame(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("Minecraft.Windows");

            if (procs.Length < 1)
            {
                proc = Process.Start("minecraft://");
            }
            else
            {
                proc = Process.GetProcessesByName("Minecraft.Windows")[0];
            }

            try
            {
                processHandle = Kernel32.OpenProcess(Kernel32.ProcessAccessFlags.All, false, (uint)proc.Id);
            }
            catch
            {
                MessageBox.Show("Please reattach once the game finishes launching");
            }


            if (processHandle == UIntPtr.Zero)
            {
                MessageBox.Show("Failed to open process?"); // should never call
                return;
            }
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string line = "";
            uint offset = 0x0;
            int index = 0;
            int lineValuesPerLine = 0;
            int numBytes = 8;

            List<string> items = new List<string>
            {
                "ADDRESS: " + PROGRAM_ADDRESS.ToString("X")
            }; // had to do the meths before cuz it was tearing the screen

            IntPtr baseAddress = new IntPtr((long)PROGRAM_ADDRESS);

            byte[] buffer = new byte[PROGRAM_BYTES_READ];

            int dsadsada = 0;
            Kernel32.ReadProcessMemory(
                processHandle,
                baseAddress,
                buffer,
                PROGRAM_BYTES_READ,
                ref dsadsada
            );

            int realIndex = 0;

            foreach (byte bite in buffer)
            {
                if (!memoryTypes.ContainsKey(index))
                    memoryTypes.Add(index, MemoryVarType.Hex64);

                if (lineValuesPerLine == 0)
                {
                    numBytes = MemoryVarTypeData.GetSize(memoryTypes[index]) / 8;
                }

                string hex = string.Format("{0:X2}", (int)bite);

                if (hex != "00")
                    line += hex + " ";
                else line += ".. ";

                lineValuesPerLine++;

                if (lineValuesPerLine == numBytes) // gonna rewrite all of this so I can list shit in any byte order I want...
                {
                    string item = "&g" + string.Format("{0:X2}", offset) + "&r " + line + "&d";
                    MemoryVarType result;

                    int readStart = index * numBytes;

                    int floatStart = readStart + 4; // float
                    int intStart = readStart + 4; // integer
                    //int doubleStart = readStart + 8; // double

                    if (!(readStart < 0 || readStart + 4 > buffer.Length)) // 1F4982A5040
                    {
                        switch (numBytes)
                        {
                            case 8:
                                if (memoryTypes[index] == MemoryVarType.Hex64)
                                {
                                    item += $"({(float)Math.Round(float.Parse(BitConverter.ToSingle(buffer, readStart).ToString()), 2)}|{(float)Math.Round(float.Parse(BitConverter.ToSingle(buffer, floatStart).ToString()), 2)}) {BitConverter.ToInt32(buffer, readStart)}|{BitConverter.ToInt32(buffer, intStart)}";
                                }
                                else if (memoryTypes[index] == MemoryVarType.Pointer ||
                                    memoryTypes[index] == MemoryVarType.uintptr_t_VT)
                                {
                                    item += $"{((long)Math.Round(double.Parse(BitConverter.ToInt64(buffer, readStart).ToString()), 2)).ToString("X")}";
                                }
                                else if (memoryTypes[index] == MemoryVarType.Double)
                                {
                                    item += "(NI)"; // not implemented
                                    //item += $"{(double)Math.Round(double.Parse(BitConverter.ToDouble(buffer, doubleStart).ToString()), 2)}"; // fuck this
                                }
                                break;

                            case 4:
                                if (memoryTypes[index] == MemoryVarType.Hex32)
                                {
                                    item += $"({(float)Math.Round(float.Parse(BitConverter.ToSingle(buffer, readStart).ToString()), 2)}) {BitConverter.ToInt32(buffer, readStart)}";
                                }
                                else if (memoryTypes[index] == MemoryVarType.Float)
                                {
                                    item += $"{(float)Math.Round(float.Parse(BitConverter.ToSingle(buffer, realIndex).ToString()), 2)}";
                                }
                                else
                                if (memoryTypes[index] == MemoryVarType.Int32)
                                {
                                    item += $"{BitConverter.ToInt32(buffer, readStart)}";
                                }
                                break;

                            case 2:
                                item += $"({BitConverter.ToInt16(buffer, readStart)})";
                                break;

                            case 1:
                                item += $"({buffer[readStart]})";
                                break;
                        }
                    }
                    else
                    {
                        // tried to read past buffer
                    }

                    if (memoryTypes.TryGetValue(index, out result))
                    {
                        if (!(result.Equals(MemoryVarType.Hex64) || result.Equals(MemoryVarType.Hex32) || result.Equals(MemoryVarType.Hex16) | result.Equals(MemoryVarType.Hex8)))
                        {
                            if (!memoryNames.ContainsKey(index))
                                memoryNames.Add(index, "Unknown");

                            item += $"&a({memoryNames[index]}) -> {Enum.GetName(typeof(MemoryVarType), result)}";
                        }
                    }

                    items.Add(item);

                    offset += (uint)lineValuesPerLine;
                    line = "";
                    lineValuesPerLine = 0;

                    index++;
                }
                realIndex++;
            }

            HexListBox.Items = items;
        }

        private void generateCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTextbox cDis = new CTextbox("\tbool* OnGround() {\r\n\t\tstatic unsigned int offset = *reinterpret_cast<int*>((uintptr_t)findSig(\"80 BF ? ? ? ? 00 74 70 48 8B\") + 2);\r\n\t\treturn reinterpret_cast<bool*>((uintptr_t)this + offset);\r\n\t}");
            cDis.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) // automatically map out keymap (Minecraft.Windows.exe+48E0A9C)
        {
            if (proc != null && !proc.HasExited)
            {
                IFormatProvider provider = CultureInfo.GetCultureInfo("en-US");

                ulong offset;

                if (ulong.TryParse(KeymapAddr.Text.Split('+')[1], NumberStyles.HexNumber, provider, out offset))
                    PROGRAM_ADDRESS = offset;

                ulong address = (ulong)proc.MainModule.BaseAddress + offset;

                //PROGRAM_BYTES_READ = 0xFF * 4;
                PROGRAM_ADDRESS = address - (4 * 'W');

                for (int i = 0; i < 0xFF; ++i)
                {
                    int memOffset = i;

                    if (!memoryTypes.ContainsKey(memOffset) || !memoryNames.ContainsKey(memOffset))
                    {
                        memoryTypes[memOffset] = MemoryVarType.Int32;
                        memoryNames[memOffset] = ((Keys)memOffset).ToString();
                    }
                    else
                    {
                        memoryTypes[memOffset] = MemoryVarType.Int32;
                        memoryNames[memOffset] = ((Keys)memOffset).ToString();
                    }
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) // Minecraft.Windows.exe+48E0A9C
        {
            if (proc == null || proc.HasExited)
                return;

            string typeTemplate = "\r\n\r\n\tpublic static $TYPE$ _$NAME$\r\n\t{\r\n\t\tget => MMR.ReadMemory<$TYPE$>(baseAddr + $OFFSET$);\r\n\t\tset => MMR.WriteMemory(baseAddr + $OFFSET$, value);\r\n\t}";
            
            if (PROGRAM_ADDRESS == 0)
                PROGRAM_ADDRESS = (ulong)proc.MainModule.BaseAddress.ToInt64();

            string classStart = $"// Generated using using ObsidianMapper v1.0 by yeemi#9764\r\n// Under the GNU License\r\npublic class MyCSharpClass\r\n{{\r\n\t" +
                $"public static long baseAddr = 0x{((long)PROGRAM_ADDRESS - proc.MainModule.BaseAddress.ToInt64()).ToString("X")};";
            
            PROGRAM_ADDRESS = 0;

            string line = "";
            uint offset = 0x0;
            int index = 0;
            int lineValuesPerLine = 0;
            int numBytes = 8;

            IntPtr baseAddress = new IntPtr((long)PROGRAM_ADDRESS);

            byte[] buffer = new byte[PROGRAM_BYTES_READ];

            int dsadsada = 0;
            Kernel32.ReadProcessMemory(
                processHandle,
                baseAddress,
                buffer,
                PROGRAM_BYTES_READ,
                ref dsadsada
            );

            int realIndex = 0;

            foreach (byte bite in buffer)
            {
                if (!memoryTypes.ContainsKey(index))
                    memoryTypes.Add(index, MemoryVarType.Hex64);

                if (!memoryNames.ContainsKey(index))
                    memoryNames.Add(index, "Unknown");

                if (lineValuesPerLine == 0)
                {
                    numBytes = MemoryVarTypeData.GetSize(memoryTypes[index]) / 8;
                }

                string hex = string.Format("{0:X2}", (int)bite);

                if (hex != "00")
                    line += hex + " ";
                else line += ".. ";

                lineValuesPerLine++;

                if (lineValuesPerLine == numBytes) // gonna rewrite all of this so I can list shit in any byte order I want...
                {
                    string item = typeTemplate;
                    MemoryVarType result;

                    int readStart = index * numBytes;

                    int floatStart = readStart + 4;
                    int intStart = readStart + 4;

                    if (!(readStart < 0 || readStart + 4 > buffer.Length))
                    {
                        switch (numBytes) // ignore VTable pointers & unassigned hex memory
                        {
                            case 8:
                                if (memoryTypes[index] == MemoryVarType.Pointer)
                                    item = item.Replace("$TYPE$", "IntPtr");
                                else if (memoryTypes[index] == MemoryVarType.Double)
                                    item = item.Replace("$TYPE$", "double");
                                break;

                            case 4:
                                if (memoryTypes[index] == MemoryVarType.Int32)
                                    item = item.Replace("$TYPE$", "int");
                                else if (memoryTypes[index] == MemoryVarType.Float)
                                    item = item.Replace("$TYPE$", "float");
                                break;

                            case 2:
                                if (memoryTypes[index] == MemoryVarType.Int16)
                                    item = item.Replace("$TYPE$", "short");
                                break;

                            case 1:
                                if (memoryTypes[index] == MemoryVarType.Int8)
                                    item = item.Replace("$TYPE$", "byte");
                                break;
                        }

                        item = item.Replace("$OFFSET$", "0x" + (realIndex - (MemoryVarTypeData.GetSize(memoryTypes[index]) / 8 - 1)).ToString("X"));
                    }
                    else
                    {
                        // tried to read past buffer
                    }

                    if (item != null)
                        item = item.Replace("$NAME$", "_" + memoryNames[index]
                            .Replace("(", "")
                            .Replace(")", "")
                            .Replace(",", "_")
                            .Replace(" ", "")
                            );

                    if (!item.Contains("$TYPE$"))
                    {
                        classStart += item;
                        offset += (uint)lineValuesPerLine;
                    }

                    line = "";
                    lineValuesPerLine = 0;

                    index++;
                }
                realIndex++;
            }

            CTextbox textbox = new CTextbox(classStart + "\r\n}");
            textbox.Show();
        }
    }

    public class DarkStripRenderer : ToolStripProfessionalRenderer
    {
        public DarkStripRenderer() : base(new DarkStripColors()) { }
    }

    public class DarkStripColors : ProfessionalColorTable
    {
        public override Color MenuBorder => Color.FromArgb(32, 32, 32);
        public override Color MenuItemBorder => Color.FromArgb(32, 32, 32);

        public override Color MenuItemPressedGradientBegin => Color.FromArgb(32, 32, 32);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(32, 32, 32);

        public override Color ToolStripDropDownBackground => Color.FromArgb(32, 32, 32);
        public override Color ToolStripContentPanelGradientBegin => Color.FromArgb(32, 32, 32);

        public override Color MenuItemSelected => Color.Blue;
        public override Color MenuItemSelectedGradientBegin => Color.Blue;
        public override Color MenuItemSelectedGradientEnd => Color.Blue;

        public override Color ToolStripGradientBegin => Color.FromArgb(32, 32, 32);
        public override Color ToolStripGradientMiddle => Color.FromArgb(32, 32, 32);
        public override Color ToolStripGradientEnd => Color.FromArgb(32, 32, 32);

        public override Color ToolStripBorder => Color.FromArgb(32, 32, 32);
    }

    public enum MemoryVarType : byte
    {
        Hex64,
        Hex32,
        Hex16,
        Hex8,
        Double,
        Pointer,
        uintptr_t_VT,
        Float,
        Int32,
        Int16,
        Int8,
    }

    public static class MemoryVarTypeData
    {
        private static readonly Dictionary<MemoryVarType, byte> sizes = new Dictionary<MemoryVarType, byte>
        {
            [MemoryVarType.Hex64] = 64,
            [MemoryVarType.Hex32] = 32,
            [MemoryVarType.Hex16] = 16,
            [MemoryVarType.Hex8] = 8,
            [MemoryVarType.Double] = 64,
            [MemoryVarType.Pointer] = 64,
            [MemoryVarType.uintptr_t_VT] = 64,
            [MemoryVarType.Float] = 32,
            [MemoryVarType.Int32] = 32,
            [MemoryVarType.Int16] = 16,
            [MemoryVarType.Int8] = 8,
        };

        private static readonly Dictionary<MemoryVarType, string> varDefs = new Dictionary<MemoryVarType, string>
        {
            [MemoryVarType.Hex64] = "CHAR_PADDING",
            [MemoryVarType.Hex32] = "CHAR_PADDING",
            [MemoryVarType.Hex16] = "CHAR_PADDING",
            [MemoryVarType.Hex16] = "CHAR_PADDING", // defaults to character array padding
            [MemoryVarType.Double] = "double",
            [MemoryVarType.Pointer] = "uintptr_t*",
            [MemoryVarType.uintptr_t_VT] = "uintptr_t**",
            [MemoryVarType.Float] = "float",
            [MemoryVarType.Int32] = "int",
            [MemoryVarType.Int16] = "int16",
            [MemoryVarType.Int8] = "int8",
        };

        public static byte GetSize(MemoryVarType type)
        {
            return sizes[type];
        }
    }
}