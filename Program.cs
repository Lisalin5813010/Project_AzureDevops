using System;

namespace SimpleCSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // 输出到控制台，提示用户输入名字
            Console.Write("Please enter your name: ");
            
            // 从控制台读取用户输入的名字
            string userName = Console.ReadLine();
            
            // 输出问候消息
            Console.WriteLine("Hello, " + userName + "! Welcome to the simple C# program.");
            
            // 等待用户按任意键退出
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
