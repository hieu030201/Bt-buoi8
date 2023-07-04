using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi8
{
    internal class BT
    {
        public void Bai1()
        {
            ArrayList A1 = new ArrayList(new object[] {"Hà Minh Hiếu", 22, true});
            ArrayList A2 = new ArrayList(new object[] { "Hà Minh Hải", 23, true });
       
            A1.InsertRange(A1.Count/2, new object[] {"03-02-2001", "Single"});
            A1.InsertRange(A1.Count / 2, A2);
            ArrayList cloneA1 = new ArrayList(A1);

            Console.WriteLine("-------***In ra phần tử A1***-------");
            foreach (var item in A1)
                Console.Write(item + " ,");
            Console.WriteLine("\n");
            Console.WriteLine("-------***In ra phần tử A2***-------");
            foreach(var item in A2)
                Console.Write(item + " ,");
            Console.WriteLine("\n");

            Console.WriteLine("-------***Xóa bỏ phần tử***-------");

            Console.WriteLine("1.Xóa 1 phần tử theo vị trí chỉ định");
            Console.Write("Nhập vị trí chỉ định: ");
            int inputIndex = int.Parse(Console.ReadLine());
            cloneA1.RemoveAt(inputIndex);
            foreach(var item in cloneA1)
                Console.Write(item+" ,");
            Console.WriteLine();
            Console.WriteLine("2.Xóa nhiều phần tử trong vị trí chỉ định");
            Console.Write("Nhập vị trí index bắt đầu: ");
            int indexBegin = int.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng phần tử cần xóa: ");
            int quantity = int.Parse(Console.ReadLine());
            cloneA1.RemoveRange(indexBegin, quantity);
            foreach(var item in cloneA1)
                Console.Write(item+" ,");

            Console.WriteLine("\n-------***Kiểm tra sự tồn tại của phần tử có trong mảng***-------");
            Console.Write("Nhập giá trị kiểm tra:");
            string inputExist = Console.ReadLine();
            object checkExist = Convert.ChangeType(inputExist, typeof(object));

            if (A1.Contains(checkExist))
            {
                Console.WriteLine("The list contains '{0}'.", checkExist);
            }
            else
            {
                Console.WriteLine("The list does not contains '{0}'.", checkExist);
            }
        }

        public void Bai2()
        {
            Console.WriteLine("--------------***Bài tập sử dụng Generic***--------------");
            List<int> danhSachSoNguyen = new List<int>();
            Console.Write("Nhập số phần tử thêm vào Generic List: ");
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                danhSachSoNguyen.Add(rand.Next(1, 10));
            }
            foreach(var item in danhSachSoNguyen)
            {
                Console.Write(item+", ");
            }

            Console.WriteLine("\n----------------*** Đảo ngược danh sách ***----------------");
            List<int> clonedList = new List<int>(danhSachSoNguyen);
            clonedList.Reverse();
            foreach (var item in clonedList)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            Console.Write("\nNhập số cần xóa:");
            int inputSearch = int.Parse(Console.ReadLine());
            for(int i=0; i < danhSachSoNguyen.Count; i++)
            {
                if (danhSachSoNguyen.Contains(inputSearch))
                    danhSachSoNguyen.Remove(inputSearch);
            }
            Console.WriteLine("Danh sách sau khi xóa là:");
            foreach (var item in danhSachSoNguyen)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("\n----------------*** Sắp xếp theo chiều ***----------------");

            Console.Write("1.Chiều tăng dần: ");
            List<int> clonedList2 = new List<int>(danhSachSoNguyen);
            clonedList.Sort();
            foreach (var item in clonedList2)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.Write("2.Chiều giảm dần: ");
            List<int> clonedList3 = new List<int>(danhSachSoNguyen);
            clonedList3.Reverse();
            clonedList3.Sort();
            foreach (var item in clonedList3)
            {
                Console.Write(item + ", ");
            }
        } 
    }
}
