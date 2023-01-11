namespace MemoryReaderExample
{
    // Generated using using ObsidianMapper v1.0 by yeemi#9764
    // Under the GNU License
    public class Keymap
    {
        public static long keymapBase = 0x48E0940;

        public static bool KEY_W
        { get => MMR.ReadMemory<bool>(keymapBase + (4 * 'W')); }
    }
}
