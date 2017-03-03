using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"D:\10311209\lab-2-zi-chuan-chu-li-XiuXuanLiu\Data\Input.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if (Char.IsPunctuation(ch)) //標點符號
                        {
                            if ((ch == '.') || (ch == '?') || (ch == '!'))
                            { //判斷"." "?" "!"
                                Console.Write(ch + "\n");
                            }
                        }
                        else
                        {
                            Console.Write(ch);
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
