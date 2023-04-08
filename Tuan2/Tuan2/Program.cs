using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1.Thêm một sinh viên");
            Console.WriteLine("2.Hiển thị danh sách sinh viên");
            Console.WriteLine("3.Tìm kiếm thí sinh theo id");
            Console.WriteLine("4.Tìm kiếm thí sinh theo address");
            Console.WriteLine("5.Xóa một sinh viên theo id");
            Console.WriteLine("6.Kêt thúc chương trình");
        }

        public static void Show(List<Student> students)
        {
            Console.WriteLine("DANH SÁCH SINH VIÊN");
            foreach (Student student in students)
            {
                student.Output();
                Console.WriteLine("---------------------------");
            }
            Console.ReadLine();
        }

        public static void FilterByID(List<Student> students)
        {
            Console.Write("Mã sinh viên: ");
            int iD = Convert.ToInt32(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.Id == iD);
            if (student != null)
            {
                Console.WriteLine("THÔNG TIN SINH VIÊN");
                student.Output();
            }
            else
                Console.Write("Không tồn tại mã sinh viên {0}", iD);
            Console.ReadLine();
        }

        public static void FilterByAddress(List<Student> students)
        {
            Console.Write("Địa chỉ: ");
            string address = Console.ReadLine();
            var studentByAddress = students.Where(s => s.Address == address).ToList();
            if (studentByAddress.Count() > 0)
            {
                Console.WriteLine("THÔNG TIN SINH VIÊN");
                foreach (Student student in studentByAddress)
                {
                    student.Output();
                    Console.WriteLine("---------------------------");
                }
            }
            else
                Console.Write("Không tồn tại sinh viên có địa chỉ {0}", address);
            Console.ReadLine();
        }

        public static void Delete(List<Student> students)
        {
            Console.Write("Mã sinh viên: ");
            int iD = Convert.ToInt32(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.Id == iD);
            if (student != null)
            {
                students.Remove(student);
                Console.Write("Mã sinh viên {0} đã được xóa", iD);
            }
            else
                Console.Write("Không tồn tại mã sinh viên {0}", iD);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Menu();
                int key = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (key)
                {
                    case 1:
                        Student student = new Student();
                        student.Input();
                        students.Add(student);
                        break;
                    case 2:
                        Show(students);
                        break;
                    case 3:
                        FilterByID(students);
                        break;
                    case 4:
                        FilterByAddress(students);
                        break;
                    case 5:
                        Delete(students);
                        break;
                    case 6:
                        return;
                }
                Console.Clear();
            }
        }
    }
}
