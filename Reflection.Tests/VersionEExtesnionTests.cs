using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nanosteps.Reflection;
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

    }
}

