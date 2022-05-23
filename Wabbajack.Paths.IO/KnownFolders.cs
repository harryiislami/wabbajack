using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Wabbajack.Paths.IO;

public static class KnownFolders
{
    public static AbsolutePath EntryPoint
    {
        get
        {
            //var v = Process.GetCurrentProcess().ProcessName;
            //return Assembly.GetExecutingAssembly().Location.ToAbsolutePath().Parent;
            return Process.GetCurrentProcess().MainModule!.FileName!.ToAbsolutePath().Parent;
        }
    }

    public static AbsolutePath AppDataLocal =>
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToAbsolutePath();

    public static AbsolutePath WindowsSystem32 => Environment.GetFolderPath(Environment.SpecialFolder.System).ToAbsolutePath();

    public static AbsolutePath WabbajackAppLocal => AppDataLocal.Combine("Wabbajack");
    public static AbsolutePath CurrentDirectory => Directory.GetCurrentDirectory().ToAbsolutePath();
    public static AbsolutePath Windows => Environment.GetFolderPath(Environment.SpecialFolder.Windows).ToAbsolutePath();
}