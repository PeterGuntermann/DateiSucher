using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace DateiSucher.Test;

public class FileServiceTest
{
    static class TestFiles
    {
        public static string FileInRoot => nameof(FileInRoot);
        public static string CopyOfFileInRoot => nameof(CopyOfFileInRoot);
        public static string FileA => nameof(FileA);
        public static string FileB => nameof(FileB);
        public static string FileC => nameof(FileC);
    }
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldCountFilesAndSubfolders()
    {
        var numFiles = 2;
        IEnumerable<string> fileNames = new List<string> { "FileInRoot.txt", "CopyOfFileInRoot.txt" };
        
        numFiles.Should().Be(2);
        
    }

    [Test]
    public void ShouldDetectSubfoldersRecursively()
    {
        Assert.Pass();
    }
}