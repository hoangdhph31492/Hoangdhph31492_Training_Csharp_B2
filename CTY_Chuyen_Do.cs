using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangdhph31492_Training_Csharp_B2
{
    internal class CTY_Chuyen_Do
    {
        const double TTchoPhep = 15;
        private string tenCongTy;
        private ArrayList ar_lstKH;
        public CTY_Chuyen_Do()
        {
            ar_lstKH = new ArrayList();
        }

        public CTY_Chuyen_Do(string tenCongTy, ArrayList ar_lstKH)
        {
            this.tenCongTy = tenCongTy;
            this.ar_lstKH = ar_lstKH;
        }

        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public ArrayList Ar_lstKH { get => ar_lstKH; set => ar_lstKH = value; }
        public void themKH(KhachHang kh)
        {
            ar_lstKH.Add(kh);     
        }
        public void XoaKH()
        {
            if (Tao_tun.checkCount(ar_lstKH))
            {
                Console.WriteLine("Danh sach khach hang:");
                int vitri =0;
                int vitrixoa;
                foreach (KhachHang item in ar_lstKH)
                {
                    Console.Write($"khach hang thu {vitri + 1} :");
                    item.InRa_ThongTinKH();
                }
                
                vitrixoa = Convert.ToInt32(Tao_tun.getInput("vi tri khach hang muon xoa"));
                if (vitrixoa-1 > ar_lstKH.Count)
                {
                    Console.WriteLine("Khach hang khong ton tai!!");
                    return;
                }
                ar_lstKH.RemoveAt(vitrixoa-1);
                Console.WriteLine("Xoa thanh cong");
            }
        }
        public void checkVanChuyen()
        {
            if (Tao_tun.checkCount(ar_lstKH)) 
            {
                foreach (KhachHang item in ar_lstKH)
                {
                    item.InRa_ThongTinKH();
                    double sum = item.TongTheTich();
                    Console.WriteLine($"{(sum<= TTchoPhep ? "Du tieu chuan van chuyen":"khong du tieu chuan van chuyen")}");
                }
            }
        }
        public void ThemdoDungKH()
        {
            if (Tao_tun.checkCount(ar_lstKH))
            {
                Console.WriteLine("Danh sach khach hang:");
                int vitri = 0;
                int vitrithem;
                foreach (KhachHang item in ar_lstKH)
                {
                    Console.Write($"khach hang thu {vitri + 1} :");
                    item.InRa_ThongTinKH();
                }

                vitrithem = Convert.ToInt32(Tao_tun.getInput("vi tri khach hang muon them do dac:"));
                if (vitrithem - 1 > ar_lstKH.Count)
                {
                    Console.WriteLine("Khach hang khong ton tai!!");
                    return;
                }
                KhachHang kh = (KhachHang)ar_lstKH[vitrithem - 1];
                kh.nhapDoDac();
                ar_lstKH[vitrithem-1] = kh;
            }
        }public void SuaDoDungKH()
        {
            if (Tao_tun.checkCount(ar_lstKH))
            {
                Console.WriteLine("Danh sach khach hang:");
                int vitri = 0;
                int vitrisua;
                foreach (KhachHang item in ar_lstKH)
                {
                    Console.Write($"khach hang thu {vitri + 1} :");
                    item.InRa_ThongTinKH();
                }

                vitrisua = Convert.ToInt32(Tao_tun.getInput("vi tri khach hang muon sua do dac:"));
                if (vitrisua - 1 > ar_lstKH.Count)
                {
                    Console.WriteLine("Khach hang khong ton tai!!");
                    return;
                }
                KhachHang kh = (KhachHang)ar_lstKH[vitrisua - 1];
                kh.SuaDoDac();
                ar_lstKH[vitrisua-1] = kh;
            }
        }
        public void InThongTinCTY()
        {
            Console.WriteLine($"Ten cong ty: {tenCongTy}");
            Console.WriteLine("danh sach khach hang hien co cua cong ty la:");
            foreach (KhachHang item in ar_lstKH)
            {
                item.InRa_ThongTinKH();
            }
        }
    }
}
