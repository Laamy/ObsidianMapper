namespace MemoryReaderExample
{
    // Generated using using ObsidianMapper v1.0 by yeemi#9764
    // Under the GNU License
    public class Keymap
    {
        public static long baseAddr = 0x48E0940;

        public static int __None
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x0);
            set => MMR.WriteMemory(baseAddr + 0x0, value);
        }

        public static int __LButton
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x4);
            set => MMR.WriteMemory(baseAddr + 0x4, value);
        }

        public static int __RButton
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x8);
            set => MMR.WriteMemory(baseAddr + 0x8, value);
        }

        public static int __Cancel
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xC);
            set => MMR.WriteMemory(baseAddr + 0xC, value);
        }

        public static int __MButton
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x10);
            set => MMR.WriteMemory(baseAddr + 0x10, value);
        }

        public static int __XButton1
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x14);
            set => MMR.WriteMemory(baseAddr + 0x14, value);
        }

        public static int __XButton2
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x18);
            set => MMR.WriteMemory(baseAddr + 0x18, value);
        }

        public static int __LButton_XButton2
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1C);
            set => MMR.WriteMemory(baseAddr + 0x1C, value);
        }

        public static int __Back
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x20);
            set => MMR.WriteMemory(baseAddr + 0x20, value);
        }

        public static int __Tab
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x24);
            set => MMR.WriteMemory(baseAddr + 0x24, value);
        }

        public static int __LineFeed
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x28);
            set => MMR.WriteMemory(baseAddr + 0x28, value);
        }

        public static int __LButton_LineFeed
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2C);
            set => MMR.WriteMemory(baseAddr + 0x2C, value);
        }

        public static int __Clear
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x30);
            set => MMR.WriteMemory(baseAddr + 0x30, value);
        }

        public static int __Return
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x34);
            set => MMR.WriteMemory(baseAddr + 0x34, value);
        }

        public static int __RButton_Clear
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x38);
            set => MMR.WriteMemory(baseAddr + 0x38, value);
        }

        public static int __RButton_Return
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3C);
            set => MMR.WriteMemory(baseAddr + 0x3C, value);
        }

        public static int __ShiftKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x40);
            set => MMR.WriteMemory(baseAddr + 0x40, value);
        }

        public static int __ControlKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x44);
            set => MMR.WriteMemory(baseAddr + 0x44, value);
        }

        public static int __Menu
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x48);
            set => MMR.WriteMemory(baseAddr + 0x48, value);
        }

        public static int __Pause
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x4C);
            set => MMR.WriteMemory(baseAddr + 0x4C, value);
        }

        public static int __Capital
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x50);
            set => MMR.WriteMemory(baseAddr + 0x50, value);
        }

        public static int __KanaMode
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x54);
            set => MMR.WriteMemory(baseAddr + 0x54, value);
        }

        public static int __RButton_Capital
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x58);
            set => MMR.WriteMemory(baseAddr + 0x58, value);
        }

        public static int __JunjaMode
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x5C);
            set => MMR.WriteMemory(baseAddr + 0x5C, value);
        }

        public static int __FinalMode
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x60);
            set => MMR.WriteMemory(baseAddr + 0x60, value);
        }

        public static int __HanjaMode
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x64);
            set => MMR.WriteMemory(baseAddr + 0x64, value);
        }

        public static int __RButton_FinalMode
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x68);
            set => MMR.WriteMemory(baseAddr + 0x68, value);
        }

        public static int __Escape
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x6C);
            set => MMR.WriteMemory(baseAddr + 0x6C, value);
        }

        public static int __IMEConvert
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x70);
            set => MMR.WriteMemory(baseAddr + 0x70, value);
        }

        public static int __IMENonconvert
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x74);
            set => MMR.WriteMemory(baseAddr + 0x74, value);
        }

        public static int __IMEAceept
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x78);
            set => MMR.WriteMemory(baseAddr + 0x78, value);
        }

        public static int __IMEModeChange
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x7C);
            set => MMR.WriteMemory(baseAddr + 0x7C, value);
        }

        public static int __Space
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x80);
            set => MMR.WriteMemory(baseAddr + 0x80, value);
        }

        public static int __PageUp
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x84);
            set => MMR.WriteMemory(baseAddr + 0x84, value);
        }

        public static int __Next
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x88);
            set => MMR.WriteMemory(baseAddr + 0x88, value);
        }

        public static int __End
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x8C);
            set => MMR.WriteMemory(baseAddr + 0x8C, value);
        }

        public static int __Home
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x90);
            set => MMR.WriteMemory(baseAddr + 0x90, value);
        }

        public static int __Left
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x94);
            set => MMR.WriteMemory(baseAddr + 0x94, value);
        }

        public static int __Up
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x98);
            set => MMR.WriteMemory(baseAddr + 0x98, value);
        }

        public static int __Right
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x9C);
            set => MMR.WriteMemory(baseAddr + 0x9C, value);
        }

        public static int __Down
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xA0);
            set => MMR.WriteMemory(baseAddr + 0xA0, value);
        }

        public static int __Select
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xA4);
            set => MMR.WriteMemory(baseAddr + 0xA4, value);
        }

        public static int __Print
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xA8);
            set => MMR.WriteMemory(baseAddr + 0xA8, value);
        }

        public static int __Execute
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xAC);
            set => MMR.WriteMemory(baseAddr + 0xAC, value);
        }

        public static int __PrintScreen
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xB0);
            set => MMR.WriteMemory(baseAddr + 0xB0, value);
        }

        public static int __Insert
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xB4);
            set => MMR.WriteMemory(baseAddr + 0xB4, value);
        }

        public static int __Delete
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xB8);
            set => MMR.WriteMemory(baseAddr + 0xB8, value);
        }

        public static int __Help
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xBC);
            set => MMR.WriteMemory(baseAddr + 0xBC, value);
        }

        public static int __D0
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xC0);
            set => MMR.WriteMemory(baseAddr + 0xC0, value);
        }

        public static int __D1
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xC4);
            set => MMR.WriteMemory(baseAddr + 0xC4, value);
        }

        public static int __D2
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xC8);
            set => MMR.WriteMemory(baseAddr + 0xC8, value);
        }

        public static int __D3
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xCC);
            set => MMR.WriteMemory(baseAddr + 0xCC, value);
        }

        public static int __D4
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xD0);
            set => MMR.WriteMemory(baseAddr + 0xD0, value);
        }

        public static int __D5
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xD4);
            set => MMR.WriteMemory(baseAddr + 0xD4, value);
        }

        public static int __D6
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xD8);
            set => MMR.WriteMemory(baseAddr + 0xD8, value);
        }

        public static int __D7
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xDC);
            set => MMR.WriteMemory(baseAddr + 0xDC, value);
        }

        public static int __D8
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xE0);
            set => MMR.WriteMemory(baseAddr + 0xE0, value);
        }

        public static int __D9
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xE4);
            set => MMR.WriteMemory(baseAddr + 0xE4, value);
        }

        public static int __RButton_D8
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xE8);
            set => MMR.WriteMemory(baseAddr + 0xE8, value);
        }

        public static int __RButton_D9
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xEC);
            set => MMR.WriteMemory(baseAddr + 0xEC, value);
        }

        public static int __MButton_D8
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xF0);
            set => MMR.WriteMemory(baseAddr + 0xF0, value);
        }

        public static int __MButton_D9
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xF4);
            set => MMR.WriteMemory(baseAddr + 0xF4, value);
        }

        public static int __XButton2_D8
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xF8);
            set => MMR.WriteMemory(baseAddr + 0xF8, value);
        }

        public static int __XButton2_D9
        {
            get => MMR.ReadMemory<int>(baseAddr + 0xFC);
            set => MMR.WriteMemory(baseAddr + 0xFC, value);
        }

        public static int __64
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x100);
            set => MMR.WriteMemory(baseAddr + 0x100, value);
        }

        public static int __A
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x104);
            set => MMR.WriteMemory(baseAddr + 0x104, value);
        }

        public static int __B
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x108);
            set => MMR.WriteMemory(baseAddr + 0x108, value);
        }

        public static int __C
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x10C);
            set => MMR.WriteMemory(baseAddr + 0x10C, value);
        }

        public static int __D
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x110);
            set => MMR.WriteMemory(baseAddr + 0x110, value);
        }

        public static int __E
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x114);
            set => MMR.WriteMemory(baseAddr + 0x114, value);
        }

        public static int __F
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x118);
            set => MMR.WriteMemory(baseAddr + 0x118, value);
        }

        public static int __G
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x11C);
            set => MMR.WriteMemory(baseAddr + 0x11C, value);
        }

        public static int __H
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x120);
            set => MMR.WriteMemory(baseAddr + 0x120, value);
        }

        public static int __I
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x124);
            set => MMR.WriteMemory(baseAddr + 0x124, value);
        }

        public static int __J
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x128);
            set => MMR.WriteMemory(baseAddr + 0x128, value);
        }

        public static int __K
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x12C);
            set => MMR.WriteMemory(baseAddr + 0x12C, value);
        }

        public static int __L
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x130);
            set => MMR.WriteMemory(baseAddr + 0x130, value);
        }

        public static int __M
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x134);
            set => MMR.WriteMemory(baseAddr + 0x134, value);
        }

        public static int __N
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x138);
            set => MMR.WriteMemory(baseAddr + 0x138, value);
        }

        public static int __O
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x13C);
            set => MMR.WriteMemory(baseAddr + 0x13C, value);
        }

        public static int __P
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x140);
            set => MMR.WriteMemory(baseAddr + 0x140, value);
        }

        public static int __Q
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x144);
            set => MMR.WriteMemory(baseAddr + 0x144, value);
        }

        public static int __R
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x148);
            set => MMR.WriteMemory(baseAddr + 0x148, value);
        }

        public static int __S
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x14C);
            set => MMR.WriteMemory(baseAddr + 0x14C, value);
        }

        public static int __T
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x150);
            set => MMR.WriteMemory(baseAddr + 0x150, value);
        }

        public static int __U
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x154);
            set => MMR.WriteMemory(baseAddr + 0x154, value);
        }

        public static int __V
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x158);
            set => MMR.WriteMemory(baseAddr + 0x158, value);
        }

        public static int __W
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x15C);
            set => MMR.WriteMemory(baseAddr + 0x15C, value);
        }

        public static int __X
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x160);
            set => MMR.WriteMemory(baseAddr + 0x160, value);
        }

        public static int __Y
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x164);
            set => MMR.WriteMemory(baseAddr + 0x164, value);
        }

        public static int __Z
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x168);
            set => MMR.WriteMemory(baseAddr + 0x168, value);
        }

        public static int __LWin
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x16C);
            set => MMR.WriteMemory(baseAddr + 0x16C, value);
        }

        public static int __RWin
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x170);
            set => MMR.WriteMemory(baseAddr + 0x170, value);
        }

        public static int __Apps
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x174);
            set => MMR.WriteMemory(baseAddr + 0x174, value);
        }

        public static int __RButton_RWin
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x178);
            set => MMR.WriteMemory(baseAddr + 0x178, value);
        }

        public static int __Sleep
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x17C);
            set => MMR.WriteMemory(baseAddr + 0x17C, value);
        }

        public static int __NumPad0
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x180);
            set => MMR.WriteMemory(baseAddr + 0x180, value);
        }

        public static int __NumPad1
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x184);
            set => MMR.WriteMemory(baseAddr + 0x184, value);
        }

        public static int __NumPad2
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x188);
            set => MMR.WriteMemory(baseAddr + 0x188, value);
        }

        public static int __NumPad3
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x18C);
            set => MMR.WriteMemory(baseAddr + 0x18C, value);
        }

        public static int __NumPad4
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x190);
            set => MMR.WriteMemory(baseAddr + 0x190, value);
        }

        public static int __NumPad5
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x194);
            set => MMR.WriteMemory(baseAddr + 0x194, value);
        }

        public static int __NumPad6
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x198);
            set => MMR.WriteMemory(baseAddr + 0x198, value);
        }

        public static int __NumPad7
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x19C);
            set => MMR.WriteMemory(baseAddr + 0x19C, value);
        }

        public static int __NumPad8
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1A0);
            set => MMR.WriteMemory(baseAddr + 0x1A0, value);
        }

        public static int __NumPad9
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1A4);
            set => MMR.WriteMemory(baseAddr + 0x1A4, value);
        }

        public static int __Multiply
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1A8);
            set => MMR.WriteMemory(baseAddr + 0x1A8, value);
        }

        public static int __Add
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1AC);
            set => MMR.WriteMemory(baseAddr + 0x1AC, value);
        }

        public static int __Separator
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1B0);
            set => MMR.WriteMemory(baseAddr + 0x1B0, value);
        }

        public static int __Subtract
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1B4);
            set => MMR.WriteMemory(baseAddr + 0x1B4, value);
        }

        public static int __Decimal
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1B8);
            set => MMR.WriteMemory(baseAddr + 0x1B8, value);
        }

        public static int __Divide
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1BC);
            set => MMR.WriteMemory(baseAddr + 0x1BC, value);
        }

        public static int __F1
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1C0);
            set => MMR.WriteMemory(baseAddr + 0x1C0, value);
        }

        public static int __F2
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1C4);
            set => MMR.WriteMemory(baseAddr + 0x1C4, value);
        }

        public static int __F3
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1C8);
            set => MMR.WriteMemory(baseAddr + 0x1C8, value);
        }

        public static int __F4
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1CC);
            set => MMR.WriteMemory(baseAddr + 0x1CC, value);
        }

        public static int __F5
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1D0);
            set => MMR.WriteMemory(baseAddr + 0x1D0, value);
        }

        public static int __F6
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1D4);
            set => MMR.WriteMemory(baseAddr + 0x1D4, value);
        }

        public static int __F7
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1D8);
            set => MMR.WriteMemory(baseAddr + 0x1D8, value);
        }

        public static int __F8
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1DC);
            set => MMR.WriteMemory(baseAddr + 0x1DC, value);
        }

        public static int __F9
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1E0);
            set => MMR.WriteMemory(baseAddr + 0x1E0, value);
        }

        public static int __F10
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1E4);
            set => MMR.WriteMemory(baseAddr + 0x1E4, value);
        }

        public static int __F11
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1E8);
            set => MMR.WriteMemory(baseAddr + 0x1E8, value);
        }

        public static int __F12
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1EC);
            set => MMR.WriteMemory(baseAddr + 0x1EC, value);
        }

        public static int __F13
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1F0);
            set => MMR.WriteMemory(baseAddr + 0x1F0, value);
        }

        public static int __F14
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1F4);
            set => MMR.WriteMemory(baseAddr + 0x1F4, value);
        }

        public static int __F15
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1F8);
            set => MMR.WriteMemory(baseAddr + 0x1F8, value);
        }

        public static int __F16
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x1FC);
            set => MMR.WriteMemory(baseAddr + 0x1FC, value);
        }

        public static int __F17
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x200);
            set => MMR.WriteMemory(baseAddr + 0x200, value);
        }

        public static int __F18
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x204);
            set => MMR.WriteMemory(baseAddr + 0x204, value);
        }

        public static int __F19
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x208);
            set => MMR.WriteMemory(baseAddr + 0x208, value);
        }

        public static int __F20
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x20C);
            set => MMR.WriteMemory(baseAddr + 0x20C, value);
        }

        public static int __F21
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x210);
            set => MMR.WriteMemory(baseAddr + 0x210, value);
        }

        public static int __F22
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x214);
            set => MMR.WriteMemory(baseAddr + 0x214, value);
        }

        public static int __F23
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x218);
            set => MMR.WriteMemory(baseAddr + 0x218, value);
        }

        public static int __F24
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x21C);
            set => MMR.WriteMemory(baseAddr + 0x21C, value);
        }

        public static int __Back_F17
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x220);
            set => MMR.WriteMemory(baseAddr + 0x220, value);
        }

        public static int __Back_F18
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x224);
            set => MMR.WriteMemory(baseAddr + 0x224, value);
        }

        public static int __Back_F19
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x228);
            set => MMR.WriteMemory(baseAddr + 0x228, value);
        }

        public static int __Back_F20
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x22C);
            set => MMR.WriteMemory(baseAddr + 0x22C, value);
        }

        public static int __Back_F21
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x230);
            set => MMR.WriteMemory(baseAddr + 0x230, value);
        }

        public static int __Back_F22
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x234);
            set => MMR.WriteMemory(baseAddr + 0x234, value);
        }

        public static int __Back_F23
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x238);
            set => MMR.WriteMemory(baseAddr + 0x238, value);
        }

        public static int __Back_F24
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x23C);
            set => MMR.WriteMemory(baseAddr + 0x23C, value);
        }

        public static int __NumLock
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x240);
            set => MMR.WriteMemory(baseAddr + 0x240, value);
        }

        public static int __Scroll
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x244);
            set => MMR.WriteMemory(baseAddr + 0x244, value);
        }

        public static int __RButton_NumLock
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x248);
            set => MMR.WriteMemory(baseAddr + 0x248, value);
        }

        public static int __RButton_Scroll
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x24C);
            set => MMR.WriteMemory(baseAddr + 0x24C, value);
        }

        public static int __MButton_NumLock
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x250);
            set => MMR.WriteMemory(baseAddr + 0x250, value);
        }

        public static int __MButton_Scroll
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x254);
            set => MMR.WriteMemory(baseAddr + 0x254, value);
        }

        public static int __XButton2_NumLock
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x258);
            set => MMR.WriteMemory(baseAddr + 0x258, value);
        }

        public static int __XButton2_Scroll
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x25C);
            set => MMR.WriteMemory(baseAddr + 0x25C, value);
        }

        public static int __Back_NumLock
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x260);
            set => MMR.WriteMemory(baseAddr + 0x260, value);
        }

        public static int __Back_Scroll
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x264);
            set => MMR.WriteMemory(baseAddr + 0x264, value);
        }

        public static int __LineFeed_NumLock
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x268);
            set => MMR.WriteMemory(baseAddr + 0x268, value);
        }

        public static int __LineFeed_Scroll
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x26C);
            set => MMR.WriteMemory(baseAddr + 0x26C, value);
        }

        public static int __Clear_NumLock
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x270);
            set => MMR.WriteMemory(baseAddr + 0x270, value);
        }

        public static int __Clear_Scroll
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x274);
            set => MMR.WriteMemory(baseAddr + 0x274, value);
        }

        public static int __RButton_Clear_NumLock
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x278);
            set => MMR.WriteMemory(baseAddr + 0x278, value);
        }

        public static int __RButton_Clear_Scroll
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x27C);
            set => MMR.WriteMemory(baseAddr + 0x27C, value);
        }

        public static int __LShiftKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x280);
            set => MMR.WriteMemory(baseAddr + 0x280, value);
        }

        public static int __RShiftKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x284);
            set => MMR.WriteMemory(baseAddr + 0x284, value);
        }

        public static int __LControlKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x288);
            set => MMR.WriteMemory(baseAddr + 0x288, value);
        }

        public static int __RControlKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x28C);
            set => MMR.WriteMemory(baseAddr + 0x28C, value);
        }

        public static int __LMenu
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x290);
            set => MMR.WriteMemory(baseAddr + 0x290, value);
        }

        public static int __RMenu
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x294);
            set => MMR.WriteMemory(baseAddr + 0x294, value);
        }

        public static int __BrowserBack
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x298);
            set => MMR.WriteMemory(baseAddr + 0x298, value);
        }

        public static int __BrowserForward
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x29C);
            set => MMR.WriteMemory(baseAddr + 0x29C, value);
        }

        public static int __BrowserRefresh
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2A0);
            set => MMR.WriteMemory(baseAddr + 0x2A0, value);
        }

        public static int __BrowserStop
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2A4);
            set => MMR.WriteMemory(baseAddr + 0x2A4, value);
        }

        public static int __BrowserSearch
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2A8);
            set => MMR.WriteMemory(baseAddr + 0x2A8, value);
        }

        public static int __BrowserFavorites
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2AC);
            set => MMR.WriteMemory(baseAddr + 0x2AC, value);
        }

        public static int __BrowserHome
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2B0);
            set => MMR.WriteMemory(baseAddr + 0x2B0, value);
        }

        public static int __VolumeMute
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2B4);
            set => MMR.WriteMemory(baseAddr + 0x2B4, value);
        }

        public static int __VolumeDown
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2B8);
            set => MMR.WriteMemory(baseAddr + 0x2B8, value);
        }

        public static int __VolumeUp
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2BC);
            set => MMR.WriteMemory(baseAddr + 0x2BC, value);
        }

        public static int __MediaNextTrack
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2C0);
            set => MMR.WriteMemory(baseAddr + 0x2C0, value);
        }

        public static int __MediaPreviousTrack
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2C4);
            set => MMR.WriteMemory(baseAddr + 0x2C4, value);
        }

        public static int __MediaStop
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2C8);
            set => MMR.WriteMemory(baseAddr + 0x2C8, value);
        }

        public static int __MediaPlayPause
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2CC);
            set => MMR.WriteMemory(baseAddr + 0x2CC, value);
        }

        public static int __LaunchMail
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2D0);
            set => MMR.WriteMemory(baseAddr + 0x2D0, value);
        }

        public static int __SelectMedia
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2D4);
            set => MMR.WriteMemory(baseAddr + 0x2D4, value);
        }

        public static int __LaunchApplication1
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2D8);
            set => MMR.WriteMemory(baseAddr + 0x2D8, value);
        }

        public static int __LaunchApplication2
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2DC);
            set => MMR.WriteMemory(baseAddr + 0x2DC, value);
        }

        public static int __Back_MediaNextTrack
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2E0);
            set => MMR.WriteMemory(baseAddr + 0x2E0, value);
        }

        public static int __Back_MediaPreviousTrack
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2E4);
            set => MMR.WriteMemory(baseAddr + 0x2E4, value);
        }

        public static int __Oem1
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2E8);
            set => MMR.WriteMemory(baseAddr + 0x2E8, value);
        }

        public static int __Oemplus
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2EC);
            set => MMR.WriteMemory(baseAddr + 0x2EC, value);
        }

        public static int __Oemcomma
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2F0);
            set => MMR.WriteMemory(baseAddr + 0x2F0, value);
        }

        public static int __OemMinus
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2F4);
            set => MMR.WriteMemory(baseAddr + 0x2F4, value);
        }

        public static int __OemPeriod
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2F8);
            set => MMR.WriteMemory(baseAddr + 0x2F8, value);
        }

        public static int __OemQuestion
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x2FC);
            set => MMR.WriteMemory(baseAddr + 0x2FC, value);
        }

        public static int __Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x300);
            set => MMR.WriteMemory(baseAddr + 0x300, value);
        }

        public static int __LButton_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x304);
            set => MMR.WriteMemory(baseAddr + 0x304, value);
        }

        public static int __RButton_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x308);
            set => MMR.WriteMemory(baseAddr + 0x308, value);
        }

        public static int __Cancel_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x30C);
            set => MMR.WriteMemory(baseAddr + 0x30C, value);
        }

        public static int __MButton_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x310);
            set => MMR.WriteMemory(baseAddr + 0x310, value);
        }

        public static int __XButton1_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x314);
            set => MMR.WriteMemory(baseAddr + 0x314, value);
        }

        public static int __XButton2_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x318);
            set => MMR.WriteMemory(baseAddr + 0x318, value);
        }

        public static int __LButton_XButton2_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x31C);
            set => MMR.WriteMemory(baseAddr + 0x31C, value);
        }

        public static int __Back_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x320);
            set => MMR.WriteMemory(baseAddr + 0x320, value);
        }

        public static int __Tab_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x324);
            set => MMR.WriteMemory(baseAddr + 0x324, value);
        }

        public static int __LineFeed_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x328);
            set => MMR.WriteMemory(baseAddr + 0x328, value);
        }

        public static int __LButton_LineFeed_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x32C);
            set => MMR.WriteMemory(baseAddr + 0x32C, value);
        }

        public static int __Clear_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x330);
            set => MMR.WriteMemory(baseAddr + 0x330, value);
        }

        public static int __Return_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x334);
            set => MMR.WriteMemory(baseAddr + 0x334, value);
        }

        public static int __RButton_Clear_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x338);
            set => MMR.WriteMemory(baseAddr + 0x338, value);
        }

        public static int __RButton_Return_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x33C);
            set => MMR.WriteMemory(baseAddr + 0x33C, value);
        }

        public static int __ShiftKey_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x340);
            set => MMR.WriteMemory(baseAddr + 0x340, value);
        }

        public static int __ControlKey_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x344);
            set => MMR.WriteMemory(baseAddr + 0x344, value);
        }

        public static int __Menu_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x348);
            set => MMR.WriteMemory(baseAddr + 0x348, value);
        }

        public static int __Pause_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x34C);
            set => MMR.WriteMemory(baseAddr + 0x34C, value);
        }

        public static int __Capital_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x350);
            set => MMR.WriteMemory(baseAddr + 0x350, value);
        }

        public static int __KanaMode_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x354);
            set => MMR.WriteMemory(baseAddr + 0x354, value);
        }

        public static int __RButton_Capital_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x358);
            set => MMR.WriteMemory(baseAddr + 0x358, value);
        }

        public static int __JunjaMode_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x35C);
            set => MMR.WriteMemory(baseAddr + 0x35C, value);
        }

        public static int __FinalMode_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x360);
            set => MMR.WriteMemory(baseAddr + 0x360, value);
        }

        public static int __HanjaMode_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x364);
            set => MMR.WriteMemory(baseAddr + 0x364, value);
        }

        public static int __RButton_FinalMode_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x368);
            set => MMR.WriteMemory(baseAddr + 0x368, value);
        }

        public static int __OemOpenBrackets
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x36C);
            set => MMR.WriteMemory(baseAddr + 0x36C, value);
        }

        public static int __Oem5
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x370);
            set => MMR.WriteMemory(baseAddr + 0x370, value);
        }

        public static int __Oem6
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x374);
            set => MMR.WriteMemory(baseAddr + 0x374, value);
        }

        public static int __Oem7
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x378);
            set => MMR.WriteMemory(baseAddr + 0x378, value);
        }

        public static int __Oem8
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x37C);
            set => MMR.WriteMemory(baseAddr + 0x37C, value);
        }

        public static int __Space_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x380);
            set => MMR.WriteMemory(baseAddr + 0x380, value);
        }

        public static int __PageUp_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x384);
            set => MMR.WriteMemory(baseAddr + 0x384, value);
        }

        public static int __OemBackslash
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x388);
            set => MMR.WriteMemory(baseAddr + 0x388, value);
        }

        public static int __LButton_OemBackslash
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x38C);
            set => MMR.WriteMemory(baseAddr + 0x38C, value);
        }

        public static int __Home_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x390);
            set => MMR.WriteMemory(baseAddr + 0x390, value);
        }

        public static int __ProcessKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x394);
            set => MMR.WriteMemory(baseAddr + 0x394, value);
        }

        public static int __MButton_OemBackslash
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x398);
            set => MMR.WriteMemory(baseAddr + 0x398, value);
        }

        public static int __Packet
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x39C);
            set => MMR.WriteMemory(baseAddr + 0x39C, value);
        }

        public static int __Down_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3A0);
            set => MMR.WriteMemory(baseAddr + 0x3A0, value);
        }

        public static int __Select_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3A4);
            set => MMR.WriteMemory(baseAddr + 0x3A4, value);
        }

        public static int __Back_OemBackslash
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3A8);
            set => MMR.WriteMemory(baseAddr + 0x3A8, value);
        }

        public static int __Tab_OemBackslash
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3AC);
            set => MMR.WriteMemory(baseAddr + 0x3AC, value);
        }

        public static int __PrintScreen_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3B0);
            set => MMR.WriteMemory(baseAddr + 0x3B0, value);
        }

        public static int __Back_ProcessKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3B4);
            set => MMR.WriteMemory(baseAddr + 0x3B4, value);
        }

        public static int __Clear_OemBackslash
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3B8);
            set => MMR.WriteMemory(baseAddr + 0x3B8, value);
        }

        public static int __Back_Packet
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3BC);
            set => MMR.WriteMemory(baseAddr + 0x3BC, value);
        }

        public static int __D0_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3C0);
            set => MMR.WriteMemory(baseAddr + 0x3C0, value);
        }

        public static int __D1_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3C4);
            set => MMR.WriteMemory(baseAddr + 0x3C4, value);
        }

        public static int __ShiftKey_OemBackslash
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3C8);
            set => MMR.WriteMemory(baseAddr + 0x3C8, value);
        }

        public static int __ControlKey_OemBackslash
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3CC);
            set => MMR.WriteMemory(baseAddr + 0x3CC, value);
        }

        public static int __D4_Oemtilde
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3D0);
            set => MMR.WriteMemory(baseAddr + 0x3D0, value);
        }

        public static int __ShiftKey_ProcessKey
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3D4);
            set => MMR.WriteMemory(baseAddr + 0x3D4, value);
        }

        public static int __Attn
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3D8);
            set => MMR.WriteMemory(baseAddr + 0x3D8, value);
        }

        public static int __Crsel
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3DC);
            set => MMR.WriteMemory(baseAddr + 0x3DC, value);
        }

        public static int __Exsel
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3E0);
            set => MMR.WriteMemory(baseAddr + 0x3E0, value);
        }

        public static int __EraseEof
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3E4);
            set => MMR.WriteMemory(baseAddr + 0x3E4, value);
        }

        public static int __Play
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3E8);
            set => MMR.WriteMemory(baseAddr + 0x3E8, value);
        }

        public static int __Zoom
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3EC);
            set => MMR.WriteMemory(baseAddr + 0x3EC, value);
        }

        public static int __NoName
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3F0);
            set => MMR.WriteMemory(baseAddr + 0x3F0, value);
        }

        public static int __Pa1
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3F4);
            set => MMR.WriteMemory(baseAddr + 0x3F4, value);
        }

        public static int __OemClear
        {
            get => MMR.ReadMemory<int>(baseAddr + 0x3F8);
            set => MMR.WriteMemory(baseAddr + 0x3F8, value);
        }
    }
}
