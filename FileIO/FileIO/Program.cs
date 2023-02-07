using FileIO;

internal class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");
        FileDemo.FileExists();
        FileDemo.ReadAllLines();
        FileDemo.ReadAllText();
        FileDemo.FileCopy();
        FileDemo.DeleteFile();
        FileDemo.WriteUsingStreamWriter();
        Console.ReadKey();
    }
}