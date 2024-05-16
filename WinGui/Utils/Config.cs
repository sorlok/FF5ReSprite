using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinGui.Utils
{
    // Class that holds and auto-saves various properties to config.json
    internal class Config
    {
        // Where to save the file
        private const string Path = "config.json";

        // The current config.
        private static Config? _instance = null;

        // Enforce the singleton.
        private Config(Dictionary<string, string> data) {
            this.data = data;
        }

        // All properties are saved in this lookup, to make saving/loading easier.
        private Dictionary<string, string> data = new Dictionary<string, string>();

        // Read from json, or create a new object
        // External users should just call, e.g., SteamGameDir() and SetSteamGameDir()
        private static Config Get()
        {
            if (_instance  == null)
            {
                if (File.Exists(Path))
                {
                    string jsonString = File.ReadAllText(Path);
                    Dictionary <string, string>? data = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                    if (data != null)
                    {
                        _instance = new Config(data);
                        Console.WriteLine("CONFIG: Deserialization successful");
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Could not load config from: " + Path);
                        _instance = new Config(new Dictionary<string, string>());
                    }
                }
                else
                {
                    _instance = new Config(new Dictionary<string, string>());
                    Console.WriteLine("CONFIG: Made a new file");
                }
            }
            return _instance;
        }

        // Save to disk; called whenever a property changes.
        private static void Save()
        {
            if (_instance != null)
            {
                string jsonString = JsonSerializer.Serialize(_instance.data);
                File.WriteAllText(Path, jsonString);
            } 
            else
            {
                Console.WriteLine("Could not save to JSON; instance is null");
            }
        }

        // Generic Get/Set, used internally.
        private string GenericGet(string key)
        {
            if (data.ContainsKey(key))
            {
                return data[key];
            }
            return "";
        }
        private void GenericSet(string key, string value)
        {
            data[key] = value;
            Save();
        }

        // Get/set Steam game directory
        public static string SteamGameDir()
        {
            return Get().GenericGet("steam_game_dir");
        }
        public static void SetSteamGameDir(string value)
        {
            Get().GenericSet("steam_game_dir", value);
        }

        // Get/set the name of a given character
        public static string CharaName(string chara)
        {
            return Get().GenericGet("Chara_" + chara);
        }
        public static void SetCharaName(string chara, string value)
        {
            Get().GenericSet("Chara_" + chara, value);
        }

        // Get/set the sprite for a given character
        public static string SpriteName(string chara)
        {
            return Get().GenericGet("Sprite_" + chara);
        }
        public static void SetSpriteName(string chara, string value)
        {
            Get().GenericSet("Sprite_" + chara, value);
        }


    }
}

