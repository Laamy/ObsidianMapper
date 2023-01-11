namespace MemoryReaderExample
{
    // Generated using using ObsidianMapper v1.0 by yeemi#9764
    // Under the GNU License
    public class Keymap
    {
        public static long keymapBase = 0x48E0940;
        public static bool KEY_None
        { get => MMR.ReadInt(keymapBase + 0x0) == 1; }
        public static bool KEY_LButton
        { get => MMR.ReadInt(keymapBase + 0x4) == 1; }
        public static bool KEY_RButton
        { get => MMR.ReadInt(keymapBase + 0x8) == 1; }
        public static bool KEY_Cancel
        { get => MMR.ReadInt(keymapBase + 0xC) == 1; }
        public static bool KEY_MButton
        { get => MMR.ReadInt(keymapBase + 0x10) == 1; }
        public static bool KEY_XButton1
        { get => MMR.ReadInt(keymapBase + 0x14) == 1; }
        public static bool KEY_XButton2
        { get => MMR.ReadInt(keymapBase + 0x18) == 1; }
        public static bool KEY_LButton_XButton2
        { get => MMR.ReadInt(keymapBase + 0x1C) == 1; }
        public static bool KEY_Back
        { get => MMR.ReadInt(keymapBase + 0x20) == 1; }
        public static bool KEY_Tab
        { get => MMR.ReadInt(keymapBase + 0x24) == 1; }
        public static bool KEY_LineFeed
        { get => MMR.ReadInt(keymapBase + 0x28) == 1; }
        public static bool KEY_LButton_LineFeed
        { get => MMR.ReadInt(keymapBase + 0x2C) == 1; }
        public static bool KEY_Clear
        { get => MMR.ReadInt(keymapBase + 0x30) == 1; }
        public static bool KEY_Return
        { get => MMR.ReadInt(keymapBase + 0x34) == 1; }
        public static bool KEY_RButton_Clear
        { get => MMR.ReadInt(keymapBase + 0x38) == 1; }
        public static bool KEY_RButton_Return
        { get => MMR.ReadInt(keymapBase + 0x3C) == 1; }
        public static bool KEY_ShiftKey
        { get => MMR.ReadInt(keymapBase + 0x40) == 1; }
        public static bool KEY_ControlKey
        { get => MMR.ReadInt(keymapBase + 0x44) == 1; }
        public static bool KEY_Menu
        { get => MMR.ReadInt(keymapBase + 0x48) == 1; }
        public static bool KEY_Pause
        { get => MMR.ReadInt(keymapBase + 0x4C) == 1; }
        public static bool KEY_Capital
        { get => MMR.ReadInt(keymapBase + 0x50) == 1; }
        public static bool KEY_KanaMode
        { get => MMR.ReadInt(keymapBase + 0x54) == 1; }
        public static bool KEY_RButton_Capital
        { get => MMR.ReadInt(keymapBase + 0x58) == 1; }
        public static bool KEY_JunjaMode
        { get => MMR.ReadInt(keymapBase + 0x5C) == 1; }
        public static bool KEY_FinalMode
        { get => MMR.ReadInt(keymapBase + 0x60) == 1; }
        public static bool KEY_HanjaMode
        { get => MMR.ReadInt(keymapBase + 0x64) == 1; }
        public static bool KEY_RButton_FinalMode
        { get => MMR.ReadInt(keymapBase + 0x68) == 1; }
        public static bool KEY_Escape
        { get => MMR.ReadInt(keymapBase + 0x6C) == 1; }
        public static bool KEY_IMEConvert
        { get => MMR.ReadInt(keymapBase + 0x70) == 1; }
        public static bool KEY_IMENonconvert
        { get => MMR.ReadInt(keymapBase + 0x74) == 1; }
        public static bool KEY_IMEAceept
        { get => MMR.ReadInt(keymapBase + 0x78) == 1; }
        public static bool KEY_IMEModeChange
        { get => MMR.ReadInt(keymapBase + 0x7C) == 1; }
        public static bool KEY_Space
        { get => MMR.ReadInt(keymapBase + 0x80) == 1; }
        public static bool KEY_PageUp
        { get => MMR.ReadInt(keymapBase + 0x84) == 1; }
        public static bool KEY_Next
        { get => MMR.ReadInt(keymapBase + 0x88) == 1; }
        public static bool KEY_End
        { get => MMR.ReadInt(keymapBase + 0x8C) == 1; }
        public static bool KEY_Home
        { get => MMR.ReadInt(keymapBase + 0x90) == 1; }
        public static bool KEY_Left
        { get => MMR.ReadInt(keymapBase + 0x94) == 1; }
        public static bool KEY_Up
        { get => MMR.ReadInt(keymapBase + 0x98) == 1; }
        public static bool KEY_Right
        { get => MMR.ReadInt(keymapBase + 0x9C) == 1; }
        public static bool KEY_Down
        { get => MMR.ReadInt(keymapBase + 0xA0) == 1; }
        public static bool KEY_Select
        { get => MMR.ReadInt(keymapBase + 0xA4) == 1; }
        public static bool KEY_Print
        { get => MMR.ReadInt(keymapBase + 0xA8) == 1; }
        public static bool KEY_Execute
        { get => MMR.ReadInt(keymapBase + 0xAC) == 1; }
        public static bool KEY_PrintScreen
        { get => MMR.ReadInt(keymapBase + 0xB0) == 1; }
        public static bool KEY_Insert
        { get => MMR.ReadInt(keymapBase + 0xB4) == 1; }
        public static bool KEY_Delete
        { get => MMR.ReadInt(keymapBase + 0xB8) == 1; }
        public static bool KEY_Help
        { get => MMR.ReadInt(keymapBase + 0xBC) == 1; }
        public static bool KEY_D0
        { get => MMR.ReadInt(keymapBase + 0xC0) == 1; }
        public static bool KEY_D1
        { get => MMR.ReadInt(keymapBase + 0xC4) == 1; }
        public static bool KEY_D2
        { get => MMR.ReadInt(keymapBase + 0xC8) == 1; }
        public static bool KEY_D3
        { get => MMR.ReadInt(keymapBase + 0xCC) == 1; }
        public static bool KEY_D4
        { get => MMR.ReadInt(keymapBase + 0xD0) == 1; }
        public static bool KEY_D5
        { get => MMR.ReadInt(keymapBase + 0xD4) == 1; }
        public static bool KEY_D6
        { get => MMR.ReadInt(keymapBase + 0xD8) == 1; }
        public static bool KEY_D7
        { get => MMR.ReadInt(keymapBase + 0xDC) == 1; }
        public static bool KEY_D8
        { get => MMR.ReadInt(keymapBase + 0xE0) == 1; }
        public static bool KEY_D9
        { get => MMR.ReadInt(keymapBase + 0xE4) == 1; }
        public static bool KEY_RButton_D8
        { get => MMR.ReadInt(keymapBase + 0xE8) == 1; }
        public static bool KEY_RButton_D9
        { get => MMR.ReadInt(keymapBase + 0xEC) == 1; }
        public static bool KEY_MButton_D8
        { get => MMR.ReadInt(keymapBase + 0xF0) == 1; }
        public static bool KEY_MButton_D9
        { get => MMR.ReadInt(keymapBase + 0xF4) == 1; }
        public static bool KEY_XButton2_D8
        { get => MMR.ReadInt(keymapBase + 0xF8) == 1; }
        public static bool KEY_XButton2_D9
        { get => MMR.ReadInt(keymapBase + 0xFC) == 1; }
        public static bool KEY_64
        { get => MMR.ReadInt(keymapBase + 0x100) == 1; }
        public static bool KEY_A
        { get => MMR.ReadInt(keymapBase + 0x104) == 1; }
        public static bool KEY_B
        { get => MMR.ReadInt(keymapBase + 0x108) == 1; }
        public static bool KEY_C
        { get => MMR.ReadInt(keymapBase + 0x10C) == 1; }
        public static bool KEY_D
        { get => MMR.ReadInt(keymapBase + 0x110) == 1; }
        public static bool KEY_E
        { get => MMR.ReadInt(keymapBase + 0x114) == 1; }
        public static bool KEY_F
        { get => MMR.ReadInt(keymapBase + 0x118) == 1; }
        public static bool KEY_G
        { get => MMR.ReadInt(keymapBase + 0x11C) == 1; }
        public static bool KEY_H
        { get => MMR.ReadInt(keymapBase + 0x120) == 1; }
        public static bool KEY_I
        { get => MMR.ReadInt(keymapBase + 0x124) == 1; }
        public static bool KEY_J
        { get => MMR.ReadInt(keymapBase + 0x128) == 1; }
        public static bool KEY_K
        { get => MMR.ReadInt(keymapBase + 0x12C) == 1; }
        public static bool KEY_L
        { get => MMR.ReadInt(keymapBase + 0x130) == 1; }
        public static bool KEY_M
        { get => MMR.ReadInt(keymapBase + 0x134) == 1; }
        public static bool KEY_N
        { get => MMR.ReadInt(keymapBase + 0x138) == 1; }
        public static bool KEY_O
        { get => MMR.ReadInt(keymapBase + 0x13C) == 1; }
        public static bool KEY_P
        { get => MMR.ReadInt(keymapBase + 0x140) == 1; }
        public static bool KEY_Q
        { get => MMR.ReadInt(keymapBase + 0x144) == 1; }
        public static bool KEY_R
        { get => MMR.ReadInt(keymapBase + 0x148) == 1; }
        public static bool KEY_S
        { get => MMR.ReadInt(keymapBase + 0x14C) == 1; }
        public static bool KEY_T
        { get => MMR.ReadInt(keymapBase + 0x150) == 1; }
        public static bool KEY_U
        { get => MMR.ReadInt(keymapBase + 0x154) == 1; }
        public static bool KEY_V
        { get => MMR.ReadInt(keymapBase + 0x158) == 1; }
        public static bool KEY_W
        { get => MMR.ReadInt(keymapBase + 0x15C) == 1; }
        public static bool KEY_X
        { get => MMR.ReadInt(keymapBase + 0x160) == 1; }
        public static bool KEY_Y
        { get => MMR.ReadInt(keymapBase + 0x164) == 1; }
        public static bool KEY_Z
        { get => MMR.ReadInt(keymapBase + 0x168) == 1; }
        public static bool KEY_LWin
        { get => MMR.ReadInt(keymapBase + 0x16C) == 1; }
        public static bool KEY_RWin
        { get => MMR.ReadInt(keymapBase + 0x170) == 1; }
        public static bool KEY_Apps
        { get => MMR.ReadInt(keymapBase + 0x174) == 1; }
        public static bool KEY_RButton_RWin
        { get => MMR.ReadInt(keymapBase + 0x178) == 1; }
        public static bool KEY_Sleep
        { get => MMR.ReadInt(keymapBase + 0x17C) == 1; }
        public static bool KEY_NumPad0
        { get => MMR.ReadInt(keymapBase + 0x180) == 1; }
        public static bool KEY_NumPad1
        { get => MMR.ReadInt(keymapBase + 0x184) == 1; }
        public static bool KEY_NumPad2
        { get => MMR.ReadInt(keymapBase + 0x188) == 1; }
        public static bool KEY_NumPad3
        { get => MMR.ReadInt(keymapBase + 0x18C) == 1; }
        public static bool KEY_NumPad4
        { get => MMR.ReadInt(keymapBase + 0x190) == 1; }
        public static bool KEY_NumPad5
        { get => MMR.ReadInt(keymapBase + 0x194) == 1; }
        public static bool KEY_NumPad6
        { get => MMR.ReadInt(keymapBase + 0x198) == 1; }
        public static bool KEY_NumPad7
        { get => MMR.ReadInt(keymapBase + 0x19C) == 1; }
        public static bool KEY_NumPad8
        { get => MMR.ReadInt(keymapBase + 0x1A0) == 1; }
        public static bool KEY_NumPad9
        { get => MMR.ReadInt(keymapBase + 0x1A4) == 1; }
        public static bool KEY_Multiply
        { get => MMR.ReadInt(keymapBase + 0x1A8) == 1; }
        public static bool KEY_Add
        { get => MMR.ReadInt(keymapBase + 0x1AC) == 1; }
        public static bool KEY_Separator
        { get => MMR.ReadInt(keymapBase + 0x1B0) == 1; }
        public static bool KEY_Subtract
        { get => MMR.ReadInt(keymapBase + 0x1B4) == 1; }
        public static bool KEY_Decimal
        { get => MMR.ReadInt(keymapBase + 0x1B8) == 1; }
        public static bool KEY_Divide
        { get => MMR.ReadInt(keymapBase + 0x1BC) == 1; }
        public static bool KEY_F1
        { get => MMR.ReadInt(keymapBase + 0x1C0) == 1; }
        public static bool KEY_F2
        { get => MMR.ReadInt(keymapBase + 0x1C4) == 1; }
        public static bool KEY_F3
        { get => MMR.ReadInt(keymapBase + 0x1C8) == 1; }
        public static bool KEY_F4
        { get => MMR.ReadInt(keymapBase + 0x1CC) == 1; }
        public static bool KEY_F5
        { get => MMR.ReadInt(keymapBase + 0x1D0) == 1; }
        public static bool KEY_F6
        { get => MMR.ReadInt(keymapBase + 0x1D4) == 1; }
        public static bool KEY_F7
        { get => MMR.ReadInt(keymapBase + 0x1D8) == 1; }
        public static bool KEY_F8
        { get => MMR.ReadInt(keymapBase + 0x1DC) == 1; }
        public static bool KEY_F9
        { get => MMR.ReadInt(keymapBase + 0x1E0) == 1; }
        public static bool KEY_F10
        { get => MMR.ReadInt(keymapBase + 0x1E4) == 1; }
        public static bool KEY_F11
        { get => MMR.ReadInt(keymapBase + 0x1E8) == 1; }
        public static bool KEY_F12
        { get => MMR.ReadInt(keymapBase + 0x1EC) == 1; }
        public static bool KEY_F13
        { get => MMR.ReadInt(keymapBase + 0x1F0) == 1; }
        public static bool KEY_F14
        { get => MMR.ReadInt(keymapBase + 0x1F4) == 1; }
        public static bool KEY_F15
        { get => MMR.ReadInt(keymapBase + 0x1F8) == 1; }
        public static bool KEY_F16
        { get => MMR.ReadInt(keymapBase + 0x1FC) == 1; }
        public static bool KEY_F17
        { get => MMR.ReadInt(keymapBase + 0x200) == 1; }
        public static bool KEY_F18
        { get => MMR.ReadInt(keymapBase + 0x204) == 1; }
        public static bool KEY_F19
        { get => MMR.ReadInt(keymapBase + 0x208) == 1; }
        public static bool KEY_F20
        { get => MMR.ReadInt(keymapBase + 0x20C) == 1; }
        public static bool KEY_F21
        { get => MMR.ReadInt(keymapBase + 0x210) == 1; }
        public static bool KEY_F22
        { get => MMR.ReadInt(keymapBase + 0x214) == 1; }
        public static bool KEY_F23
        { get => MMR.ReadInt(keymapBase + 0x218) == 1; }
        public static bool KEY_F24
        { get => MMR.ReadInt(keymapBase + 0x21C) == 1; }
        public static bool KEY_Back_F17
        { get => MMR.ReadInt(keymapBase + 0x220) == 1; }
        public static bool KEY_Back_F18
        { get => MMR.ReadInt(keymapBase + 0x224) == 1; }
        public static bool KEY_Back_F19
        { get => MMR.ReadInt(keymapBase + 0x228) == 1; }
        public static bool KEY_Back_F20
        { get => MMR.ReadInt(keymapBase + 0x22C) == 1; }
        public static bool KEY_Back_F21
        { get => MMR.ReadInt(keymapBase + 0x230) == 1; }
        public static bool KEY_Back_F22
        { get => MMR.ReadInt(keymapBase + 0x234) == 1; }
        public static bool KEY_Back_F23
        { get => MMR.ReadInt(keymapBase + 0x238) == 1; }
        public static bool KEY_Back_F24
        { get => MMR.ReadInt(keymapBase + 0x23C) == 1; }
        public static bool KEY_NumLock
        { get => MMR.ReadInt(keymapBase + 0x240) == 1; }
        public static bool KEY_Scroll
        { get => MMR.ReadInt(keymapBase + 0x244) == 1; }
        public static bool KEY_RButton_NumLock
        { get => MMR.ReadInt(keymapBase + 0x248) == 1; }
        public static bool KEY_RButton_Scroll
        { get => MMR.ReadInt(keymapBase + 0x24C) == 1; }
        public static bool KEY_MButton_NumLock
        { get => MMR.ReadInt(keymapBase + 0x250) == 1; }
        public static bool KEY_MButton_Scroll
        { get => MMR.ReadInt(keymapBase + 0x254) == 1; }
        public static bool KEY_XButton2_NumLock
        { get => MMR.ReadInt(keymapBase + 0x258) == 1; }
        public static bool KEY_XButton2_Scroll
        { get => MMR.ReadInt(keymapBase + 0x25C) == 1; }
        public static bool KEY_Back_NumLock
        { get => MMR.ReadInt(keymapBase + 0x260) == 1; }
        public static bool KEY_Back_Scroll
        { get => MMR.ReadInt(keymapBase + 0x264) == 1; }
        public static bool KEY_LineFeed_NumLock
        { get => MMR.ReadInt(keymapBase + 0x268) == 1; }
        public static bool KEY_LineFeed_Scroll
        { get => MMR.ReadInt(keymapBase + 0x26C) == 1; }
        public static bool KEY_Clear_NumLock
        { get => MMR.ReadInt(keymapBase + 0x270) == 1; }
        public static bool KEY_Clear_Scroll
        { get => MMR.ReadInt(keymapBase + 0x274) == 1; }
        public static bool KEY_RButton_Clear_NumLock
        { get => MMR.ReadInt(keymapBase + 0x278) == 1; }
        public static bool KEY_RButton_Clear_Scroll
        { get => MMR.ReadInt(keymapBase + 0x27C) == 1; }
        public static bool KEY_LShiftKey
        { get => MMR.ReadInt(keymapBase + 0x280) == 1; }
        public static bool KEY_RShiftKey
        { get => MMR.ReadInt(keymapBase + 0x284) == 1; }
        public static bool KEY_LControlKey
        { get => MMR.ReadInt(keymapBase + 0x288) == 1; }
        public static bool KEY_RControlKey
        { get => MMR.ReadInt(keymapBase + 0x28C) == 1; }
        public static bool KEY_LMenu
        { get => MMR.ReadInt(keymapBase + 0x290) == 1; }
        public static bool KEY_RMenu
        { get => MMR.ReadInt(keymapBase + 0x294) == 1; }
        public static bool KEY_BrowserBack
        { get => MMR.ReadInt(keymapBase + 0x298) == 1; }
        public static bool KEY_BrowserForward
        { get => MMR.ReadInt(keymapBase + 0x29C) == 1; }
        public static bool KEY_BrowserRefresh
        { get => MMR.ReadInt(keymapBase + 0x2A0) == 1; }
        public static bool KEY_BrowserStop
        { get => MMR.ReadInt(keymapBase + 0x2A4) == 1; }
        public static bool KEY_BrowserSearch
        { get => MMR.ReadInt(keymapBase + 0x2A8) == 1; }
        public static bool KEY_BrowserFavorites
        { get => MMR.ReadInt(keymapBase + 0x2AC) == 1; }
        public static bool KEY_BrowserHome
        { get => MMR.ReadInt(keymapBase + 0x2B0) == 1; }
        public static bool KEY_VolumeMute
        { get => MMR.ReadInt(keymapBase + 0x2B4) == 1; }
        public static bool KEY_VolumeDown
        { get => MMR.ReadInt(keymapBase + 0x2B8) == 1; }
        public static bool KEY_VolumeUp
        { get => MMR.ReadInt(keymapBase + 0x2BC) == 1; }
        public static bool KEY_MediaNextTrack
        { get => MMR.ReadInt(keymapBase + 0x2C0) == 1; }
        public static bool KEY_MediaPreviousTrack
        { get => MMR.ReadInt(keymapBase + 0x2C4) == 1; }
        public static bool KEY_MediaStop
        { get => MMR.ReadInt(keymapBase + 0x2C8) == 1; }
        public static bool KEY_MediaPlayPause
        { get => MMR.ReadInt(keymapBase + 0x2CC) == 1; }
        public static bool KEY_LaunchMail
        { get => MMR.ReadInt(keymapBase + 0x2D0) == 1; }
        public static bool KEY_SelectMedia
        { get => MMR.ReadInt(keymapBase + 0x2D4) == 1; }
        public static bool KEY_LaunchApplication1
        { get => MMR.ReadInt(keymapBase + 0x2D8) == 1; }
        public static bool KEY_LaunchApplication2
        { get => MMR.ReadInt(keymapBase + 0x2DC) == 1; }
        public static bool KEY_Back_MediaNextTrack
        { get => MMR.ReadInt(keymapBase + 0x2E0) == 1; }
        public static bool KEY_Back_MediaPreviousTrack
        { get => MMR.ReadInt(keymapBase + 0x2E4) == 1; }
        public static bool KEY_Oem1
        { get => MMR.ReadInt(keymapBase + 0x2E8) == 1; }
        public static bool KEY_Oemplus
        { get => MMR.ReadInt(keymapBase + 0x2EC) == 1; }
        public static bool KEY_Oemcomma
        { get => MMR.ReadInt(keymapBase + 0x2F0) == 1; }
        public static bool KEY_OemMinus
        { get => MMR.ReadInt(keymapBase + 0x2F4) == 1; }
        public static bool KEY_OemPeriod
        { get => MMR.ReadInt(keymapBase + 0x2F8) == 1; }
        public static bool KEY_OemQuestion
        { get => MMR.ReadInt(keymapBase + 0x2FC) == 1; }
        public static bool KEY_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x300) == 1; }
        public static bool KEY_LButton_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x304) == 1; }
        public static bool KEY_RButton_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x308) == 1; }
        public static bool KEY_Cancel_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x30C) == 1; }
        public static bool KEY_MButton_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x310) == 1; }
        public static bool KEY_XButton1_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x314) == 1; }
        public static bool KEY_XButton2_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x318) == 1; }
        public static bool KEY_LButton_XButton2_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x31C) == 1; }
        public static bool KEY_Back_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x320) == 1; }
        public static bool KEY_Tab_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x324) == 1; }
        public static bool KEY_LineFeed_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x328) == 1; }
        public static bool KEY_LButton_LineFeed_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x32C) == 1; }
        public static bool KEY_Clear_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x330) == 1; }
        public static bool KEY_Return_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x334) == 1; }
        public static bool KEY_RButton_Clear_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x338) == 1; }
        public static bool KEY_RButton_Return_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x33C) == 1; }
        public static bool KEY_ShiftKey_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x340) == 1; }
        public static bool KEY_ControlKey_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x344) == 1; }
        public static bool KEY_Menu_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x348) == 1; }
        public static bool KEY_Pause_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x34C) == 1; }
        public static bool KEY_Capital_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x350) == 1; }
        public static bool KEY_KanaMode_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x354) == 1; }
        public static bool KEY_RButton_Capital_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x358) == 1; }
        public static bool KEY_JunjaMode_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x35C) == 1; }
        public static bool KEY_FinalMode_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x360) == 1; }
        public static bool KEY_HanjaMode_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x364) == 1; }
        public static bool KEY_RButton_FinalMode_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x368) == 1; }
        public static bool KEY_OemOpenBrackets
        { get => MMR.ReadInt(keymapBase + 0x36C) == 1; }
        public static bool KEY_Oem5
        { get => MMR.ReadInt(keymapBase + 0x370) == 1; }
        public static bool KEY_Oem6
        { get => MMR.ReadInt(keymapBase + 0x374) == 1; }
        public static bool KEY_Oem7
        { get => MMR.ReadInt(keymapBase + 0x378) == 1; }
        public static bool KEY_Oem8
        { get => MMR.ReadInt(keymapBase + 0x37C) == 1; }
        public static bool KEY_Space_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x380) == 1; }
        public static bool KEY_PageUp_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x384) == 1; }
        public static bool KEY_OemBackslash
        { get => MMR.ReadInt(keymapBase + 0x388) == 1; }
        public static bool KEY_LButton_OemBackslash
        { get => MMR.ReadInt(keymapBase + 0x38C) == 1; }
        public static bool KEY_Home_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x390) == 1; }
        public static bool KEY_ProcessKey
        { get => MMR.ReadInt(keymapBase + 0x394) == 1; }
        public static bool KEY_MButton_OemBackslash
        { get => MMR.ReadInt(keymapBase + 0x398) == 1; }
        public static bool KEY_Packet
        { get => MMR.ReadInt(keymapBase + 0x39C) == 1; }
        public static bool KEY_Down_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x3A0) == 1; }
        public static bool KEY_Select_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x3A4) == 1; }
        public static bool KEY_Back_OemBackslash
        { get => MMR.ReadInt(keymapBase + 0x3A8) == 1; }
        public static bool KEY_Tab_OemBackslash
        { get => MMR.ReadInt(keymapBase + 0x3AC) == 1; }
        public static bool KEY_PrintScreen_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x3B0) == 1; }
        public static bool KEY_Back_ProcessKey
        { get => MMR.ReadInt(keymapBase + 0x3B4) == 1; }
        public static bool KEY_Clear_OemBackslash
        { get => MMR.ReadInt(keymapBase + 0x3B8) == 1; }
        public static bool KEY_Back_Packet
        { get => MMR.ReadInt(keymapBase + 0x3BC) == 1; }
        public static bool KEY_D0_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x3C0) == 1; }
        public static bool KEY_D1_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x3C4) == 1; }
        public static bool KEY_ShiftKey_OemBackslash
        { get => MMR.ReadInt(keymapBase + 0x3C8) == 1; }
        public static bool KEY_ControlKey_OemBackslash
        { get => MMR.ReadInt(keymapBase + 0x3CC) == 1; }
        public static bool KEY_D4_Oemtilde
        { get => MMR.ReadInt(keymapBase + 0x3D0) == 1; }
        public static bool KEY_ShiftKey_ProcessKey
        { get => MMR.ReadInt(keymapBase + 0x3D4) == 1; }
        public static bool KEY_Attn
        { get => MMR.ReadInt(keymapBase + 0x3D8) == 1; }
        public static bool KEY_Crsel
        { get => MMR.ReadInt(keymapBase + 0x3DC) == 1; }
        public static bool KEY_Exsel
        { get => MMR.ReadInt(keymapBase + 0x3E0) == 1; }
        public static bool KEY_EraseEof
        { get => MMR.ReadInt(keymapBase + 0x3E4) == 1; }
        public static bool KEY_Play
        { get => MMR.ReadInt(keymapBase + 0x3E8) == 1; }
        public static bool KEY_Zoom
        { get => MMR.ReadInt(keymapBase + 0x3EC) == 1; }
        public static bool KEY_NoName
        { get => MMR.ReadInt(keymapBase + 0x3F0) == 1; }
        public static bool KEY_Pa1
        { get => MMR.ReadInt(keymapBase + 0x3F4) == 1; }
        public static bool KEY_OemClear
        { get => MMR.ReadInt(keymapBase + 0x3F8) == 1; }
    }
}
