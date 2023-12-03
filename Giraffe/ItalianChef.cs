using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes cool pasta");
        }
    }
}
