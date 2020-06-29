using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInheritanceExampleProject
{
    class MobilePhone : Phone
    {
        public void CarryPhone()
        {
            Console.WriteLine("You can carry the mobile phone with you");
            Console.WriteLine("Your Phone is {0} in color",Color);
            Console.WriteLine("Your phone will ring in {0} volume",RingingVolume);
        }
        public void Charge()
        {
            Console.WriteLine("Charging phone now");
        }
    }
}
