using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangdhph31492_Training_Csharp_B2
{
    internal abstract class DoDac
    {
        private double chieuDai;
        private double chieuRong;
        private double chieuSau;
        private double theTich;


        public DoDac()
        {
            
        }

        public DoDac(double chieuDai, double chieuRong, double chieuSau, double theTich)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.chieuSau = chieuSau;
            this.theTich = theTich;
        }

        public double ChieuDai { get => chieuDai; set => chieuDai = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public double ChieuSau { get => chieuSau; set => chieuSau = value; }
        public double TheTich { get => theTich; set => theTich = Tich(this.chieuDai,this.chieuRong,this.chieuSau); }

        private double Tich (double chieuDai, double chieuRong, double chieuSau)
        {
            return chieuDai*chieuRong*chieuSau;
        }
        public abstract void InThongTin();
    }
}
