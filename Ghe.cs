using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangdhph31492_Training_Csharp_B2
{
    internal class Ghe : DoDac
    {
        public Ghe()
        {

        }
        public Ghe(double chieuDai, double chieuRong, double chieuSau, double theTich) : base(chieuDai, chieuRong, chieuSau, theTich)
        {

        }

        public override void InThongTin()
        {
            Console.WriteLine($"May tinh co chieu dai: {ChieuDai}" +
                $" | chieu rong: {ChieuRong}" +
                $" | Chieu sau: {ChieuSau}");
        }
    }
}
