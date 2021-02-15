using System;
using System.IO;

namespace FileDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\archive";
            string archiveDirectory = @"C:\secretarchive";
            bool deleteForce = false;

            //try
            //{
            //    var txtFiles = Directory.EnumerateFiles(sourceDirectory);

            //    foreach (string currentFile in txtFiles)
            //    {
            //        string fileName = currentFile.Substring(sourceDirectory.Length + 1);
            //        //Console.WriteLine(Directory.GetLastAccessTime(archiveDirectory).ToShortDateString();
            //        Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));


            //    }
            //    if (Directory.Exists(sourceDirectory))
            //    {
            //        Directory.Delete(sourceDirectory);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            DirectoryInfo di = new DirectoryInfo(@"c:\archive");

            try
            {
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    // Indicate that the directory already exists.
                    Console.WriteLine("That path exists already.");
                    //return;
                }
                else
                {
                    di.Create();
                    Console.WriteLine($"The directory {di.FullName} has been created successfully.");
                }

                di.Delete();
                Console.WriteLine("The directory was deleted successfully.");
            }
            catch(IOException ioe)
            {
                Console.WriteLine(ioe.Message);
                deleteForce = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (deleteForce)
            {
                try
                {
                    Console.Write("Are you sure you wish to delete everything? (y/n): ");
                    if (Console.ReadLine() == "y")
                        di.Delete(true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
