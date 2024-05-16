using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinGui.FileTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinGui.Utils
{
    internal class NameChange
    {

        // Rename all characters
        // Returns an error string, or "" for "no error"
        public static string DoRename()
        {
            // Set up our foundation.
            AllowRename();

            // Actually do the rename
            var entries = new Dictionary<string, string>()
            {
                { "Bartz", "MSG_CHAR_NAME_01" },
                { "Lenna", "MSG_CHAR_NAME_02" },
                { "Galuf", "MSG_CHAR_NAME_03" },
                { "Faris", "MSG_CHAR_NAME_04" },
                { "Krile", "MSG_CHAR_NAME_05" },
                { "King Tycoon", "MSG_CHAR_NAME_07" },
                { "Gilgamesh", "MSG_CHAR_NAME_08" },
                { "Exdeath", "MSG_CHAR_NAME_09" },
            };
            foreach (var entry in entries) {
                string repName = Config.CharaName(entry.Key);
                if (repName.Length > 0)
                {
                    Assets.system.ChangeString(entry.Value, repName);
                }
            }

            return "";
        }


        // Some scaffolding to allow renaming in the first place
        private static void AllowRename()
        {
            // First, Create 'default name' entries --these actually allow you to use
            //  (LENNA) to refer to Lenna in various texts.
            // NOTE: These do NOT have to be added to system.txt
            CsvAsset chNames = Assets.character_default_names;
            chNames.AddEntry(new Dictionary<string, string>{
                { "id" , "3" },
                { "character_id" , "2" },
                { "tag_name" , "LENNA" },
                { "mes_id_name" , "MSG_CHAR_NAME_02" },
            });
            chNames.AddEntry(new Dictionary<string, string>{
                { "id" , "4" },
                { "character_id" , "3" },
                { "tag_name" , "GALUF" },
                { "mes_id_name" , "MSG_CHAR_NAME_03" },
            });
            chNames.AddEntry(new Dictionary<string, string>{
                { "id" , "5" },
                { "character_id" , "4" },
                { "tag_name" , "FARIS" },
                { "mes_id_name" , "MSG_CHAR_NAME_04" },
            });
            chNames.AddEntry(new Dictionary<string, string>{
                { "id" , "6" },
                { "character_id" , "5" },
                { "tag_name" , "KRILE" },
                { "mes_id_name" , "MSG_CHAR_NAME_05" },
            });

            // Let's cheat a bit and change a few more names!
            // NOTE: I don't *THINK* we need to actually *create* a character 7 for this to work...
            // NOTE NOTE: We could actually just do a direct string substitution, but I like the extra layer of indirection!
            chNames.AddEntry(new Dictionary<string, string>{
                { "id" , "7" },
                { "character_id" , "6" },
                { "tag_name" , "KING TYCOON" },
                { "mes_id_name" , "MSG_CHAR_NAME_07" },
            });
            chNames.AddEntry(new Dictionary<string, string>{
                { "id" , "8" },
                { "character_id" , "7" },
                { "tag_name" , "GILGAMESH" },
                { "mes_id_name" , "MSG_CHAR_NAME_08" },
            });
            chNames.AddEntry(new Dictionary<string, string>{
                { "id" , "9" },
                { "character_id" , "8" },
                { "tag_name" , "EXDEATH" },
                { "mes_id_name" , "MSG_CHAR_NAME_09" },
            });

            // The "bonus" characters must be *added* to system.txt
            Assets.system.AddString("MSG_CHAR_NAME_07", "King Tycoon");
            Assets.system.AddString("MSG_CHAR_NAME_08", "Gilgamesh");
            Assets.system.AddString("MSG_CHAR_NAME_09", "Exdeath");

            // Next, replace all instances of 'Lenna', 'Galuf', etc., in nameplates.
            // We'll call out messages we DON'T want to modify (if any)
            var names_map = new Dictionary<string, string>{
                { "Lenna" , "(LENNA)" },
                { "Galuf" , "(GALUF)" },
                { "Faris" , "(FARIS)" },
                { "Krile" , "(KRILE)" },
                { "King Tycoon" , "(KING TYCOON)" },
                { "Gilgamesh" , "(GILGAMESH)" },
                { "Exdeath" , "(EXDEATH)" },
            };

            // e.g., 'E0001_00_071_a_01' -> 1  ; as we find things that don't work
            var banned_msgs = new Dictionary<string, string> { };

            // Iterate over all our 'message'-related files.
            foreach (StringsAsset file in new List<StringsAsset> { Assets.system, Assets.story_cha, Assets.story_msg })
            {
                foreach (string key in file.GetKeys())
                {
                    if (!banned_msgs.ContainsKey(key))
                    {
                        string newValue = file.GetValue(key);
                        foreach (var entry in names_map)
                        {
                            newValue = newValue.Replace(entry.Key, entry.Value);
                        }
                        file.ChangeString(key, newValue);
                    }
                }
            }
        }

    }
}
