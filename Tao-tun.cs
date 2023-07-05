using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hoangdhph31492_Training_Csharp_B2
{
    internal class Tao_tun
    {
        public static string getInput(string input)
        {
            Console.WriteLine($"Moi ban nhap {input}");
            return Console.ReadLine();
        }
        public static string getInput_Regex(string msg, string regex)
        {
            string input;
            do
            {
                input = getInput(msg);
                if (!Regex.IsMatch(input,regex))
                {
                    Console.WriteLine($"Du lieu nhap khong phu hop regex cua {msg}");
                    Console.WriteLine("Moi nhap lai");
                }
            } while (!Regex.IsMatch(input, regex));
            return input;
        }
        public static bool checkCount(ArrayList ar_lst)
        {
            if (ar_lst.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!");
                return false;
            }
            return true;
        }
    }
}
