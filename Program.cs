using System;

namespace SimpleLoginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义一些示例用户的用户名和密码
            string storedUsername = "admin";
            string storedPassword = "password123";

            Console.WriteLine("Welcome to the Simple Login Application!");

            // 提示用户输入用户名
            Console.Write("Enter your username: ");
            string inputUsername = Console.ReadLine();

            // 提示用户输入密码
            Console.Write("Enter your password: ");
            string inputPassword = Console.ReadLine();

            // 验证输入的用户名和密码是否与存储的值匹配
            if (inputUsername == storedUsername && inputPassword == storedPassword)
            {
                Console.WriteLine("Login successful! Welcome, " + inputUsername + "!");
            }
            else
            {
                Console.WriteLine("Login failed! Incorrect username or password.");
            }

            // 等待用户按任意键退出
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
