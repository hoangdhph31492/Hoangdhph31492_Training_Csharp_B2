using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hoangdhph31492_Training_Csharp_B2
{
    internal class KhachHang
    {
        private string ten;
        private int tuoi;
        private string diaChi;
        private int sDT;
        private ArrayList ar_lstDoDac;
        public KhachHang()
        {
            ar_lstDoDac = new ArrayList();
        }

        public KhachHang(string ten, int tuoi, string diaChi, int sDT, ArrayList ar_lstDoDac)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.diaChi = diaChi;
            this.sDT = sDT;
            this.ar_lstDoDac = ar_lstDoDac;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SDT { get => sDT; set => sDT = value; }
        public ArrayList Ar_lstDoDac { get => ar_lstDoDac; set => ar_lstDoDac = value; }
        public  void nhapDoDac()
        {
            int chon;
            do
            {
                Console.WriteLine("Cac Loai do dung co the them:");
                Console.WriteLine("1. Ban");
                Console.WriteLine("2. Ghe");
                Console.WriteLine("3. Giuong");
                Console.WriteLine("4. May Tinh");
                Console.WriteLine("5. Tu Do");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Chon do dung muon them:");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        break;
                    case 1:
                        Ban b = new Ban();
                        b.ChieuDai = Convert.ToDouble(Tao_tun.getInput_Regex("chieu dai ban",@"^[\d]+\,?[\d]*$"));
                        b.ChieuRong = Convert.ToDouble(Tao_tun.getInput_Regex("chieu rong ban",@"^[\d]+\,?[\d]*$"));
                        b.ChieuSau = Convert.ToDouble(Tao_tun.getInput_Regex("chieu sau ban",@"^[\d]+\,?[\d]*$"));
                        ar_lstDoDac.Add(b);
                        break;
                    case 2:
                        Ghe g = new Ghe();
                        g.ChieuDai = Convert.ToDouble(Tao_tun.getInput_Regex("chieu dai ban", @"^[\d]+\,?[\d]*$"));
                        g.ChieuRong = Convert.ToDouble(Tao_tun.getInput_Regex("chieu rong ban", @"^[\d]+\,?[\d]*$"));
                        g.ChieuSau = Convert.ToDouble(Tao_tun.getInput_Regex("chieu sau ban", @"^[\d]+\,?[\d]*$"));
                        ar_lstDoDac.Add(g);
                        break;
                        case 3:
                        Giuong gi = new Giuong();
                        gi.ChieuDai = Convert.ToDouble(Tao_tun.getInput_Regex("chieu dai ban", @"^[\d]+\,?[\d]*$"));
                        gi.ChieuRong = Convert.ToDouble(Tao_tun.getInput_Regex("chieu rong ban", @"^[\d]+\,?[\d]*$"));
                        gi.ChieuSau = Convert.ToDouble(Tao_tun.getInput_Regex("chieu sau ban", @"^[\d]+\,?[\d]*$"));
                        ar_lstDoDac.Add(gi);
                        break;
                    case 4:
                        MayTinh mt = new MayTinh();
                        mt.ChieuDai = Convert.ToDouble(Tao_tun.getInput_Regex("chieu dai ban", @"^[\d]+\,?[\d]*$"));
                        mt.ChieuRong = Convert.ToDouble(Tao_tun.getInput_Regex("chieu rong ban", @"^[\d]+\,?[\d]*$"));
                        mt.ChieuSau = Convert.ToDouble(Tao_tun.getInput_Regex("chieu sau ban", @"^[\d]+\,?[\d]*$"));
                        ar_lstDoDac.Add(mt);
                        break;
                        case 5:
                        TuDo td = new TuDo();
                        td.ChieuDai = Convert.ToDouble(Tao_tun.getInput_Regex("chieu dai ban", @"^[\d]+\,?[\d]*$"));
                        td.ChieuRong = Convert.ToDouble(Tao_tun.getInput_Regex("chieu rong ban", @"^[\d]+\,?[\d]*$"));
                        td.ChieuSau = Convert.ToDouble(Tao_tun.getInput_Regex("chieu sau ban", @"^[\d]+\,?[\d]*$"));
                        ar_lstDoDac.Add(td);
                        break;
                    default:
                        Console.WriteLine("do ban chon hien chua the them");
                        break;
                }
            } while (chon != 0);
        }
         public  void XoaDoDac()
        {
            if (Tao_tun.checkCount(ar_lstDoDac))
            {
                int vitri = 0;
                int vitrixoa;
                Console.WriteLine("Bang do dac:");
                foreach (DoDac item in ar_lstDoDac)
                {
                    Console.Write($"Do thu {vitri + 1} : ");
                    item.InThongTin();
                    vitri++;
                }
                
                vitrixoa = Convert.ToInt32(Tao_tun.getInput("Vi tri muon xoa"));
                if (vitrixoa -1 > ar_lstDoDac.Count )
                {
                    Console.WriteLine($"Vi tri {vitrixoa} khong ton tai");
                    return;
                }
                ar_lstDoDac.RemoveAt(vitrixoa - 1);
                Console.WriteLine("Xoa thanh cong!");
            }
        }
        public void InRa_ThongTinKH()
        {
            Console.WriteLine($"Ten khach hang: {ten}" +
                $"Tuoi cua khach hang: {tuoi}");
            Console.WriteLine("danh sach do dung cua khach hang: ");
            foreach (DoDac item in ar_lstDoDac)
            {
                item.InThongTin();
            }
        }
        public double TongTheTich()
        {
            double sum = 0;
            if (Tao_tun.checkCount(ar_lstDoDac))
            {
                foreach (DoDac item in ar_lstDoDac)
                {
                    sum += item.TheTich;
                }
                
            }
            return sum;
        }
        public void SuaDoDac()
        {
            if (Tao_tun.checkCount(ar_lstDoDac))
            {
                int vitri = 0;
                int vitrisua;
                Console.WriteLine("Bang do dac:");
                foreach (DoDac item in ar_lstDoDac)
                {
                    Console.Write($"Do thu {vitri + 1} : ");
                    item.InThongTin();
                    vitri++;
                }
            
                vitrisua = Convert.ToInt32(Tao_tun.getInput("Vi tri muon sua"));
                if (vitrisua - 1 > ar_lstDoDac.Count)
                {
                    Console.WriteLine($"Vi tri {vitrisua} khong ton tai");
                    return;
                }
                DoDac sua = (DoDac)ar_lstDoDac[vitrisua - 1]; ;
                int chon;
                do
                {
                    Console.WriteLine("-----menu sua thong tin--------");
                    Console.WriteLine("1.sua chieu dai");
                    Console.WriteLine("2.sua chieu rong");
                    Console.WriteLine("3.sua chieu sau");
                    Console.WriteLine("0.thoat");
                    chon = Convert.ToInt32(Console.ReadLine());
                    switch (chon)
                    {
                        case 0:
                            break;
                            case 1:
                            sua.ChieuDai = Convert.ToDouble(Tao_tun.getInput_Regex("sua chieu dai", @"^[\d]+\,?[\d]*$"));
                            break;
                            case 2:
                            sua.ChieuRong = Convert.ToDouble(Tao_tun.getInput_Regex("sua chieu rong", @"^[\d]+\,?[\d]*$"));
                            break;
                            case 3:
                            sua.ChieuSau = Convert.ToDouble(Tao_tun.getInput_Regex("sua chieu sau", @"^[\d]+\,?[\d]*$"));
                            break;
                        default:
                            Console.WriteLine("khong co loai Sua nay mau chon lai!!");
                            break;
                    }
                } while (chon!=0);
                ar_lstDoDac[vitrisua - 1] = sua;
                Console.WriteLine("Sua thanh cong!!");
            }
        }
    }
}
