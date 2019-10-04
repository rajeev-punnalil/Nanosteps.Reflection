using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nanosteps.Reflection
{
    /// <summary>
    /// Extend path functions related with reflections
    /// </summary>
    public static partial class ReflectionAssemblyExtensions
    {
        /// <summary>
        /// Get the location of the entry assembly
        /// </summary>
        /// <returns></returns>
        public static DirectoryInfo GetEntryLocation()
        {
            return new DirectoryInfo(System.Reflection.Assembly.GetEntryAssembly().Location).Parent;
        }

        /// <summary>
        /// Get directory related to path
        /// </summary>
        /// <param name="relativePath"></param>
        /// <returns></returns>
        public static DirectoryInfo GetEntyRelativeLocation(string relativePath)
        {
            return new DirectoryInfo(Path.Combine(GetEntryLocation().FullName, relativePath));
        }

        /// <summary>
        /// Get entry relative file
        /// </summary>
        /// <param name="relativePath"></param>
        /// <returns></returns>
        public static FileInfo GetEntyRelativeFile(string relativePath)
        {
            return new FileInfo(Path.Combine(GetEntryLocation().FullName, relativePath));
        }
    }
}
