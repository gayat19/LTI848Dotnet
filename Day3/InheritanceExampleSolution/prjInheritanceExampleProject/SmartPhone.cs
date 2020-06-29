using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInheritanceExampleProject
{
    class SmartPhone : MobilePhone
    {
        public void PlayGame()
        {
            Console.WriteLine("Game starts");
        }
        public void WhatsApping()
        {
            Console.WriteLine("Use WhatsApp");
        }
    }
}
