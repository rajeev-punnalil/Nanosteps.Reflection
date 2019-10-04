using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nanosteps.Reflection;
using System.IO;
using System.Reflection;

namespace Reflection.Tests
{
    [TestClass]
    public class VersionEExtesnionTests
    {
        [TestMethod]
        public void GetEntryAssemblyVersion_01()
        {
            var version = ReflectionAssemblyExtensions.GetEntryAssemblyVersion();
            Assert.IsTrue(!string.IsNullOrWhiteSpace(version));
        }

        [TestMethod]
        public void GetExecutingAssemblyVersion_01()
        {
            var version = ReflectionAssemblyExtensions.GetExecutingAssemblyVersion();
            Assert.IsTrue(!string.IsNullOrWhiteSpace(version));
        }

        [TestMethod]
        public void GetEntryLocation_01()
        {
            var location = ReflectionAssemblyExtensions.GetEntryLocation(); 
            Assert.IsTrue(new DirectoryInfo(System.Reflection.Assembly.GetEntryAssembly().Location).Parent.FullName == location.FullName);
        }

        [TestMethod]
        public void GetEntyRelativeLocation_01()
        {
            var location = ReflectionAssemblyExtensions.GetEntryLocation();
            var subDir = location.CreateSubdirectory("Test");
            var testFolder = ReflectionAssemblyExtensions.GetEntyRelativeLocation("Test");
            Assert.IsTrue(subDir.FullName == testFolder.FullName);
        }

        [TestMethod]
        public void GetEntyRelativeFile_01()
        {
            var location = ReflectionAssemblyExtensions.GetEntryLocation();
            var targetFile = new FileInfo(Path.Combine(location.FullName, "test.txt"));
            var finalFile  = ReflectionAssemblyExtensions.GetEntyRelativeFile("test.txt");
            Assert.IsTrue(targetFile.FullName == targetFile.FullName);
        }
    }
}

