using System.Text;

namespace ReadFromFiles;

public static class TextFile
{
    public static string Read(string filePath)
    {
        try
        {
            StringBuilder content = new StringBuilder();

            // Open the file for reading
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read the contents of the file line by line
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Process the line as needed
                    content.AppendLine(line);
                }
            }

            return content.ToString();
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur during file reading
            return "An error occurred while reading the file: " + ex.Message;
        }
    }

    public static List<FileEntry> ReadFilesFromDirectory(string directoryPath)
    {
        List<FileEntry> fileEntries = new List<FileEntry>();

        try
        {
            // Get all text files in directory
            string[] textFiles = Directory.GetFiles(directoryPath, "*.txt");

            foreach(string filePath in textFiles)
            {
                string fileName = Path.GetFileName(filePath);
                string fileContent = Read(filePath);

                FileEntry file = new FileEntry
                {
                    FileName = fileName,
                    Content = fileContent
                };

                fileEntries.Add(file);
            }
        }
        catch(Exception ex)
        {
            // Handle any exceptions that occur during file reading
            FileEntry errorEntry = new FileEntry
            {
                FileName = "Error",
                Content = "An error occurred while reading the files: " + ex.Message
            };

        fileEntries.Add(errorEntry);
        }

        return fileEntries;
    }
}
