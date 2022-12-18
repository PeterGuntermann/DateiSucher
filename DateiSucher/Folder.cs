using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DateiSucher;

public class Folder
{
    public Folder(string path)
    {
        Path = path;
    }

    public string Path { get; }

    public IEnumerable<Folder> Subfolders => Directory
        .GetDirectories(Path)
        .Select(dir => new Folder(dir));
    
    public DirectoryInfo DirectoryInfo => new DirectoryInfo(Path);

    public IEnumerable<FileInfo> Files => Directory
        .GetFiles(Path)
        .Select(file => new FileInfo(file));
}