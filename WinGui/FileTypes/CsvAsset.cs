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

namespace WinGui.FileTypes
{
    // Class that saves/loads a file in FF5's CSV format
    internal class CsvAsset
    {
        // header_name, in order
        private string[] headers = [];

        // rows of { k:v } entries; guaranteed to have exactly 1 entry per header
        private List<Dictionary<string, string>> data = new();

        // Where to save this file when we're done with it
        private readonly string outPath;

        public CsvAsset(string inPath, string outPath)
        {
            // Save for later
            this.outPath = outPath;

            // Read input
            using FileStream inFile = File.OpenRead(inPath);
            using StreamReader strReader = new(inFile, Encoding.UTF8, true, 1024 * 1024);

            int lineNum = -1;
            string? line;
            while ((line = strReader.ReadLine()) != null)
            {
                // Process text
                string[] parts = line.Trim(['\r', '\n']).Split(',');
                lineNum += 1;

                // Header vs. data
                if (lineNum == 0)
                {
                    this.headers = parts;
                    if (!this.headers.Contains("id"))
                    {
                        throw new Exception("Invalid header set, doesn't contain 'id'" + this.headers);
                    }
                }
                else
                {
                    if (parts.Length != this.headers.Length)
                    {
                        throw new Exception("Invalid line: " + parts + " for headers: " + this.headers);
                    }

                    // Convert
                    Dictionary<string, string> entry = new();
                    for (int i=0; i<parts.Length; i++)
                    {
                        entry[this.headers[i]] = parts[i];
                    }
                    this.data.Add(entry);
                }
            }
        }

        // Save to disk
        public void Write()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(this.outPath));
            using FileStream outFile = File.Open(this.outPath, FileMode.Create); // This should truncate by default.
            using StreamWriter strWriter = new(outFile, new UTF8Encoding(false), 1024*1024);

            // Write the headers
            strWriter.WriteLine(String.Join(',', this.headers));

            // Write the data
            foreach (Dictionary<String, String> entry in this.data)
            {
                string line = "";
                string comma = "";
                foreach (string column in this.headers)
                {
                    line += comma + entry[column];
                    comma = ",";
                }
                strWriter.WriteLine(line);
            }

            // For some reason, these files all end with an empty line... 
            //strWriter.WriteLine(); // ...or not?

            Console.WriteLine("Wrote: " + outPath);
        }

        // Do we have every column accounted for?
        private bool SameFields(Dictionary<string, string> entry)
        {
            if (entry.Count != this.headers.Length)
            {
                return false;
            }

            foreach (string col in entry.Keys)
            {
                if (!this.headers.Contains(col))
                {
                    return false;
                }
            }

            return true;
        }

        // Add an entry to the end of the list
        public void AddEntry(Dictionary<string, string> entry)
        {
            // Make sure we have exactly the same fields.
            if (! SameFields(entry))
            {
                throw new Exception("Fields don't match: " + entry);
            }

            // Make sure the index is the next one in line.
            // We could auto-generate the index, but we'd need a way to
            // make sure these are consistent across runs of the program
            // (or else we'd break save files).
            int lastId = int.Parse(this.data[this.data.Count - 1]["id"]) + 1;
            if (lastId != int.Parse(entry["id"]))
            {
                throw new Exception("Invalid id for: " + entry + "; previous ID is: " + lastId);
            }

            // Now just add it.
            this.data.Add(entry);
        }

    }
}
