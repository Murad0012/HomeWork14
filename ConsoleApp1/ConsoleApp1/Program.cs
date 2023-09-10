using System;
using System.IO;

namespace ConsoleApp8
{
    public class FileExceptaion : Exception
    {
        public FileExceptaion(string message) : base(message)
        {

        }
    }
    public class FoxException : Exception
    {
        public FoxException(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = @"c:\users\muradamam\desktop\test\mytest.txt"; 1
            //File.Create(a);

            //string a = @"c:\users\muradamam\desktop\test\mytest.txt"; 2
            //File.Delete(a);


            //if (File.Exists(@"C:\Users\muradamam\Desktop\Test\mytest.txt")) 3
            //{
            //    throw new FileExceptaion("A file created with name mytest.txt");
            //}
            //else
            //{
            //    string a = @"C:\Users\muradamam\Desktop\Test\mytest.txt";
            //    File.Create(a);
            //}

            //string a = @"c:\users\muradamam\desktop\test\mytest.txt"; 4
            //File.Create(a);
            //File.WriteAllText(a, "Hello World");

            //string a = @"c:\users\muradamam\desktop\test\mytest.txt"; 5
            //File.Create(a);
            //Console.WriteLine(File.ReadAllText(a));

            //string a = @"c:\users\muradamam\desktop\test\mytest.txt"; 6
            //File.Create(a);
            //string[] b = { "this is 1st line", "this is 2nd line" };
            //File.WriteAllLines(a, b);

            //string a = @"c:\users\muradamam\desktop\test\mytest.txt"; 7
            //string[] b = { "the quick brown fox jumps", "over the lazy dog" };
            //foreach (string s in b)
            //{
            //    try
            //    {
            //        if (s.Contains("fox"))
            //        {
            //            throw new FoxException("The line have ignored which contain the string 'fox'.");
            //        }
            //    }
            //    catch (FoxException ex) 
            //    { 
            //        Console.WriteLine(ex.Message);
            //        break;
            //    }
            //    File.WriteAllText(a, s);
            //}

            //string a = @"c:\users\muradamam\desktop\test\mytest.txt"; 8
            //string[] b = { "Salam", "Hello","Hola" };
            //File.WriteAllLines(a, b);
            //string word1 =  Console.ReadLine();
            //string word2 = Console.ReadLine();
            //string[] c = { word1, word2 };         
            //File.AppendAllLines(a,c);

            //string a = @"C:\Users\Predator\Desktop\mytest.txt"; 9
            //string b = @"C:\Users\Predator\Desktop\mynewtest.txt";
            //string[] c = { "Salam", "Hello", "Hola" };
            //File.WriteAllLines(a, c);
            //File.Copy(a, b);

            //string a = @"C:\Users\Predator\Desktop\mytest.txt"; 11
            //string[] array = { "salam", "hello", "bye" };
            //File.WriteAllLines(a, array);
            //Console.WriteLine($" The content of the first line of the file is : {array[0]}");

            //string a = @"C:\Users\Predator\Desktop\mytest.txt";  12
            //string[] array = { "salam", "hello", "bye" };
            //File.WriteAllLines(a, array);
            //Console.WriteLine($" The content of the last line of the file mytest.txt is : {array[array.Length-1]}");


            //string a = @"C:\Users\Predator\Desktop\mytest.txt";  
            //Console.Write("Input number of lines to write in the file : ");
            //string limit = Console.ReadLine();
            //int limit1 = Convert.ToInt32(limit);
            //string[] array = new string[limit1];
            //for (int i = 0; limit1 - 1 >= i; i++)                                13
            //{
            //    Console.Write("input line {0} : ", i + 1);
            //    array[i] = Console.ReadLine();
            //}
            //File.AppendAllLines(a, array);
            //Console.Write("Input which line you want to display : ");
            //string input = Console.ReadLine();
            //int input1 = Convert.ToInt32(input);
            //Console.WriteLine(array[input1 - 1]);

            //string a = @"C:\Users\Predator\Desktop\mytest.txt";
            //Console.Write("Input number of lines to write in the file : ");
            //string limit = Console.ReadLine();
            //int limit1 = Convert.ToInt32(limit);
            //string[] array = new string[limit1];
            //for (int i = 0; limit1 - 1 >= i; i++)                14
            //{
            //    Console.Write("input line {0} : ", i + 1);
            //    array[i] = Console.ReadLine();
            //}
            //File.AppendAllLines(a, array);
            //Console.Write("Input last how many numbers of lines you want to display : ");
            //string input = Console.ReadLine();
            //int input1 = Convert.ToInt32(input);
            //for (int i = input1; i >= limit1 - input1 - 1; i--)
            //{
            //    Console.WriteLine(" The last no {0} line is : {1} ", i, array[i - 1]);
            //}

            //string a = @"C:\Users\Predator\Desktop\mytest.txt";
            //string b = "Test line ";
            //int lineCount = 7;
            //string[] array = new string[lineCount];
            //for (int i = 1; lineCount > i; i++)
            //{                                                  15
            //    array[i] = b + i;                       
            //    Console.WriteLine(array[i]);
            //}
            //File.WriteAllLines(a, array);
            //int c = array.Length - 1;
            //Console.WriteLine("The number of lines in the file mytest.txt is : " + c);
        }
    }
}