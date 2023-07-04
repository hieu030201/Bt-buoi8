using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi8
{
    struct SinhVien
    {
        public string HoTen;
        public string GioiTinh;
        public string Quequan;
        public double HocLuc;
    }

    internal class SV
    { 
        public void MainB1()
        {

            Console.Write("Nhấp số sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập sinh viên thứ {0}", i + 1);
                Console.Write("Nhập họ tên: ");
                sv[i].HoTen = Console.ReadLine();
                Console.Write("Nhập giới tính: ");
                sv[i].GioiTinh = Console.ReadLine();
                Console.Write("Nhập quê quán: ");
                sv[i].Quequan = Console.ReadLine();
                Console.Write("Nhập học lực: ");
                sv[i].HocLuc = double.Parse(Console.ReadLine());
            }

            ArrayList ListSV = new ArrayList();
            ListSV.AddRange(sv);
            Console.WriteLine();
            Console.WriteLine("Danh sach sinh vien:");
            int dem = 1;
            foreach(SinhVien svi in ListSV)
            {
                Console.WriteLine("{0}. {1} - {2} - {3} - {4} ",
                    dem++, svi.HoTen, svi.GioiTinh, svi.Quequan,
                    svi.HocLuc);
            }
            Console.WriteLine("---------------*** Xóa phần tử theo vị trí chỉ định ***---------------");
            Console.WriteLine("1.Xóa phần tử theo vị trí chỉ định");
            Console.Write("Nhập số lần xóa:");
            int removeSV = int.Parse(Console.ReadLine());
            for (int i = 0; i < removeSV; i++)
            {
                Console.Write("Nhập vị trí chỉ định: ");
                int inputIndex = int.Parse(Console.ReadLine());
                ListSV.RemoveAt(inputIndex);
            }
            Console.WriteLine("----------------***In ra danh sách sinh viên sau khi xóa***----------------");
            int demFistNew = 1;
            foreach (SinhVien svi in ListSV)
            {
                Console.WriteLine("{0}. {1} - {2} - {3} - {4} ",
                    demFistNew++, svi.HoTen, svi.GioiTinh, svi.Quequan,
                    svi.HocLuc);
            }

            Console.WriteLine("---------------*** Thêm sinh viên *---------------");
            Console.Write("Thêm số sinh viên:");
            int addNewSV = int.Parse(Console.ReadLine());
            SinhVien[] svnew = new SinhVien[addNewSV];
            for (int i = 0; i < addNewSV; i++)
            {
                Console.WriteLine("Nhập sinh viên thứ {0}", i + 1);
                Console.Write("Nhập họ tên: ");
                svnew[i].HoTen = Console.ReadLine();
                Console.Write("Nhập giới tính: ");
                svnew[i].GioiTinh = Console.ReadLine();
                Console.Write("Nhập quê quán: ");
                svnew[i].Quequan = Console.ReadLine();
                Console.Write("Nhập học lực: ");
                svnew[i].HocLuc = double.Parse(Console.ReadLine());
            }
            ListSV.AddRange(svnew);
            int demNew = 1;
            Console.WriteLine("---------------*** In ra danh sách sau khi thêm sinh viên là ***---------------");
            foreach (SinhVien svi in ListSV)
            {
                Console.WriteLine("{0}. {1,-15} - {2,-10} - {3,-10} - {4,-10} ",
                    demNew++, svi.HoTen, svi.GioiTinh, svi.Quequan,
                    svi.HocLuc);
            }


        }


    }
}
