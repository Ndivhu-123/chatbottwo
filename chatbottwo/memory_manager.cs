using System.Collections.Generic;
using System.IO;
using System;

namespace chatbottwo
{
    public class memory_manager
    {

        private string path;  // Path to store memory data
        public List<string> MemoryData { get; private set; } // Stores memory entries

        public memory_manager()
        {
            // Get the base directory of the application
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;

            // Modify the path to remove the "bin\\Debug" segment, ensuring correct file location
            string new_path = projectPath.Replace("bin\\Debug", "");

            // Combine the new path with the filename to construct the full file path
            path = Path.Combine(new_path, "chatmemory.txt");

            // Load memory data from the file upon initialization
            MemoryData = memory_load(path);
        }

        private List<string> memory_load(string path)
        {
            // Check if the memory file exists
            if (File.Exists(path))
            {
                // Read all lines from the file and store them in a list
                return new List<string>(File.ReadAllLines(path));
            }
            else
            {
                // Create the memory file if it does not exist
                File.CreateText(path).Close();
                return new List<string>(); // Return an empty list
            }
        }

        public void AddToMemory(string entry)
        {
            // Add new entry to the memory list
            MemoryData.Add(entry);

            // Write updated memory data back to the file for persistence
            File.WriteAllLines(path, MemoryData);
        }
    }
}