using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Semi : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The Semi is loaded and ready to go!");
        }
    }
}
