using System;
using System.Reflection;

namespace Nanosteps.Reflection
{
    /// <summary>
    /// Reflection assembly extension
    /// </summary>
    public static partial class ReflectionAssemblyExtensions
    {
        /// <summary>
        /// Get version for the entry assembly in format
        /// Major.Minor.Revison.Build
        /// </summary>
        /// <returns></returns>
        public static string GetEntryAssemblyVersion()
        {
            return Assembly.GetEntryAssembly().GetAssemblyVersion();
        }

        /// <summary>
        /// Get version for the current assembly in format
        /// Major.Minor.Revison.Build
        /// </summary>
        /// <returns></returns>
        public static string GetExecutingAssemblyVersion()
        {
            return Assembly.GetCallingAssembly().GetAssemblyVersion();
        }

        /// <summary>
        /// Get version for the given assembly in format
        /// Major.Minor.Revison.Build 
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static string GetAssemblyVersion(this Assembly assembly)
        {
            if (assembly == null)
                throw new ArgumentNullException("assembly");

            var version = assembly.GetName().Version;

            return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";

        }
    }
}
