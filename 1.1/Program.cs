using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "C:\\Users\\TemaOOOOOO\\Desktop\\норм.txt";
        List<string> lines = new List<string>();
        try
        {
            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line); 
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            return;
        }
        string outputFilePath = "C:\\Users\\TemaOOOOOO\\Desktop\\обратный.txt";
        try
        {
            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                
                for (int i = lines.Count - 1; i >= 0; i--)
                {
                    sw.WriteLine(lines[i]);
                }
            }
            Console.WriteLine("Строки успешно записаны в файл 'обратный.txt' в обратном порядке.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при записи в файл: " + ex.Message);
        }
    }
}

