using ReadFromFiles;

// Add the directoryPath .txt are to be read from
string directoryPath = "C:\\Users\\ricar\\Desktop\\TextFiles";

List<FileEntry> files = TextFile.ReadFilesFromDirectory(directoryPath);

// Process the files
foreach(var file in files)
{
    Console.WriteLine(file.FileName);
    Console.WriteLine(file.Content);
}