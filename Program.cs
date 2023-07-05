using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangdhph31492_Training_Csharp_B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            int chon;
            List<KhachHang> lst = new List<KhachHang>();
            List<CTY_Chuyen_Do> lstCty = new List<CTY_Chuyen_Do>();
            do
            {
                Console.WriteLine("--------Menu---------");
                Console.WriteLine("1.nhap thong tin khach hang va do dung");
                Console.WriteLine("2. xuat thong tin khach hang va do dung");
                Console.WriteLine("3.nhap thong tin cong ty");
                Console.WriteLine("4.them khach hang vao cong ty");
                Console.WriteLine("5.xoa khach hang khoi cong ty");
                Console.WriteLine("6.xuat danh sach khach hang trong cong ty");
                chon = Convert.ToInt32(Tao_tun.getInput("chuc nang muon chay: "));
                switch (chon)
                {
                    case 0: 
                        Environment.Exit(0);
                        break;
                    case 1:
                        string tt;
                        do
                        {
                            KhachHang kh = new KhachHang();
                            kh.Ten = Tao_tun.getInput_Regex("ten khach hang: ", @"^[a-zA-Z]+$");
                            kh.Tuoi = Convert.ToInt32(Tao_tun.getInput_Regex("tuoi khach hang", @"^[\d]+$"));
                            kh.SDT = Convert.ToInt32(Tao_tun.getInput_Regex("so dien thoai khach hang", @"^[0][\d]{10}$"));
                            kh.DiaChi = Tao_tun.getInput("dia chi cua khach hang: ");
                            kh.nhapDoDac();
                            lst.Add(kh);
                            Console.WriteLine("co muon nhap tiep ko(co/ko)?");
                            tt = Console.ReadLine();
                        } while (tt.Equals("co"));
                        break;
                    case 2:
                        if (lst.Count == 0)
                        {
                            Console.WriteLine("danh sach trong!!!");
                            return;
                        }
                        foreach (var item in lst)
                        {
                            item.InRa_ThongTinKH();
                        }
                        break;
                    case 3:
                        CTY_Chuyen_Do cty = new CTY_Chuyen_Do();
                        cty.TenCongTy = Tao_tun.getInput("ten cong ty:");
                        foreach (var item in lst)
                        {
                            cty.Ar_lstKH.Add(item);
                        }
                        lstCty.Add(cty);
                        lst = new List<KhachHang>();
                        break;
                    case 4:
                        if (lstCty.Count!=0)
                        {
                            Console.WriteLine("Danh sach cong ty:");
                            int vitri = 0;
                            int vitrisua;
                            foreach (var item in lstCty)
                            {
                                Console.Write($"cong ty thu {vitri + 1} :");
                                item.InThongTinCTY();
                            }

                            vitrisua = Convert.ToInt32(Tao_tun.getInput("vi tri cong ty muon them khach hang:"));
                            if (vitrisua - 1 > lstCty.Count)
                            {
                                Console.WriteLine("cong ty khong ton tai!!");
                                return;
                            }
                            CTY_Chuyen_Do cty1 = (CTY_Chuyen_Do)lstCty[vitrisua - 1];
                            string tt1;
                            do
                            {
                                KhachHang kh = new KhachHang();
                                kh.Ten = Tao_tun.getInput_Regex("ten khach hang: ", @"^[a-zA-Z]+$");
                                kh.Tuoi = Convert.ToInt32(Tao_tun.getInput_Regex("tuoi khach hang", @"^[\d]+$"));
                                kh.SDT = Convert.ToInt32(Tao_tun.getInput_Regex("so dien thoai khach hang", @"^[0][\d]{10}$"));
                                kh.DiaChi = Tao_tun.getInput("dia chi cua khach hang: ");
                                kh.nhapDoDac();
                                cty1.themKH(kh);
                                Console.WriteLine("co muon nhap tiep ko(co/ko)?");
                                tt1 = Console.ReadLine();
                            } while (tt1.Equals("co"));
                            lstCty[vitrisua - 1] = cty1;
                        }
                        break;
                    case 5:
                        if (lstCty.Count != 0)
                        {
                            Console.WriteLine("Danh sach cong ty:");
                            int vitri = 0;
                            int vitrisua;
                            foreach (var item in lstCty)
                            {
                                Console.Write($"cong ty thu {vitri + 1} :");
                                item.InThongTinCTY();
                            }

                            vitrisua = Convert.ToInt32(Tao_tun.getInput("vi tri cong ty muon them khach hang:"));
                            if (vitrisua - 1 > lstCty.Count)
                            {
                                Console.WriteLine("cong ty khong ton tai!!");
                                return;
                            }
                            CTY_Chuyen_Do CTY = (CTY_Chuyen_Do)lstCty[vitrisua - 1];
                            CTY.XoaKH();
                            lstCty[vitrisua - 1] = CTY;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Cac cong ty hien co: ");
                        foreach (CTY_Chuyen_Do item in lstCty)
                        {
                            item.InThongTinCTY();
                        }
                        break;
                    default:
                        Console.WriteLine("Chuc nang ko ton tai!!!");
                        break;
                }


            } while (chon!=0);
        }
    }
}
