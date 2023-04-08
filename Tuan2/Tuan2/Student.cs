using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    class Student : Person
    {
        public byte Maths { get; set; }
        public byte Physics { get; set; }

        public Student()
        {

        }

        public Student(int Id, string Name, string Address, byte Maths, byte Physics)
        {
            base.Id = Id;
            base.Name = Name;
            base.Address = Address;
            this.Maths = Maths;
            this.Physics = Physics;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Điểm toán: ");
            Maths = Convert.ToByte(Console.ReadLine());
            Console.Write("Điểm lý: ");
            Physics = Convert.ToByte(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Điểm toán: {0}", Maths);
            Console.WriteLine("Điểm  lý: {0}", Physics);
            Console.WriteLine("Tổng  điểm: {0}", Total());
        }

        public byte Total()
        {
            return (byte)(Maths + Physics);
        }
    }
}
