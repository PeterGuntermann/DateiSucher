using System.Collections.Generic;

namespace DateiSucher;

public interface IFileService
{
    IEnumerable<string> GetSubfolders();
    string Foo();
}

public class FileService : IFileService
{
    public string RootFolder { get; set; } = string.Empty;

    public IEnumerable<string> GetSubfolders()
    {
        throw new System.NotImplementedException();
    }

    public string Foo() => "FoO!";
}