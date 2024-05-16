using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WinGui.Utils;

namespace WinGui.FileTypes
{
    // Class that holds a "chara" sprite, along with some useful properties
    internal class CharaSprite
    {
        public CharaSprite() { }

        public string imagePath = "";  // You MUST call "ConvertPath()" on this before using it.
        public string spriteType = ""; // TODO: currently only supports full-anim charas
        public int sortIndex = 9999;   // Consistent order for sprites to appear in (in the combo box). Tying is allowed.

        // Our animation frames, indexed by frame name
        public Dictionary<string, Rectangle> animFrames = new();
    }

    // Central class which loads/stores all assets
    internal class Assets
    {
        // Our actual assets
        public static CsvAsset? character_default_names;
        public static StringsAsset? system;
        public static StringsAsset? story_cha;
        public static StringsAsset? story_msg;

        // Ordered list of all character sprites.
        // Use this to iterate through "chara_sprites" in a fixed order.
        // NOTE: This list may include sprites you should not add to your ComboBox. I.e., "Exdeath"'s sprite can't be used for "Barz", since it only has a few frames.
        public static List<string> sprite_names_ordered; // = new List<string> { "Bartz", "Lenna", "Galuf", "Faris", "Krile", "Andrew", "Josh", "Mark", "Chris", "Seth", "Nathan" };

        // Our characters' frame data
        // e.g., "Bartz" -> "Walk_00" -> { Rect }
        public static Dictionary<string, CharaSprite>? chara_sprites;

        // Helper: Clear and create the WGRPG output directory
        public static void MakeWGRPGDir()
        {
            // First, delete it.
            string targetDir = Path.Join(Config.SteamGameDir(), Constants.WGRPGImportDir);
            Console.WriteLine("Re-creating: " + targetDir);
            if (Directory.Exists(targetDir))
            {
                Form1.DeleteDirectory(targetDir);
            }

            // Now, create it
            // (We kind of have to cheat with paths here)
            string parentDir = Path.Join(Config.SteamGameDir(), Constants.MagiciteImportDir);
            if (!Directory.Exists(parentDir)) {
                Directory.CreateDirectory(parentDir);
            }
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }
        }

        // We need to import via "key" files, but for a small project like this
        // it's easier to just copy what's there already.
        public static void CloneSrcDirs()
        {
            var toCopy = new List<String>
            {
                "master",
                "message",
                "mo_ff5_p001_c00",
                "mo_ff5_p002_c00",
                "mo_ff5_p003_c00",
                "mo_ff5_p004_c00",
                "mo_ff5_p005_c00",
                "mo_ff5_n012_c00",
                "mo_ff5_n002_c00",
                "mo_ff5_n001_c00",
            };

            Console.WriteLine("COPYING: [" + String.Join(",", toCopy) + "] from: " + Constants.MagiciteExportDir + " to: " + Constants.WGRPGImportDir + " within: " + Config.SteamGameDir());
            foreach (String dir in toCopy) {
                string srcDir = Path.Join(Config.SteamGameDir(), Constants.MagiciteExportDir, dir);
                string dstDir = Path.Join(Config.SteamGameDir(), Constants.WGRPGImportDir, dir);
                Form1.CopyDirRecursively(new DirectoryInfo(srcDir), new DirectoryInfo(dstDir));
            }
        }

        // Called whenever the Steam path is set to load our character frames.
        // These are loaded from their own custom JSON format
        public static void LoadCharaFrames()
        {
            // Kind of an anomaly
            loadCharaFrames();
            loadCustomExtras();

            // Produce a complete list.
            var tempList = new List<Tuple<string, int>>();
            foreach (var entry in chara_sprites)
            {
                tempList.Add(new Tuple<string, int>(entry.Key, entry.Value.sortIndex));
            }

            // Now sort with our custom comparator.
            tempList = tempList.OrderBy(
                entry => entry.Item2
            ).ThenBy(
                entry => entry.Item1
            ).ToList();

            // ...and save it.
            // (I bet I could make this more succinct if I knew Linq...)
            sprite_names_ordered = new List<string>();
            foreach (var entry in tempList)
            {
                sprite_names_ordered.Add(entry.Item1);
            }
        }

        // Call at the start of a run to load all assets.
        public static void LoadAll()
        {
            character_default_names = new CsvAsset(
                Assets.ConvertPath("%STEAM_EXPORT_DIR%" + Constants.CsvCharaDefaultNames),
                Assets.ConvertPath("%STEAM_IMPORT_DIR%" + Constants.CsvCharaDefaultNames)
            );
            system = new StringsAsset(
                Assets.ConvertPath("%STEAM_EXPORT_DIR%" + Constants.StrSystem),
                Assets.ConvertPath("%STEAM_IMPORT_DIR%" + Constants.StrSystem)
            );
            story_cha = new StringsAsset(
                Assets.ConvertPath("%STEAM_EXPORT_DIR%" + Constants.StrStoryCha),
                Assets.ConvertPath("%STEAM_IMPORT_DIR%" + Constants.StrStoryCha)
            );
            story_msg = new StringsAsset(
                Assets.ConvertPath("%STEAM_EXPORT_DIR%" + Constants.StrStoryMsg),
                Assets.ConvertPath("%STEAM_IMPORT_DIR%" + Constants.StrStoryMsg)
            );
        }

