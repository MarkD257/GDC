using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GDCConsoleApp.Services
{
	public class FileSearcher
	{
		public  static string findFile(string filename, string appCurrentBaseDirectory)
		{
            string fileName = ""; 

            //creating a DirectoryInfo object
            DirectoryInfo mydir = new DirectoryInfo(appCurrentBaseDirectory);

            // getting the files in the directory, their names and size
            FileInfo[] f = mydir.GetFiles();

            foreach (FileInfo file in f)
            {
                if (file.Name == filename)
                {
                    fileName = appCurrentBaseDirectory + filename;
                    Console.WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
                    break;
                }
            }

            return fileName;
        }
	} 
}
