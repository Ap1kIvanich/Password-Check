using System;
using System.IO;

namespace PasswordProgram
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите пароль: ");
            string TruePassword = ReadAllText();
            string InputPassword = Console.ReadLine();


            
            if(InputPassword == TruePassword) 
            {
                Access();
                
            }

            else 
            {
                Decline();
            }
            
        }

        static string ReadAllText(string path = @"D:\VisualStudio\PasswordProgram\password.txt")
        {
            string password = File.ReadAllText(path);
            return password;
        }
        static void Access() 
        {
            Console.WriteLine("Доступ!");
        }

        static void Decline() 
        {
            Console.WriteLine("Пароль введён неверно.");
        }
    }
}