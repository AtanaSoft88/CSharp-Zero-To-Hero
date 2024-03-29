﻿namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            string[] files = Directory.GetFiles(folderPath);
            double total = 0;
            foreach (var file in files)
            {
                total += new FileInfo(file).Length;
            }

            var subDirectories = Directory.GetDirectories(folderPath);
            foreach (var directory in subDirectories)
            {
                files = Directory.GetFiles(directory);
                foreach (var file in files)
                {
                    total += new FileInfo(file).Length;
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                double totalSize = total / 1024;
                writer.WriteLine(totalSize + " KB");
            }
        }
    }
}
