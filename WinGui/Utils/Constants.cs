using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGui.Utils
{
    // Helper class for storing something in a ComboBox, but displaying something else entirely.
    internal class TextAndValue
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public TextAndValue(string value)
        {
            Text = ">>"; // Dfeault
            Value = value;
        }

        // Only display the "Text"
        public override string ToString()
        {
            return Text;
        }

        // Needed for accurate comparison
        // Only compare the "value"
        public override bool Equals(object? obj)
        {
            if (obj != null && obj is TextAndValue)
            {
                return Value.Equals(((TextAndValue)obj).Value); 
            }
            return false;
        }
    }

    // Contains constant values
    internal class Constants
    {
        //
        // NOTE: Make sure you call "ConvertPath()" before using them (not in some static place),
        //       since someone *could* change their Steam directory settings halfway through using the program.
        //

        // Backup frames for rendering:
        //   If <K> is not present, try using frame/anim <V> instead.
        public static Dictionary<string, string> BackupFrames = new Dictionary<string, string>
        {
            // Bartz, Lenna, Galuf, and our custom charas only
            { "Bind_00" , "Default_00" },
            { "Bind_01" , "Default_01" },

            // Faris only
            { "Hair_00" , "Default_00" },
            { "Hair_01" , "Default_00" },
            { "Special_00" , "LookDown_00" },
            { "Special_01" , "LookRight_00" },

            // Exdeath only
            { "Down_00" , "DownL_00" },

            // King Tycoon only
            { "Crouch_00" , "LookDown_00" },   // Not sure what these are used for
            { "LookDown_01" , "LookDown_00" }, // Same
            { "LookDown_02" , "LookDown_00" }, // Same
        };

        // Export directory
        public static string MagiciteExportDir = Path.Join("FINAL FANTASY V_Data", "StreamingAssets", "MagiciteExport");

        // Where to "export" the converted files to
        public static string MagiciteImportDir = Path.Join("FINAL FANTASY V_Data", "StreamingAssets", "Magicite");
        public static string WGRPGImportDir = Path.Join(MagiciteImportDir, "WGRPG");

        // Names of sprites
        // TODO: Moved to "Assets"
        //public static List<string> SpriteNames = new List<string> { "Bartz", "Lenna", "Galuf", "Faris", "Krile", "Andrew", "Josh", "Mark", "Chris", "Seth", "Nathan" };

        // CSV: Character_Default_Names
        public static string CsvCharaDefaultNames = "master/Assets/GameAssets/Serial/Data/Master/character_default_name.csv";

        // STR: System.txt
        public static string StrSystem = "message/Assets/GameAssets/Serial/Data/Message/system_en.txt";

        // STR: StoryCha.txt
        public static string StrStoryCha = "message/Assets/GameAssets/Serial/Data/Message/story_cha_en.txt";

        // STR: StoryMsg.txt
        public static string StrStoryMsg = "message/Assets/GameAssets/Serial/Data/Message/story_mes_en.txt";

    }
}