        // Call at the end of a run to save all assets to their new paths.
        public static void SaveAll()
        {
            character_default_names?.Write();
            system?.Write();
            story_cha?.Write();
            story_msg?.Write();
        }


        // Helper: Convert a path as follows:
        //   1) "/" becomes "Path.Join()"
        //   2) %STEAM_EXPORT_DIR% is replaced with the MagiciteExportDir
        //   3) %APP_DIR% is replace by either "." or something like "../../../" to help when running from the editor.
        //   4) %STEAM_GAME_DIR% is replaced with SteamGameDir
        //   5) %STEAM_IMPORT_DIR% is replaced with WGRPGImportDir
        // The magic vars only take effect if they are at the start of the string, to make this a little saner to debug.
        public static string ConvertPath(string path)
        {
            // Special 
            if (path.StartsWith("%STEAM_GAME_DIR%"))
            {
                path = Path.Join(Config.SteamGameDir(), path.Substring("%STEAM_GAME_DIR%".Length));
            }
            else if (path.StartsWith("%STEAM_EXPORT_DIR%"))
            {
                path = Path.Join(Config.SteamGameDir(), Constants.MagiciteExportDir, path.Substring("%STEAM_EXPORT_DIR%".Length));
            }
            else if (path.StartsWith("%STEAM_IMPORT_DIR%"))
            {
                path = Path.Join(Config.SteamGameDir(), Constants.WGRPGImportDir, path.Substring("%STEAM_IMPORT_DIR%".Length));
            }
            else if(path.StartsWith("%APP_DIR%"))
            {
                path = path.Substring("%APP_DIR%".Length);

                if (Directory.Exists("in"))
                {
                    path = "." + path;
                }
                else
                {
                    path = "../../../.." + path;
                }
            }

            // Path.Join()
            string[] parts = path.Split("/");
            return Path.Join(parts);
        }


        private static void loadCharaFrames()
        {
            // Check
            string srcFile = ConvertPath("%APP_DIR%/in/chara_frames.json");
            if (!File.Exists(srcFile))
            {
                Console.WriteLine("ERROR: File does not exist: " + srcFile);
                throw new Exception("Missing file");
            }

            // Read json
            string jsonString = File.ReadAllText(srcFile);
            Dictionary<string, Dictionary<string, string>>? data = JsonSerializer.Deserialize< Dictionary<string, Dictionary<string, string>> >(jsonString);
            if (data == null)
            {
                Console.WriteLine("ERROR: Couldn't read file: " + srcFile);
                throw new Exception("Bad file");
            }

            // Convert
            chara_sprites = new Dictionary<string, CharaSprite>();
            foreach (var charObj in data)
            {
                chara_sprites[charObj.Key] = new CharaSprite();
                foreach (var anim in charObj.Value)
                {
                    // Special properties
                    if (anim.Key.StartsWith("@"))
                    {
                        if (anim.Key == "@Image")
                        {
                            chara_sprites[charObj.Key].imagePath = anim.Value;
                        }
                        else if (anim.Key == "@Type")
                        {
                            chara_sprites[charObj.Key].spriteType = anim.Value;
                        }
                        else if (anim.Key == "@SortIndex")
                        {
                            chara_sprites[charObj.Key].sortIndex = Int32.Parse(anim.Value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid special property: " + anim.Key);
                            throw new Exception("Bad special property");
                        }
                        continue;
                    }

                    // Otherwise, it's an animation frame
                    string[] rectStr = anim.Value.Split(",");
                    if (rectStr.Length != 4)
                    {
                        Console.WriteLine("ERROR: Bad rectangle: " + anim.Value);
                        throw new Exception("Bad rectangle");
                    }
                    chara_sprites[charObj.Key].animFrames[anim.Key] = new Rectangle(Int32.Parse(rectStr[0]), Int32.Parse(rectStr[1]), Int32.Parse(rectStr[2]), Int32.Parse(rectStr[3]));
                }
            }
        }

        // Loads anything named "Custom_<Name>" in the "sprites" directory, and uses the same anim layout as "Andrew"
        private static void loadCustomExtras()
        {
            CharaSprite templateChara = chara_sprites["Andrew"];

            // Check for files
            string[] files = Directory.GetFiles(ConvertPath("%APP_DIR%/sprites"));
            foreach (string filePath in files)
            {
                // Accept any capitalization
                string fName = Path.GetFileNameWithoutExtension(filePath);
                if (fName.ToLower().StartsWith("custom_"))
                {
                    // Get a name for the sprite
                    string sprName = fName.Substring("Custom_".Length);
                    if (chara_sprites.ContainsKey(sprName))
                    {
                        Console.WriteLine("ERROR: A Sprite already exists with the name: " + sprName);
                        continue;
                    }

                    // Add it, with some assumptions
                    CharaSprite resSprite = new CharaSprite();
                    resSprite.imagePath = filePath;
                    resSprite.spriteType = templateChara.spriteType;
                    resSprite.sortIndex = 100; // Let this revert to alphabetical sorting.
                    resSprite.animFrames = new Dictionary<string, Rectangle>(templateChara.animFrames); // Clone

                    chara_sprites[sprName] = resSprite;
                }
            }
        }



    }
}
