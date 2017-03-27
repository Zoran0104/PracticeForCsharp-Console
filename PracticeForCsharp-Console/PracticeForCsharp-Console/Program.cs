using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeForCsharp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.Name = "张三";
            people.Weight = 60;
            people.Introduce();
        }
    }
    class People
    {
        private string name;
        private int weight;
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Weight
        {
            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }
        }
        public void Introduce()
        {
            Console.WriteLine("我叫{0}，我的体重是{1}kg.", name, weight);
        }
    }
}
