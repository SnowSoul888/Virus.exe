using System;
using System.Diagnostics;
using System.Windows;

class Program
{
    static void Main()
    {
        string explorerPath = Environment.GetEnvironmentVariable("windir") + @"\explorer.exe";
        int numero = 5;
        Console.WriteLine("Esta é uma mensagem de alerta!");
        Console.ReadLine();
        Console.WriteLine("Va olhar o lado de fora de sua casa!");
        Console.ReadLine();
        Console.WriteLine("Va olhar o lado de fora de sua casa!");
        Console.ReadLine();
        for(int i = 0; i < numero; i++)
        {
            // Abre o Windows Explorer no diretório especificado
            Process.Start(explorerPath);
            if(i == numero)
            {
                Process.Start("shutdown", "/s");
            }
        }
    }
}