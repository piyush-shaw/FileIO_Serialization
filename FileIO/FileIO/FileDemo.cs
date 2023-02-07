﻿using System;
namespace FileIO
{
	public class FileDemo
	{
        public static void FileExists()
        {
            String path = "/Users/piyushshaw/projects/fileio/FileIO/Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }

        public static void ReadAllLines()
        {
            String path = "/Users/piyushshaw/projects/fileio/FileIO/Example.txt";
            String[] lines;
            //C: \Users/inyadav\source\repos\Day20_FileIO\Day20_FileIO
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }

        public static void ReadAllText()
        {
            String path = "/Users/piyushshaw/projects/fileio/FileIO/Example.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }

        public static void FileCopy()
        {
            String path = "/Users/piyushshaw/projects/fileio/FileIO/Example.txt";
            String copypath = "/Users/piyushshaw/projects/fileio/FileIO/Example1.txt";

            File.Copy(path, copypath);

        }

        public static void DeleteFile()
        {
            String path = "/Users/piyushshaw/projects/fileio/FileIO/Example1.txt";

            File.Delete(path);

        }

        public static void ReadFromStreamReader()
        {
            String path = "/Users/piyushshaw/projects/fileio/FileIO/Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = "/Users/piyushshaw/projects/fileio/FileIO/Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hellow World - .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }

    }
}

