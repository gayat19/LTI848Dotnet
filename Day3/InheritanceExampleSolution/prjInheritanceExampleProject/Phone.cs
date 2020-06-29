using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInheritanceExampleProject
{
    class Phone
    {
        string dialingOption;
        private int ringingVolume;
        private string color;

        public int RingingVolume { get => ringingVolume; set => ringingVolume = value; }
        public string Color { get => color; set => color = value; }

        public void Ring()
        {
            Console.WriteLine("Tring tring");
        }
        public void MakeCall(string name)//pass data to a method using a parameter
        {
            Console.WriteLine("Calling....."+name);
        }
        public void ReceiveCall(string number)
        {
            Console.WriteLine("Call from "+number);
        }
    }
}
