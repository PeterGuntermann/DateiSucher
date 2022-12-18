using System.IO;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace DateiSucher.Test;

public class FileServiceTest
{
    static class Test
    {
        public static class File
        {
            public static string FileInRoot => nameof(FileInRoot) + ".txt";
            public static string CopyOfFileInRoot => nameof(CopyOfFileInRoot) + ".txt";
            public static string FileA => nameof(FileA) + ".txt";
            public static string FileB => nameof(FileB) + ".txt";
            public static string FileC => nameof(FileC) + ".txt";
        }

        public static class Folder
        {
            public static string Root => @"..\..\..\TestFileStructure";
            public static string SubfolderA => nameof(SubfolderA);
            public static string SubfolderB => nameof(SubfolderB);
            public static string SubfolderC => nameof(SubfolderC);
        }
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldDetectFilesAndSubfolders()
    {
        var subfolders = Directory.GetDirectories(Test.Folder.Root);
        var subfolderInfos = subfolders.Select(folder => new DirectoryInfo(folder)).ToList();
        var files = Directory.GetFiles(Test.Folder.Root);
        var fileInfos = files.Select(file => new FileInfo(file)).ToList();

        files.Length.Should().Be(2);
        fileInfos[0].Name.Should().Be(Test.File.CopyOfFileInRoot);
        fileInfos[1].Name.Should().Be(Test.File.FileInRoot);

        subfolders.Length.Should().Be(2);
        subfolderInfos[0].Name.Should().Be(Test.Folder.SubfolderA);
        subfolderInfos[1].Name.Should().Be(Test.Folder.SubfolderB);
    }

    [Test]
    public void ShouldDetectSubfoldersRecursively()
    {
        Assert.Pass();
    }
}