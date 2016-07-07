using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace JustMoveTheDamnThing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WindowWidth = 100;
                Console.BufferWidth = 200;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                var assembly = Assembly.GetExecutingAssembly();
                Console.Title = string.Format("Bin Cleaner™ v{0} (built on {1})", assembly.GetName().Version, File.GetLastWriteTime(assembly.Location).ToString("O"));

                if (args.Length == 0)
                    throw new Exception("Gimme a damn directory!");

                var sourceDirName = args[0];

                Console.WriteLine("Source Directory: {0}", sourceDirName);
                Console.WriteLine();

                var fullPath = Path.GetFullPath(sourceDirName);
                var pathRoot = Path.GetPathRoot(sourceDirName);
                var relPath = fullPath.Substring(pathRoot.Length);

                string targetPath;
                using (var foo = new Foo())
                {
                    var result = foo.ShowDialog();
                    if (result != DialogResult.OK)
                        Environment.Exit(0);

                    targetPath = Path.Combine(foo.SelectedTarget, relPath);
                }

                Console.WriteLine("You sure you wanna do the following ninja-move???");
                Console.WriteLine();
                Console.WriteLine("\t {0}", fullPath);
                Console.WriteLine("\t -->");
                Console.WriteLine("\t {0}", targetPath);

                Console.WriteLine();
                Console.Write("(Press Enter to confirm)");
                var key = Console.ReadKey(true);
                Console.WriteLine();
                Console.WriteLine();
                if (key.Key == ConsoleKey.Enter)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "XCOPY",
                        Arguments = string.Format("/E /I /H {0} {1}", fullPath, targetPath),
                        UseShellExecute = false
                    });

                    Console.WriteLine("K, the job has been sent to XCOPY. Sit and wait. " +
                                      "When DONE press any key to continue, but not UNTIL IT IS DONE...");
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No comprendo. Bye. >:(");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
