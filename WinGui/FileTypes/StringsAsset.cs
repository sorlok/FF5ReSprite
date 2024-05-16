using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGui.FileTypes
{
    // Class that saves/loads a file in FF5's <key>-tab-<value> string format
    internal class StringsAsset
    {
        // List of keys, in order, to preserve order when printing
        private List<string> keys = new();

        // (key, value) entries
        private Dictionary<string, string> data = new();

        // Where to save this file when we're done with it
        private readonly string outPath;

        public StringsAsset(string inPath, string outPath)
        {
            // Save for later
            this.outPath = outPath;

            // Read input
            using FileStream inFile = File.OpenRead(inPath);
            using StreamReader strReader = new(inFile, Encoding.UTF8, true, 1024 * 1024);

            string? line;
            while ((line = strReader.ReadLine()) != null)
            {
                // Handle empty lines
                line = line.Trim(['\r', '\n']);
                if (line.Length == 0)
                {
                    continue;
                }

                // Split off our key
                string[] parts = line.Split('\t', 2);

                // Quite simple, but we also check for duplicates
                if (parts.Length != 2)
                {
                    throw new Exception("Invalid line, should be two parts: " + line);
                }
                if (this.data.ContainsKey(parts[0]) && parts[1] != this.data[parts[0]])
                {
                    // Note: The end-game letter is... weird.
                    throw new Exception("Invalid line, key already exists: " + line);
                }

                // Save it
                this.data[parts[0]] = parts[1];
                this.keys.Add(parts[0]);
            }
        }

        // Save to disk
        public void Write()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(this.outPath));
            using FileStream outFile = File.Open(this.outPath, FileMode.Create); // This should truncate by default.
            using StreamWriter strWriter = new(outFile, new UTF8Encoding(false), 1024*1024);

            // Write in order
            foreach (string key in this.keys)
            {
                string value = this.data[key];
                strWriter.WriteLine(key + "\t" + value);
            }

            // Seems like these might have an extra line at the end?
            strWriter.WriteLine();

            Console.WriteLine("Wrote: " + this.outPath);
        }

        // Retrieve a list of keys
        public List<string> GetKeys()
        {
            return this.keys;
        }

        // Retrieve the value for the given key
        public string GetValue(string key)
        {
            return this.data[key];
        }

        // Add a new entry
        public void AddString(string key, string val)
        {
            // Make sure we're not clobbering any existing entry
            if (this.data.ContainsKey(key))
            {
                throw new Exception("String key already exists: " + key);
            }

            // Add it
            this.data[key] = val;
            this.keys.Add(key);
        }

        // Change an existing entry
        public void ChangeString(string key, string newVal)
        {
            if (!this.data.ContainsKey(key))
            {
                throw new Exception("String key does not exist: " + key);
            }

            this.data[key] = newVal;
        }

    }
}
