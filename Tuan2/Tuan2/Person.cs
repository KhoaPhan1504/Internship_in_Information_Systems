using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Person()
        {

        }

        public Person(int Id, string Name, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
        }

        public virtual void Input()
        {
            Console.Write("Mã: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Họ và tên: ");
            Name = Console.ReadLine().ToString();
            Console.Write("Địa chỉ: ");
            Address = Console.ReadLine().ToString();
        }

        public virtual void Output()
        {
            Console.WriteLine("Mã: {0}", Id);
            Console.WriteLine("Họ và tên: {0}", Name);
            Console.WriteLine("Địa chỉ {0}:", Address);
        }
    }
}

